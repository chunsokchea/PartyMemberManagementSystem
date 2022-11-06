namespace PartyMemberManagementSystem.GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbltoolStripKHTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.MSMenu = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePwdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuList = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListMember = new System.Windows.Forms.ToolStripMenuItem();
            this.familyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageVillage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageStation = new System.Windows.Forms.ToolStripMenuItem();
            this.familyStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageRole = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemRole = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.reportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.MSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.lblUser,
            this.toolStripStatusLabel1,
            this.lbltoolStripKHTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 424);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(828, 29);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(83, 24);
            this.toolStripStatusLabel.Text = "អ្នកប្រើប្រាស់ :";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 24);
            this.lblUser.Text = "User";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(617, 24);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // lbltoolStripKHTime
            // 
            this.lbltoolStripKHTime.Name = "lbltoolStripKHTime";
            this.lbltoolStripKHTime.Size = new System.Drawing.Size(75, 24);
            this.lbltoolStripKHTime.Text = "khmerTime";
            // 
            // MSMenu
            // 
            this.MSMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(223)))), ((int)(((byte)(234)))));
            this.MSMenu.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.menuList,
            this.menuManage,
            this.menuSystem,
            this.menuReport,
            this.RecycleToolStripMenuItem,
            this.AboutMeToolStripMenuItem,
            this.ListToolStripMenuItem});
            this.MSMenu.Location = new System.Drawing.Point(0, 0);
            this.MSMenu.Name = "MSMenu";
            this.MSMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MSMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MSMenu.Size = new System.Drawing.Size(828, 32);
            this.MSMenu.TabIndex = 4;
            this.MSMenu.Text = "MenuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageToolStripMenuItem1,
            this.ChangePwdToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.systemToolStripMenuItem.Text = "ឯកសារ";
            // 
            // ManageToolStripMenuItem1
            // 
            this.ManageToolStripMenuItem1.Name = "ManageToolStripMenuItem1";
            this.ManageToolStripMenuItem1.Size = new System.Drawing.Size(154, 28);
            this.ManageToolStripMenuItem1.Text = "កំណត់";
            this.ManageToolStripMenuItem1.Click += new System.EventHandler(this.ManageToolStripMenuItem1_Click);
            // 
            // ChangePwdToolStripMenuItem
            // 
            this.ChangePwdToolStripMenuItem.Name = "ChangePwdToolStripMenuItem";
            this.ChangePwdToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.ChangePwdToolStripMenuItem.Text = "ប្តូរលេខសំងាត់";
            this.ChangePwdToolStripMenuItem.Visible = false;
            this.ChangePwdToolStripMenuItem.Click += new System.EventHandler(this.ChangePwdToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.LogOutToolStripMenuItem.Text = "ចាកចេញ";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // menuList
            // 
            this.menuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.menuListMember,
            this.familyListToolStripMenuItem});
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(88, 28);
            this.menuList.Text = "បញ្ជីសមាជិក";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.NewToolStripMenuItem.Text = "បន្ថែមថ្មី";
            this.NewToolStripMenuItem.Visible = false;
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // menuListMember
            // 
            this.menuListMember.Name = "menuListMember";
            this.menuListMember.Size = new System.Drawing.Size(152, 28);
            this.menuListMember.Text = "បញ្ជីសមាជិក";
            this.menuListMember.Visible = false;
            this.menuListMember.Click += new System.EventHandler(this.MemberListToolStripMenuItem_Click);
            // 
            // familyListToolStripMenuItem
            // 
            this.familyListToolStripMenuItem.Name = "familyListToolStripMenuItem";
            this.familyListToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.familyListToolStripMenuItem.Text = "បញ្ជីគ្រួសារ";
            this.familyListToolStripMenuItem.Click += new System.EventHandler(this.familyListToolStripMenuItem_Click);
            // 
            // menuManage
            // 
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManageVillage,
            this.menuManageStation,
            this.familyStatusToolStripMenuItem,
            this.menuManageRole,
            this.UserToolStripMenuItem});
            this.menuManage.Name = "menuManage";
            this.menuManage.Size = new System.Drawing.Size(66, 28);
            this.menuManage.Text = "គ្រប់គ្រង";
            // 
            // menuManageVillage
            // 
            this.menuManageVillage.Name = "menuManageVillage";
            this.menuManageVillage.Size = new System.Drawing.Size(168, 28);
            this.menuManageVillage.Text = "ភូមិ";
            this.menuManageVillage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuManageVillage.Click += new System.EventHandler(this.VillageToolStripMenuItem_Click);
            // 
            // menuManageStation
            // 
            this.menuManageStation.Name = "menuManageStation";
            this.menuManageStation.Size = new System.Drawing.Size(168, 28);
            this.menuManageStation.Text = "មណ្ឌលបោះឆ្នោត";
            this.menuManageStation.Click += new System.EventHandler(this.GroupToolStripMenuItem_Click);
            // 
            // familyStatusToolStripMenuItem
            // 
            this.familyStatusToolStripMenuItem.Name = "familyStatusToolStripMenuItem";
            this.familyStatusToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.familyStatusToolStripMenuItem.Text = "ស្ថានភាពគ្រួសារ";
            this.familyStatusToolStripMenuItem.Click += new System.EventHandler(this.familyStatusToolStripMenuItem_Click);
            // 
            // menuManageRole
            // 
            this.menuManageRole.Name = "menuManageRole";
            this.menuManageRole.Size = new System.Drawing.Size(168, 28);
            this.menuManageRole.Text = "តួនាទីសមាជិក";
            this.menuManageRole.Click += new System.EventHandler(this.RoleToolStripMenuItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.UserToolStripMenuItem.Text = "អ្នកប្រើប្រាស់";
            this.UserToolStripMenuItem.Visible = false;
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystemUser,
            this.menuSystemRole});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(53, 28);
            this.menuSystem.Text = "ប្រព័ន្ធ";
            // 
            // menuSystemUser
            // 
            this.menuSystemUser.Name = "menuSystemUser";
            this.menuSystemUser.Size = new System.Drawing.Size(176, 28);
            this.menuSystemUser.Text = "អ្នកប្រើប្រាស់";
            this.menuSystemUser.Click += new System.EventHandler(this.menuSystemUser_Click);
            // 
            // menuSystemRole
            // 
            this.menuSystemRole.Name = "menuSystemRole";
            this.menuSystemRole.Size = new System.Drawing.Size(176, 28);
            this.menuSystemRole.Text = "តួនាទីអ្នកប្រើប្រាស់";
            this.menuSystemRole.Visible = false;
            this.menuSystemRole.Click += new System.EventHandler(this.menuSystemRole_Click);
            // 
            // menuReport
            // 
            this.menuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportListToolStripMenuItem,
            this.reportTestToolStripMenuItem,
            this.listAllToolStripMenuItem});
            this.menuReport.Name = "menuReport";
            this.menuReport.Size = new System.Drawing.Size(86, 28);
            this.menuReport.Text = "របាយការណ៍";
            // 
            // reportListToolStripMenuItem
            // 
            this.reportListToolStripMenuItem.Name = "reportListToolStripMenuItem";
            this.reportListToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.reportListToolStripMenuItem.Text = "ReportList";
            this.reportListToolStripMenuItem.Visible = false;
            this.reportListToolStripMenuItem.Click += new System.EventHandler(this.reportListToolStripMenuItem_Click);
            // 
            // reportTestToolStripMenuItem
            // 
            this.reportTestToolStripMenuItem.Name = "reportTestToolStripMenuItem";
            this.reportTestToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.reportTestToolStripMenuItem.Text = "ReportTest";
            this.reportTestToolStripMenuItem.Visible = false;
            this.reportTestToolStripMenuItem.Click += new System.EventHandler(this.reportTestToolStripMenuItem_Click);
            // 
            // listAllToolStripMenuItem
            // 
            this.listAllToolStripMenuItem.Name = "listAllToolStripMenuItem";
            this.listAllToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.listAllToolStripMenuItem.Text = "បញ្ជីតាមក្រុម";
            this.listAllToolStripMenuItem.Click += new System.EventHandler(this.listAllToolStripMenuItem_Click);
            // 
            // RecycleToolStripMenuItem
            // 
            this.RecycleToolStripMenuItem.Name = "RecycleToolStripMenuItem";
            this.RecycleToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
            this.RecycleToolStripMenuItem.Text = "ធុងសំរាម";
            this.RecycleToolStripMenuItem.Visible = false;
            // 
            // AboutMeToolStripMenuItem
            // 
            this.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem";
            this.AboutMeToolStripMenuItem.Size = new System.Drawing.Size(49, 28);
            this.AboutMeToolStripMenuItem.Text = "អំពីខ្ញុំ";
            this.AboutMeToolStripMenuItem.Visible = false;
            this.AboutMeToolStripMenuItem.Click += new System.EventHandler(this.AboutMeToolStripMenuItem_Click);
            // 
            // ListToolStripMenuItem
            // 
            this.ListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.list1ToolStripMenuItem,
            this.list2ToolStripMenuItem,
            this.list3ToolStripMenuItem});
            this.ListToolStripMenuItem.Name = "ListToolStripMenuItem";
            this.ListToolStripMenuItem.Size = new System.Drawing.Size(44, 28);
            this.ListToolStripMenuItem.Text = "បញ្ជី";
            this.ListToolStripMenuItem.Visible = false;
            // 
            // list1ToolStripMenuItem
            // 
            this.list1ToolStripMenuItem.Name = "list1ToolStripMenuItem";
            this.list1ToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.list1ToolStripMenuItem.Text = "បញ្ជីតាមក្រុម";
            // 
            // list2ToolStripMenuItem
            // 
            this.list2ToolStripMenuItem.Name = "list2ToolStripMenuItem";
            this.list2ToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.list2ToolStripMenuItem.Text = "List2";
            // 
            // list3ToolStripMenuItem
            // 
            this.list3ToolStripMenuItem.Name = "list3ToolStripMenuItem";
            this.list3ToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.list3ToolStripMenuItem.Text = "List3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 453);
            this.Controls.Add(this.MSMenu);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "កម្មវិធីគ្រប់គ្រងទិន្នន័យសមាជិកបក្ស";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.MSMenu.ResumeLayout(false);
            this.MSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        internal System.Windows.Forms.MenuStrip MSMenu;
        internal System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ManageToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ChangePwdToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem menuList;
        internal System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem menuListMember;
        internal System.Windows.Forms.ToolStripMenuItem ListToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem menuManage;
        internal System.Windows.Forms.ToolStripMenuItem menuManageVillage;
        internal System.Windows.Forms.ToolStripMenuItem menuManageStation;
        internal System.Windows.Forms.ToolStripMenuItem menuManageRole;
        internal System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem menuReport;
        internal System.Windows.Forms.ToolStripMenuItem RecycleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem list1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem list2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem list3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripMenuItem menuSystemUser;
        private System.Windows.Forms.ToolStripMenuItem menuSystemRole;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbltoolStripKHTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem familyListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familyStatusToolStripMenuItem;
    }
}



