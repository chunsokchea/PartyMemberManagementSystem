namespace PartyMemberManagementSystem.GUI.Member
{
    partial class FormFamilyN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFamilyN));
            this.dgvFamilyMember = new System.Windows.Forms.DataGridView();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboVillage = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFamilyBookNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroupNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.mName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationNoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CardIDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SencusSeen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Migration = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MigrationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MigrationInOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MigrationDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PeopleIDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoteRegister = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoteStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoteStationNoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationNoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFamilyMember
            // 
            this.dgvFamilyMember.AllowUserToAddRows = false;
            this.dgvFamilyMember.AllowUserToDeleteRows = false;
            this.dgvFamilyMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFamilyMember.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvFamilyMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFamilyMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilyMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.mName,
            this.StatusID,
            this.StationID,
            this.StationNoID,
            this.SexID,
            this.Sex,
            this.Dob,
            this.Age,
            this.Job,
            this.CardID,
            this.CardIDNo,
            this.Role,
            this.SencusSeen,
            this.Migration,
            this.MigrationID,
            this.MigrationInOut,
            this.MigrationDetail,
            this.Address,
            this.PeopleID,
            this.PeopleIDNo,
            this.DateIn,
            this.VoteRegister,
            this.RoleID,
            this.PhotoPath,
            this.Detail,
            this.VoteStationName,
            this.VoteStationNoName,
            this.StationNoName,
            this.FamilyStatusName});
            this.dgvFamilyMember.Location = new System.Drawing.Point(12, 176);
            this.dgvFamilyMember.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dgvFamilyMember.Name = "dgvFamilyMember";
            this.dgvFamilyMember.RowHeadersVisible = false;
            this.dgvFamilyMember.Size = new System.Drawing.Size(1083, 365);
            this.dgvFamilyMember.TabIndex = 0;
            this.dgvFamilyMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamilyMember_CellContentClick);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMember.Location = new System.Drawing.Point(994, 136);
            this.btnNewMember.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(101, 31);
            this.btnNewMember.TabIndex = 1;
            this.btnNewMember.Text = "បន្ថែមសមាជិក";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Muol Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "បង្កើតគ្រួសារថ្មី";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(994, 553);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 33);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(690, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 127);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 48;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboVillage);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFamilyBookNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGroupNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 112);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ព័ត៌មានភូមិ";
            // 
            // cboVillage
            // 
            this.cboVillage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVillage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVillage.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVillage.FormattingEnabled = true;
            this.cboVillage.Location = new System.Drawing.Point(53, 31);
            this.cboVillage.Name = "cboVillage";
            this.cboVillage.Size = new System.Drawing.Size(137, 30);
            this.cboVillage.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(448, 31);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(398, 68);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "សៀវភៅគ្រួសារបក្សលេខ​";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "អាសយដ្ឋាន";
            // 
            // txtFamilyBookNo
            // 
            this.txtFamilyBookNo.Location = new System.Drawing.Point(222, 72);
            this.txtFamilyBookNo.Name = "txtFamilyBookNo";
            this.txtFamilyBookNo.Size = new System.Drawing.Size(137, 31);
            this.txtFamilyBookNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "ក្រុមទី";
            // 
            // txtGroupNo
            // 
            this.txtGroupNo.Location = new System.Drawing.Point(53, 72);
            this.txtGroupNo.Name = "txtGroupNo";
            this.txtGroupNo.Size = new System.Drawing.Size(137, 31);
            this.txtGroupNo.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(12, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 22);
            this.label11.TabIndex = 51;
            this.label11.Text = "ភូមិ";
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Photo";
            this.Image.HeaderText = "រូបថត";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.Width = 110;
            // 
            // mName
            // 
            this.mName.DataPropertyName = "Name";
            this.mName.HeaderText = "ឈ្មោះ";
            this.mName.Name = "mName";
            // 
            // StatusID
            // 
            this.StatusID.DataPropertyName = "FamilyStatus";
            this.StatusID.HeaderText = "statusID";
            this.StatusID.Name = "StatusID";
            this.StatusID.Visible = false;
            // 
            // StationID
            // 
            this.StationID.DataPropertyName = "VoteStation";
            this.StationID.HeaderText = "voteStationID";
            this.StationID.Name = "StationID";
            this.StationID.Visible = false;
            // 
            // StationNoID
            // 
            this.StationNoID.DataPropertyName = "VoteStationNo";
            this.StationNoID.HeaderText = "voteStationNoID";
            this.StationNoID.Name = "StationNoID";
            this.StationNoID.Visible = false;
            // 
            // SexID
            // 
            this.SexID.DataPropertyName = "Sex";
            this.SexID.HeaderText = "SexID";
            this.SexID.Name = "SexID";
            this.SexID.Visible = false;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "SexName";
            this.Sex.HeaderText = "ភេទ";
            this.Sex.Name = "Sex";
            this.Sex.Width = 50;
            // 
            // Dob
            // 
            this.Dob.DataPropertyName = "Dob";
            dataGridViewCellStyle1.Format = "dd-MM-yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.Dob.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dob.HeaderText = "ថ្ងៃខែឆ្នាំកំណើត";
            this.Dob.Name = "Dob";
            // 
            // Age
            // 
            this.Age.HeaderText = "អាយុ";
            this.Age.Name = "Age";
            this.Age.Width = 50;
            // 
            // Job
            // 
            this.Job.DataPropertyName = "Job";
            this.Job.HeaderText = "មុខរបរ";
            this.Job.Name = "Job";
            // 
            // CardID
            // 
            this.CardID.DataPropertyName = "CardID";
            this.CardID.HeaderText = "មានប័ណ្ណសមាជិក";
            this.CardID.Name = "CardID";
            this.CardID.Width = 110;
            // 
            // CardIDNo
            // 
            this.CardIDNo.DataPropertyName = "CardIDNo";
            this.CardIDNo.HeaderText = "លេខកាតសមាជិក";
            this.CardIDNo.Name = "CardIDNo";
            this.CardIDNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CardIDNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CardIDNo.Width = 110;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "RoleName";
            this.Role.HeaderText = "តួនាទី";
            this.Role.Name = "Role";
            // 
            // SencusSeen
            // 
            this.SencusSeen.DataPropertyName = "SencusSeen";
            this.SencusSeen.HeaderText = "មានមុខ";
            this.SencusSeen.Name = "SencusSeen";
            this.SencusSeen.Width = 70;
            // 
            // Migration
            // 
            this.Migration.DataPropertyName = "Migration";
            this.Migration.HeaderText = "ចំណាកស្រុក";
            this.Migration.Name = "Migration";
            this.Migration.Width = 80;
            // 
            // MigrationID
            // 
            this.MigrationID.DataPropertyName = "MigrationID";
            this.MigrationID.HeaderText = "migrationID";
            this.MigrationID.Name = "MigrationID";
            this.MigrationID.Visible = false;
            // 
            // MigrationInOut
            // 
            this.MigrationInOut.DataPropertyName = "MigrationInOut";
            this.MigrationInOut.HeaderText = "ចំណាកក្នុងឬក្រៅស្រុក";
            this.MigrationInOut.Name = "MigrationInOut";
            this.MigrationInOut.Width = 130;
            // 
            // MigrationDetail
            // 
            this.MigrationDetail.DataPropertyName = "MigrationDetail";
            this.MigrationDetail.HeaderText = "ទីតាំងចំណាកស្រុក";
            this.MigrationDetail.Name = "MigrationDetail";
            this.MigrationDetail.Width = 110;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "ទីលំនៅ";
            this.Address.Name = "Address";
            // 
            // PeopleID
            // 
            this.PeopleID.DataPropertyName = "PeopleID";
            this.PeopleID.HeaderText = "មានអត្តសញ្ញាណប័ណ្ណ";
            this.PeopleID.Name = "PeopleID";
            this.PeopleID.Width = 130;
            // 
            // PeopleIDNo
            // 
            this.PeopleIDNo.DataPropertyName = "PeopleIDNo";
            this.PeopleIDNo.HeaderText = "លេខអត្តសញ្ញាណប័ណ្ណ";
            this.PeopleIDNo.Name = "PeopleIDNo";
            this.PeopleIDNo.Width = 135;
            // 
            // DateIn
            // 
            this.DateIn.DataPropertyName = "DateIn";
            this.DateIn.HeaderText = "ថ្ងៃចូលជាសមាជិក";
            this.DateIn.Name = "DateIn";
            this.DateIn.Width = 110;
            // 
            // VoteRegister
            // 
            this.VoteRegister.DataPropertyName = "VoteRegister";
            this.VoteRegister.HeaderText = "បានចុះឈ្មោះបោះឆ្នោត";
            this.VoteRegister.Name = "VoteRegister";
            this.VoteRegister.Width = 130;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "RoleID";
            this.RoleID.Name = "RoleID";
            this.RoleID.Visible = false;
            // 
            // PhotoPath
            // 
            this.PhotoPath.DataPropertyName = "PhotoPath";
            this.PhotoPath.HeaderText = "photoPath";
            this.PhotoPath.Name = "PhotoPath";
            this.PhotoPath.Visible = false;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "ផ្សេងៗ";
            this.Detail.Name = "Detail";
            // 
            // VoteStationName
            // 
            this.VoteStationName.DataPropertyName = "VoteStationName";
            this.VoteStationName.HeaderText = "មណ្ធលបោះឆ្នោត";
            this.VoteStationName.Name = "VoteStationName";
            this.VoteStationName.Width = 110;
            // 
            // VoteStationNoName
            // 
            this.VoteStationNoName.DataPropertyName = "VoteStationNoName";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.VoteStationNoName.DefaultCellStyle = dataGridViewCellStyle2;
            this.VoteStationNoName.HeaderText = "លេខមណ្ធល";
            this.VoteStationNoName.Name = "VoteStationNoName";
            this.VoteStationNoName.Width = 90;
            // 
            // StationNoName
            // 
            this.StationNoName.DataPropertyName = "StationNoName";
            this.StationNoName.HeaderText = "stationNoName";
            this.StationNoName.Name = "StationNoName";
            this.StationNoName.Visible = false;
            // 
            // FamilyStatusName
            // 
            this.FamilyStatusName.DataPropertyName = "FamilyStatusName";
            this.FamilyStatusName.HeaderText = "ស្ថានភាពគ្រួសារ";
            this.FamilyStatusName.Name = "FamilyStatusName";
            this.FamilyStatusName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FamilyStatusName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FamilyStatusName.Width = 110;
            // 
            // FormFamilyN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1107, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.dgvFamilyMember);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FormFamilyN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFamilyMember;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cboVillage;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFamilyBookNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGroupNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn mName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationNoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardIDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SencusSeen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Migration;
        private System.Windows.Forms.DataGridViewTextBoxColumn MigrationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MigrationInOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn MigrationDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PeopleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleIDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VoteRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoteStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoteStationNoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationNoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyStatusName;
    }
}