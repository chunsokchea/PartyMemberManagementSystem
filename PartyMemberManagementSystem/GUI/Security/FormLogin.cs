using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMemberManagementSystem.GUI.Security
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.ToUpper() == "ADMIN" && txtpwd.Text=="b05061990")
            {
                MessageBox.Show("Correct");
                this.Close();
            }
            else {
                MessageBox.Show("Incorrect");
            }

        }
    }
}
