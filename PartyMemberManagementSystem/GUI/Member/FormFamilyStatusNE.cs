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
    public partial class FormFamilyStatusNE : Form
    {
        public int sId;
        public FormFamilyStatusNE()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            //DataTable dt = new DataTable();
            //Cmd.Parameters["@sis"] = sId;
            //dt = Cmd.ExecuteDataTable("SELECT");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
