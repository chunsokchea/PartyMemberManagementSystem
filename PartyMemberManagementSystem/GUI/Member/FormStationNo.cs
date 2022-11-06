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
    public partial class FormStationNo : Form
    {
        public FormStationNo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (txtNoName.Text.Trim()=="")
            {
                MessageBox.Show("សូមបញ្ចូលលេខការិយាល័យបោះឆ្នោត!");
                txtNoName.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
