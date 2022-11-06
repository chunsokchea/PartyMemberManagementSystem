using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMemberManagementSystem.GUI.Member
{
    public partial class FormStationNE : Form
    {
        public Boolean newEdit=true;
        public int sId;
        public FormStationNE()
        {
            InitializeComponent();
            
        }

        private void loadData()
        {
            Cmd.Parameters["@sid"] = sId;
            txtStation.Text=(string)Cmd.ExecuteScalar("SELECT StationName FROM tblVoteStation WHERE StationID=@sid");
            DataTable dtsn = new DataTable();

            Cmd.Parameters["@sid"] = sId;
            dtsn = Cmd.ExecuteDataTable("SELECT StationNoName, StationNoID, Detail FROM tblStationNo WHERE Active=true AND StationID=@sid");
            dataGridView1.DataSource = dtsn;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStation.Text.Trim()=="")
            {
                MessageBox.Show("សូមបំពេញការិយាល័យបោះឆ្នោត!");
                txtStation.Focus();
                return;
            }

            if (dataGridView1.Rows.Count == 0) 
            {
                MessageBox.Show("សូមបញ្ចូលទិន្នន័យលេខការិយាល័យ!!!");
                btnAdd_Click(sender,e);
                return;
            }
            if (newEdit==true)
            {
                //int sId = (int)Cmd.ExecuteScalar("SELECT StationID FROM tblVoteStation WHERE Active=true ORDER BY StationID DESC");
                //MessageBox.Show("TRUE "+ sId);
                Cmd.Begin();
                try
                {
                    Cmd.Parameters["@name"] = txtStation.Text.Trim();
                    string sql = "INSERT INTO tblVoteStation (StationName,Active) VALUES(@name,true)";
                    Cmd.ExecuteNonQuery(sql);
                    int count = dataGridView1.Rows.Count;
                    int sId = (int)Cmd.ExecuteScalar("SELECT StationID FROM tblVoteStation WHERE Active=true ORDER BY StationID DESC");
                    for (int i = 0; i < count; i++)
                    {
                        Cmd.Parameters["@name"] = dataGridView1.Rows[i].Cells["StationNoName"].Value.ToString();
                        Cmd.Parameters["@detail"] = dataGridView1.Rows[i].Cells["Detail"].Value.ToString();
                        Cmd.Parameters["@sId"] = sId;
                        string sql2 = "INSERT INTO tblStationNo (StationNoName, Detail,StationID, Active) VALUES(@name, @detail, @sid, true)";
                        Cmd.ExecuteNonQuery(sql2);
                    }
                    Cmd.Commit();
                    MessageBox.Show("បញ្ចូលបានជោគជ័យ!");
                }
                catch (Exception ex)
                {
                    Cmd.Rollback();
                    throw;
                }
                
            }else
            {
               // MessageBox.Show("FAlSE");
                Cmd.Parameters["@name"] = txtStation.Text.Trim();
                Cmd.Parameters["@sid"] = sId;
                Cmd.ExecuteNonQuery("UPDATE tblVoteStation SET StationName=@name WHERE StationID=@sid");
                MessageBox.Show("កែប្រែបានជោគជ័យ!");
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormStationNo frm = new FormStationNo();
            
            if (frm.ShowDialog()==DialogResult.OK)
            {
                if (this.newEdit == true)
                {
                    //MessageBox.Show("Refresh");
                    //this.dataGridView1.Rows.Add("","");
                    int rowId = dataGridView1.Rows.Add();
                    // Grab the new row!
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    // Add the data
                    row.Cells["StationNoName"].Value = frm.txtNoName.Text.Trim();
                    row.Cells["Detail"].Value = frm.txtDetail.Text.Trim();
                }
                else
                {
                    try
                    {
                        Cmd.Parameters["@name"] = frm.txtNoName.Text.Trim();
                        Cmd.Parameters["@detail"] = frm.txtDetail.Text.Trim();
                        Cmd.Parameters["@sid"] = this.sId;
                        Cmd.ExecuteNonQuery("INSERT INTO tblStationNo (StationNoName, Detail, StationID, Active) VALUES(@name, @detail, @sid, true)");
                        loadData();
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }                    
                }
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dataGridView1.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            FormStationNo frm = new FormStationNo();
            frm.txtNoName.Text=row.Cells["StationNoName"].Value.ToString();
            frm.txtDetail.Text = row.Cells["Detail"].Value.ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cmd.Parameters["@name"]=frm.txtNoName.Text.Trim();
                    Cmd.Parameters["@detail"] = frm.txtDetail.Text.Trim();
                    Cmd.Parameters["@nId"]=(int)row.Cells["StationNoID"].Value;
                    Cmd.ExecuteNonQuery("UPDATE tblStationNo SET StationNoName=@name, Detail=@detail WHERE StationNoID=@nId");
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
            }
            MessageBox.Show("កែប្រែបានជោគជ័យ!");
            loadData();
            //this.DialogResult = DialogResult.OK;
        }

        private void FormStationNE_Load(object sender, EventArgs e)
        {
            if (newEdit == false)
            {
                loadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dataGridView1.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }

            Cmd.Parameters["@nId"]=(int)row.Cells["StationNoID"].Value;
            Cmd.ExecuteNonQuery("UPDATE tblStationNo SET Active=false WHERE StationNoID=@nId");

            MessageBox.Show("លុបទិន្នន័យបានសម្រេច!!!");
            loadData();
        }
    }
}
