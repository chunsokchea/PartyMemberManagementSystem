namespace PartyMemberManagementSystem.GUI.Member
{
    partial class FormFamily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFamily));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGroup = new System.Windows.Forms.RadioButton();
            this.radioVillage = new System.Windows.Forms.RadioButton();
            this.radioFamilyNo = new System.Windows.Forms.RadioButton();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.villageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.women = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VillageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCondition = new System.Windows.Forms.ComboBox();
            this.cboall = new System.Windows.Forms.CheckBox();
            this.cboVillage = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOutOutNation = new System.Windows.Forms.Label();
            this.lblNoId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblOutInNation = new System.Windows.Forms.Label();
            this.lblhaveID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWoman = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VillageIDd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardIDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Village = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyBookNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeoPleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Migration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MigrationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(661, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 192);
            this.panel1.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGroup);
            this.groupBox1.Controls.Add(this.radioVillage);
            this.groupBox1.Controls.Add(this.radioFamilyNo);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(3, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 106);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ស្វែងរក";
            // 
            // radioGroup
            // 
            this.radioGroup.AutoSize = true;
            this.radioGroup.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup.Location = new System.Drawing.Point(72, 25);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(47, 26);
            this.radioGroup.TabIndex = 13;
            this.radioGroup.Text = "ក្រុម";
            this.radioGroup.UseVisualStyleBackColor = true;
            // 
            // radioVillage
            // 
            this.radioVillage.AutoSize = true;
            this.radioVillage.Checked = true;
            this.radioVillage.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVillage.Location = new System.Drawing.Point(15, 25);
            this.radioVillage.Name = "radioVillage";
            this.radioVillage.Size = new System.Drawing.Size(44, 26);
            this.radioVillage.TabIndex = 12;
            this.radioVillage.TabStop = true;
            this.radioVillage.Text = "ភូមិ";
            this.radioVillage.UseVisualStyleBackColor = true;
            // 
            // radioFamilyNo
            // 
            this.radioFamilyNo.AutoSize = true;
            this.radioFamilyNo.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFamilyNo.Location = new System.Drawing.Point(125, 25);
            this.radioFamilyNo.Name = "radioFamilyNo";
            this.radioFamilyNo.Size = new System.Drawing.Size(136, 26);
            this.radioFamilyNo.TabIndex = 11;
            this.radioFamilyNo.Text = "លេខសៀវភៅគ្រួសារបក្ស";
            this.radioFamilyNo.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Khmer OS Bokor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(15, 59);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(323, 33);
            this.txtsearch.TabIndex = 10;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Muol Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(68, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "បញ្ជីឈ្មោះគ្រួសារបក្ស";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.villageName,
            this.amount,
            this.women,
            this.VillageID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(375, 123);
            this.dataGridView1.TabIndex = 42;
            // 
            // villageName
            // 
            this.villageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.villageName.DataPropertyName = "VillageName";
            this.villageName.HeaderText = "ភូមិ";
            this.villageName.Name = "villageName";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "TotalM";
            this.amount.HeaderText = "ចំនួនគ្រួសារ";
            this.amount.Name = "amount";
            this.amount.Width = 80;
            // 
            // women
            // 
            this.women.DataPropertyName = "Woman";
            this.women.HeaderText = "ស្រី";
            this.women.Name = "women";
            this.women.Visible = false;
            this.women.Width = 50;
            // 
            // VillageID
            // 
            this.VillageID.DataPropertyName = "VillageID";
            this.VillageID.HeaderText = "VillageID";
            this.VillageID.Name = "VillageID";
            this.VillageID.Visible = false;
            this.VillageID.Width = 50;
            // 
            // cboCondition
            // 
            this.cboCondition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCondition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondition.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCondition.FormattingEnabled = true;
            this.cboCondition.Items.AddRange(new object[] {
            "មានអត្តសញ្ញាណប័ណ្ណ",
            "គ្មានអត្តសញ្ញាណប័ណ្ណ",
            "ចំណាកស្រុកក្នុងប្រទេស",
            "ចំណាកស្រុកក្រៅប្រទេស"});
            this.cboCondition.Location = new System.Drawing.Point(222, 238);
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(168, 30);
            this.cboCondition.TabIndex = 41;
            this.cboCondition.Visible = false;
            this.cboCondition.SelectedIndexChanged += new System.EventHandler(this.cboCondition_SelectedIndexChanged);
            // 
            // cboall
            // 
            this.cboall.AutoSize = true;
            this.cboall.Checked = true;
            this.cboall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboall.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboall.ForeColor = System.Drawing.Color.DarkBlue;
            this.cboall.Location = new System.Drawing.Point(15, 240);
            this.cboall.Name = "cboall";
            this.cboall.Size = new System.Drawing.Size(69, 26);
            this.cboall.TabIndex = 40;
            this.cboall.Text = "ទាំងអស់";
            this.cboall.UseVisualStyleBackColor = true;
            this.cboall.Visible = false;
            this.cboall.CheckedChanged += new System.EventHandler(this.cboall_CheckedChanged);
            // 
            // cboVillage
            // 
            this.cboVillage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVillage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVillage.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVillage.FormattingEnabled = true;
            this.cboVillage.Location = new System.Drawing.Point(94, 238);
            this.cboVillage.Name = "cboVillage";
            this.cboVillage.Size = new System.Drawing.Size(122, 30);
            this.cboVillage.TabIndex = 39;
            this.cboVillage.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.Location = new System.Drawing.Point(947, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "លុបចេញ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.Location = new System.Drawing.Point(866, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "កែប្រែ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.Location = new System.Drawing.Point(785, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = " បន្ថែមថ្មី";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOutOutNation);
            this.groupBox2.Controls.Add(this.lblNoId);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblOutInNation);
            this.groupBox2.Controls.Add(this.lblhaveID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblWoman);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 97);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // lblOutOutNation
            // 
            this.lblOutOutNation.AutoSize = true;
            this.lblOutOutNation.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOutNation.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOutOutNation.Location = new System.Drawing.Point(315, 43);
            this.lblOutOutNation.Name = "lblOutOutNation";
            this.lblOutOutNation.Size = new System.Drawing.Size(39, 22);
            this.lblOutOutNation.TabIndex = 45;
            this.lblOutOutNation.Text = "...នាក់";
            this.lblOutOutNation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNoId
            // 
            this.lblNoId.AutoSize = true;
            this.lblNoId.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoId.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNoId.Location = new System.Drawing.Point(126, 43);
            this.lblNoId.Name = "lblNoId";
            this.lblNoId.Size = new System.Drawing.Size(39, 22);
            this.lblNoId.TabIndex = 44;
            this.lblNoId.Text = "...នាក់";
            this.lblNoId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(176, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 22);
            this.label12.TabIndex = 43;
            this.label12.Text = "ចំណាកស្រុក ក្រៅប្រទេស";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 22);
            this.label13.TabIndex = 42;
            this.label13.Text = "គ្មានអត្តសញ្ញាណប័ណ្ណ";
            // 
            // lblOutInNation
            // 
            this.lblOutInNation.AutoSize = true;
            this.lblOutInNation.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutInNation.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOutInNation.Location = new System.Drawing.Point(315, 21);
            this.lblOutInNation.Name = "lblOutInNation";
            this.lblOutInNation.Size = new System.Drawing.Size(39, 22);
            this.lblOutInNation.TabIndex = 41;
            this.lblOutInNation.Text = "...នាក់";
            this.lblOutInNation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblhaveID
            // 
            this.lblhaveID.AutoSize = true;
            this.lblhaveID.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhaveID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblhaveID.Location = new System.Drawing.Point(126, 21);
            this.lblhaveID.Name = "lblhaveID";
            this.lblhaveID.Size = new System.Drawing.Size(39, 22);
            this.lblhaveID.TabIndex = 40;
            this.lblhaveID.Text = "...នាក់";
            this.lblhaveID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(176, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "ចំណាកស្រុក ក្នុងប្រទេស";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 38;
            this.label9.Text = "មានអត្តសញ្ញាណប័ណ្ណ";
            // 
            // lblWoman
            // 
            this.lblWoman.AutoSize = true;
            this.lblWoman.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoman.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWoman.Location = new System.Drawing.Point(315, 65);
            this.lblWoman.Name = "lblWoman";
            this.lblWoman.Size = new System.Drawing.Size(39, 22);
            this.lblWoman.TabIndex = 37;
            this.lblWoman.Text = "...នាក់";
            this.lblWoman.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotal.Location = new System.Drawing.Point(126, 65);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 22);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "...នាក់";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(176, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "ស្រី";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "ចំនួនសមាជិកសរុប";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberName,
            this.FamilyID,
            this.VillageIDd,
            this.Sex,
            this.DOB,
            this.Age,
            this.roleName,
            this.RoleID,
            this.CardID,
            this.CardIDNo,
            this.MemberId,
            this.Active,
            this.Village,
            this.GroupNo,
            this.FamilyBookNo,
            this.Detail,
            this.PeoPleID,
            this.Migration,
            this.MigrationID,
            this.FamilyStatus,
            this.FActive});
            this.dgvList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvList.Location = new System.Drawing.Point(14, 278);
            this.dgvList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1009, 299);
            this.dgvList.TabIndex = 35;
            this.dgvList.DoubleClick += new System.EventHandler(this.dgvList_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // MemberName
            // 
            this.MemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberName.DataPropertyName = "Name";
            this.MemberName.HeaderText = "ឈ្មោះ";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            this.MemberName.Visible = false;
            // 
            // FamilyID
            // 
            this.FamilyID.DataPropertyName = "FamilyID";
            this.FamilyID.HeaderText = "familyID";
            this.FamilyID.Name = "FamilyID";
            this.FamilyID.ReadOnly = true;
            this.FamilyID.Visible = false;
            // 
            // VillageIDd
            // 
            this.VillageIDd.DataPropertyName = "VillageID";
            this.VillageIDd.HeaderText = "VillageID";
            this.VillageIDd.Name = "VillageIDd";
            this.VillageIDd.ReadOnly = true;
            this.VillageIDd.Visible = false;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "SexName";
            this.Sex.HeaderText = "ភេទ";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Visible = false;
            this.Sex.Width = 50;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "Dob";
            dataGridViewCellStyle2.Format = "dd-MM-yyy";
            dataGridViewCellStyle2.NullValue = null;
            this.DOB.DefaultCellStyle = dataGridViewCellStyle2;
            this.DOB.HeaderText = "ថ្ងៃខែឆ្នាំកំណើត";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Visible = false;
            this.DOB.Width = 150;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "អាយុ";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Visible = false;
            this.Age.Width = 50;
            // 
            // roleName
            // 
            this.roleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleName.DataPropertyName = "RoleName";
            this.roleName.HeaderText = "តួនាទី";
            this.roleName.Name = "roleName";
            this.roleName.ReadOnly = true;
            this.roleName.Visible = false;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleId";
            this.RoleID.HeaderText = "roleID";
            this.RoleID.Name = "RoleID";
            this.RoleID.ReadOnly = true;
            this.RoleID.Visible = false;
            // 
            // CardID
            // 
            this.CardID.DataPropertyName = "CardID";
            this.CardID.HeaderText = "មានប័ណ្ណសមាជីក";
            this.CardID.Name = "CardID";
            this.CardID.ReadOnly = true;
            this.CardID.Visible = false;
            this.CardID.Width = 110;
            // 
            // CardIDNo
            // 
            this.CardIDNo.DataPropertyName = "CardIDNo";
            this.CardIDNo.HeaderText = "លេខប័ណ្ណសមាជីក";
            this.CardIDNo.Name = "CardIDNo";
            this.CardIDNo.ReadOnly = true;
            this.CardIDNo.Visible = false;
            this.CardIDNo.Width = 110;
            // 
            // MemberId
            // 
            this.MemberId.DataPropertyName = "ID";
            this.MemberId.HeaderText = "MemberId";
            this.MemberId.Name = "MemberId";
            this.MemberId.ReadOnly = true;
            this.MemberId.Visible = false;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Visible = false;
            // 
            // Village
            // 
            this.Village.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Village.DataPropertyName = "VillageName";
            this.Village.HeaderText = "ភូមិ";
            this.Village.Name = "Village";
            this.Village.ReadOnly = true;
            // 
            // GroupNo
            // 
            this.GroupNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GroupNo.DataPropertyName = "GroupNo";
            this.GroupNo.HeaderText = "ក្រុមបក្សទី";
            this.GroupNo.Name = "GroupNo";
            this.GroupNo.ReadOnly = true;
            // 
            // FamilyBookNo
            // 
            this.FamilyBookNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FamilyBookNo.DataPropertyName = "FamilyBookNo";
            this.FamilyBookNo.HeaderText = "សៀវភៅគ្រួសារលេខ";
            this.FamilyBookNo.Name = "FamilyBookNo";
            this.FamilyBookNo.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detail.DataPropertyName = "Address";
            this.Detail.HeaderText = "អាសយដ្ឋាន";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // PeoPleID
            // 
            this.PeoPleID.DataPropertyName = "PeopleID";
            this.PeoPleID.HeaderText = "PeopleID";
            this.PeoPleID.Name = "PeoPleID";
            this.PeoPleID.ReadOnly = true;
            this.PeoPleID.Visible = false;
            // 
            // Migration
            // 
            this.Migration.DataPropertyName = "Migration";
            this.Migration.HeaderText = "Migration";
            this.Migration.Name = "Migration";
            this.Migration.ReadOnly = true;
            this.Migration.Visible = false;
            // 
            // MigrationID
            // 
            this.MigrationID.DataPropertyName = "MigrationID";
            this.MigrationID.HeaderText = "MigrationID";
            this.MigrationID.Name = "MigrationID";
            this.MigrationID.ReadOnly = true;
            this.MigrationID.Visible = false;
            // 
            // FamilyStatus
            // 
            this.FamilyStatus.DataPropertyName = "StatusName";
            this.FamilyStatus.HeaderText = "ស្ថានភាពគ្រួសារ";
            this.FamilyStatus.Name = "FamilyStatus";
            this.FamilyStatus.ReadOnly = true;
            this.FamilyStatus.Visible = false;
            // 
            // FActive
            // 
            this.FActive.DataPropertyName = "fActive";
            this.FActive.HeaderText = "fActive";
            this.FActive.Name = "FActive";
            this.FActive.ReadOnly = true;
            this.FActive.Visible = false;
            // 
            // FormFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboCondition);
            this.Controls.Add(this.cboall);
            this.Controls.Add(this.cboVillage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvList);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormFamily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioGroup;
        private System.Windows.Forms.RadioButton radioVillage;
        private System.Windows.Forms.RadioButton radioFamilyNo;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboCondition;
        private System.Windows.Forms.CheckBox cboall;
        private System.Windows.Forms.ComboBox cboVillage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOutOutNation;
        private System.Windows.Forms.Label lblNoId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblOutInNation;
        private System.Windows.Forms.Label lblhaveID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWoman;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn villageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn women;
        private System.Windows.Forms.DataGridViewTextBoxColumn VillageID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VillageIDd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardIDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn Village;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyBookNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeoPleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Migration;
        private System.Windows.Forms.DataGridViewTextBoxColumn MigrationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FActive;
    }
}