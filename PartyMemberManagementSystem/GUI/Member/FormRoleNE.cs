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
    public partial class FormRoleNE : Form
    {
        public Boolean newEdit;
        public int roleid;
        public FormRoleNE()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            try
            {
                
                if (newEdit == true)
                {
                    string sql = "INSERT INTO tblRole (RoleName, Detail,Active) VALUES(@rolename,@detail,1)";
                    Cmd.Parameters["@rolename"] = txtRoleName.Text;
                    Cmd.Parameters["@detail"] = txtDetail.Text;
                    Cmd.ExecuteNonQuery(sql);
                    MessageBox.Show("INSERT SUCCESS!!!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    //Cmd.Parameters["@villageid"] = cboVillage.SelectedValue;
                    Cmd.Parameters["@rname"] = txtRoleName.Text;
                    Cmd.Parameters["@detail"] = txtDetail.Text;
                    Cmd.Parameters["@id"] = roleid;
                    string sql = "UPDATE tblRole SET RoleName=@rname,Detail=@detail WHERE RoleID=@id";
                    Cmd.ExecuteNonQuery(sql);
                    MessageBox.Show("Update Success!!!");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
