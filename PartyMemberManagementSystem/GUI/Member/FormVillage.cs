using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SecurityP;

namespace PartyMemberManagementSystem.GUI.Member
{
    public partial class FormVillage : Form
    {
        public FormVillage()
    {
            InitializeComponent();
            loadDataVillage();
            UI.FormatDataGrid(dgvList);
            //UI.SetPlaceHolder(txtsearch);
            btnUpdate.Click += dgvList_DoubleClick; 
        }

        private void loadDataVillage()
        {
            DataTable dtv = new DataTable();
            String sql = "SELECT * FROM tblVillage where Active=true";
            dtv = Cmd.ExecuteDataTable(sql);
            dgvList.DataSource =dtv;
            
        }

        private DataTable AutoNumberedTable(DataTable SourceTable)
        {

            DataTable ResultTable = new DataTable();

            DataColumn AutoNumberColumn = new DataColumn();

            AutoNumberColumn.ColumnName = "No.";

            AutoNumberColumn.DataType = typeof(int);

            AutoNumberColumn.AutoIncrement = true;

            AutoNumberColumn.AutoIncrementSeed = 1;

            AutoNumberColumn.AutoIncrementStep = 1;           

            ResultTable.Columns.Add(AutoNumberColumn);

            ResultTable.Merge(SourceTable);

            return ResultTable;

        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            FormVillageNE frm = new FormVillageNE();
            frm.txtVillageName.Text = (string)row.Cells["villageName"].Value;
            frm.txtDetail.Text = (string)row.Cells["detail"].Value;
            int id = (int)row.Cells["villageID"].Value;
            frm.id = id;            
            frm.newEdit = false;
            //MessageBox.Show("" + id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtsearch.Clear();
                loadDataVillage();                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormVillageNE frm = new FormVillageNE();
            frm.newEdit = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtsearch.Clear();
                loadDataVillage();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void FormVillage_Load(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = App.IsAuthorized(Permissions.Manage_Village_Add);
            this.btnUpdate.Enabled = App.IsAuthorized(Permissions.Manage_village_Edit);
            this.btnDelete.Enabled = App.IsAuthorized(Permissions.Manage_Village_Delete);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            if (MessageBox.Show("YOU REAL WANT TO DELETE (" + row.Cells["VillageName"].Value + ")!", "DELETE Village", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Cmd.Parameters["@VillageID"] = row.Cells["villageID"].Value;
                    Cmd.ExecuteNonQuery("UPDATE tblVillage SET [Active]=False WHERE VillageID=@VillageID");
                    MessageBox.Show("DELETE SUCCESS!");
                }
                catch
                {
                    MessageBox.Show("DELETE FAIL!");
                }
                //MessageBox.Show("ABC");
                loadDataVillage();
            }
            
        }
    }
}
