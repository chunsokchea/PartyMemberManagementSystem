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
    public partial class FormGroupNE : Form
    {
        public int groupId;
        public int villageId;
        public Boolean newEdit;
        public FormGroupNE()
        {
            InitializeComponent();
            loadVillageCbo();
            //cboVillage.SelectedValue = villageId;
        }
        private void loadVillageCbo()
        {
            string sql = "SELECT * FROM tblVillage";
            DataTable dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable(sql);
            cboVillage.DisplayMember = "VillageName";
            cboVillage.ValueMember = "VillageID";
            cboVillage.DataSource = dtv;
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (newEdit == true)
                {
                    
                    Cmd.Parameters["@villageid"] =  cboVillage.SelectedValue;
                    Cmd.Parameters["@gname"] = txtGroupName.Text;
                    Cmd.Parameters["@detail"]=txtDetail.Text;
                    string sql = "INSERT INTO tblGroup (VillageID, GroupName, Detail, Active) VALUES(@villageid,@gname,@detail,1)";
                    Cmd.ExecuteNonQuery(sql);
                    MessageBox.Show("INSERT SUCCESS!!!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Cmd.Parameters["@villageid"] = cboVillage.SelectedValue;
                    Cmd.Parameters["@gname"] = txtGroupName.Text;
                    Cmd.Parameters["@detail"] = txtDetail.Text;
                    Cmd.Parameters["@id"] = groupId;
                    string sql = "UPDATE tblGroup SET VillageID=@villageid, GroupName=@gname,Detail=@detail WHERE GroupID=@id";
                    Cmd.ExecuteNonQuery(sql);
                    MessageBox.Show("Update Success!!!");
                    this.DialogResult = DialogResult.OK;
                }
                
                
            }
            catch(Exception ex)
            {
               // this.DialogResult = DialogResult.OK;
                MessageBox.Show("" + ex);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + villageId);
        }

        private void FormGroupNE_Load(object sender, EventArgs e)
        {
            Cmd.Parameters["@groupid"] = groupId;
            cboVillage.SelectedValue = Cmd.ExecuteScalar("SELECT v.villageid FROM tblVillage v INNER JOIN tblGroup g on g.VillageID=v.VillageID WHERE g.GroupID=@groupid");
            
        }
    }
}
