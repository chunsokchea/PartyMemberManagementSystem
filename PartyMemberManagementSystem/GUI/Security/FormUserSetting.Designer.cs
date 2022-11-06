namespace PartyMemberManagementSystem.GUI.Security
{
    partial class FormUserSetting
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
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDataGridViwFontName = new System.Windows.Forms.TextBox();
            this.txtDataGridViewRowHeigt = new System.Windows.Forms.TextBox();
            this.txtDataGridViewAlternativeColor = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboLanguage
            // 
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "en-US",
            "km-KH"});
            this.cboLanguage.Location = new System.Drawing.Point(176, 140);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(176, 21);
            this.cboLanguage.TabIndex = 22;
            this.cboLanguage.Visible = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(31, 146);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 13);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Lanaguage";
            this.Label5.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 27);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save Setting";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDataGridViwFontName
            // 
            this.txtDataGridViwFontName.Location = new System.Drawing.Point(176, 114);
            this.txtDataGridViwFontName.Name = "txtDataGridViwFontName";
            this.txtDataGridViwFontName.Size = new System.Drawing.Size(176, 20);
            this.txtDataGridViwFontName.TabIndex = 19;
            this.txtDataGridViwFontName.Text = "Sample Text / អក្សរសាកល្បង";
            this.txtDataGridViwFontName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDataGridViwFontName_MouseClick);
            // 
            // txtDataGridViewRowHeigt
            // 
            this.txtDataGridViewRowHeigt.Location = new System.Drawing.Point(176, 88);
            this.txtDataGridViewRowHeigt.Name = "txtDataGridViewRowHeigt";
            this.txtDataGridViewRowHeigt.Size = new System.Drawing.Size(176, 20);
            this.txtDataGridViewRowHeigt.TabIndex = 18;
            // 
            // txtDataGridViewAlternativeColor
            // 
            this.txtDataGridViewAlternativeColor.Location = new System.Drawing.Point(176, 61);
            this.txtDataGridViewAlternativeColor.Name = "txtDataGridViewAlternativeColor";
            this.txtDataGridViewAlternativeColor.Size = new System.Drawing.Size(176, 20);
            this.txtDataGridViewAlternativeColor.TabIndex = 17;
            this.txtDataGridViewAlternativeColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDataGridViewAlternativeColor_MouseClick);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(31, 117);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(31, 13);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Font ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(31, 91);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Row Height ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(31, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Alternative Row Color";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(31, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Data View";
            // 
            // FormUserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 228);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDataGridViwFontName);
            this.Controls.Add(this.txtDataGridViewRowHeigt);
            this.Controls.Add(this.txtDataGridViewAlternativeColor);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSetting";
            this.Load += new System.EventHandler(this.FormUserSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboLanguage;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtDataGridViwFontName;
        internal System.Windows.Forms.TextBox txtDataGridViewRowHeigt;
        internal System.Windows.Forms.TextBox txtDataGridViewAlternativeColor;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}