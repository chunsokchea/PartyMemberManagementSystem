using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PartyMemberManagementSystem.GUI.Security;
using PartyMemberManagementSystem.GUI.Member;
using PartyMemberManagementSystem.GUI.Report;
//using PartyMemberManagementSystem.GUI.Security;
using PartyMemberManagementSystem.Report;
using SecurityP;
using System.Globalization;
using System.Threading;
using PartyMemberManagementSystem.Properties;
namespace PartyMemberManagementSystem.GUI
{
    public partial class FormMain : Form
    {
        //private int childFormNumber = 0;

        public FormMain()
        {
            InitializeComponent();
            //FormLogin frm = new FormLogin();
            //frm.ShowDialog();
            //MSMenu.ForeColor= Color.FromArgb(255, 255, 255);
            
        }
              
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormMemberNE();
            frm.ShowDialog();
            //frm.MdiParent = this;
        }

        private void VillageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var frm = new FormVillage();
           frm.Show();
           frm.MdiParent = this;           
        }

        private void GroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormStation();
            frm.Show();
            frm.MdiParent = this;
        }

        private void RoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormRole();
            frm.Show();
            frm.MdiParent = this;
        }

        private void MemberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormMember();
            frm.Show();
            //frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void reportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ReportList();
            frm.ShowDialog();
            //frm.MdiParent = this;
        }

        private void reportTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormReport();
            frm.Show();
            frm.MdiParent = this;
        }

        private void listAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormList();
            frm.Show();
            //frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent= this;
        }

        private void AboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SecurityP.FormLogin();
            frm.Show();
            frm.MdiParent = this;
        }

        private void ManageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new PartyMemberManagementSystem.GUI.Security.FormUserSetting();
            frm.ShowDialog();
        }

        private void ChangePwdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SecurityP.FormChangePassword();
            frm.ShowDialog();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var ci = new CultureInfo(Settings.Default.Languguage);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            var frm = new SecurityP.FormLogin();
            frm.ShowDialog();
            lblUser.Text = App.UserFullName;

            this.menuManage.Enabled = SecurityP.App.IsAuthorized(Permissions.Manage);
            this.menuManageStation.Enabled = SecurityP.App.IsAuthorized(Permissions.Manage_Group);
            this.menuManageRole.Enabled = SecurityP.App.IsAuthorized(Permissions.Manage_Role);
            this.menuManageVillage.Enabled = SecurityP.App.IsAuthorized(Permissions.Manage_Village);

            //menuManageCustomer.Enabled = App.IsAuthorized(Permissions.Manage_Customer)
            //menuManageVendor.Enabled = App.IsAuthorized(Permissions.Manage_Vendor)
            //menuManageProduct.Enabled = App.IsAuthorized(Permissions.Manage_Product)
            //menuManageCategory.Enabled = App.IsAuthorized(Permissions.Manage_Category)
            //menuManageType.Enabled = App.IsAuthorized(Permissions.Manage_Type)
            //menuManageStore.Enabled = App.IsAuthorized(Permissions.Manage_Store)

            this.menuList.Enabled = SecurityP.App.IsAuthorized(Permissions.List);
            this.menuListMember.Enabled = SecurityP.App.IsAuthorized(Permissions.List_Member);

            //Me.menuTrans.Enabled = App.IsAuthorized(Permissions.Trans)
            //Me.menuTransInvoice.Enabled = App.IsAuthorized(Permissions.Trans_Invoice)
            //Me.menuTransPurchase.Enabled = App.IsAuthorized(Permissions.Trans_Purchase)
            //Me.menuTransTransfer.Enabled = App.IsAuthorized(Permissions.Trans_Transfer)

            this.menuSystem.Enabled = App.IsAuthorized(Permissions.Security);
            this.menuSystemUser.Enabled = App.IsAuthorized(Permissions.Security_User);
            this.menuSystemRole.Enabled = App.IsAuthorized(Permissions.Security_Role);
            this.menuReport.Enabled = App.IsAuthorized(Permissions.Report);
            
        }

        private void menuSystemUser_Click(object sender, EventArgs e)
        {
            var frm = new SecurityP.FormUser();
            frm.Show();
            frm.MdiParent = this;
        }

        private void menuSystemRole_Click(object sender, EventArgs e)
        {
            var frm = new SecurityP.FormRoleS();
            frm.Show();
            frm.MdiParent = this;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SecurityP.myCustomeDate.khmertime(lbltoolStripKHTime);
        }

        private void familyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormFamily();
            frm.Show();
            //frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void familyStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormFamilyStatus();
            frm.Show();
            frm.MdiParent = this;
        }
    }
}
