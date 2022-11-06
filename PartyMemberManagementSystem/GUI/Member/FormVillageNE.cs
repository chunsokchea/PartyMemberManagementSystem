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
    public partial class FormVillageNE : Form
    {
        public Boolean newEdit;
        public int id;
        public FormVillageNE()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (newEdit == true)
            {
                try
                {
                    Cmd.Parameters["@vname"] = txtVillageName.Text;
                    Cmd.Parameters["@detail"] = txtDetail.Text;
                    string sql = "INSERT INTO tblVillage (CommuneID,VillageName,Detail,Active) VALUES(1,@vname,@detail,1)";
                    Cmd.ExecuteNonQuery(sql);
                    MessageBox.Show("Insert Success!!!");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("" + ex);
                    //throw;
                    MessageBox.Show("Insert Failed!!!");
                }
                
            }
            else 
            {
               try
                {
                    
                    Cmd.Parameters["@vname"] = txtVillageName.Text;
                    Cmd.Parameters["@detail"] = txtDetail.Text;
                    Cmd.Parameters["@id"] = id;
                    string sql = "UPDATE tblVillage SET VillageName=@vname,Detail=@detail WHERE VillageID=@id";
                    Cmd.ExecuteNonQuery(sql);
                    MessageBox.Show("Update Success!!!");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {                   
                    MessageBox.Show("Update Failed!!!");
                }
            }
        }
    }
}
