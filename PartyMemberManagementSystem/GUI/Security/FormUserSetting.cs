using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PartyMemberManagementSystem.Properties;

namespace PartyMemberManagementSystem.GUI.Security
{
    public partial class FormUserSetting : Form
    {
        public FormUserSetting()
        {
            InitializeComponent();
        }

        private void txtDataGridViewAlternativeColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = this.txtDataGridViewAlternativeColor.BackColor;
            if ((cd.ShowDialog() == DialogResult.OK))
            {
                this.txtDataGridViewAlternativeColor.BackColor = cd.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.DataGridViewAlternativeColor = this.txtDataGridViewAlternativeColor.BackColor;
            Settings.Default.DataGridViweRowHeight = Int32.Parse(txtDataGridViewRowHeigt.Text);
            Settings.Default.DataGridViweFont = this.txtDataGridViwFontName.Font;
            Settings.Default.Languguage = this.cboLanguage.Text;
            Settings.Default.Save();
            this.Close();
        }

        private void FormUserSetting_Load(object sender, EventArgs e)
        {
            txtDataGridViewAlternativeColor.BackColor = Settings.Default.DataGridViewAlternativeColor;
            txtDataGridViewRowHeigt.Text = Settings.Default.DataGridViweRowHeight.ToString();
            txtDataGridViwFontName.Font = Settings.Default.DataGridViweFont;
            cboLanguage.Text = Settings.Default.Languguage;
        }

        private void txtDataGridViwFontName_MouseClick(object sender, MouseEventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = this.txtDataGridViwFontName.Font;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.txtDataGridViwFontName.Font = fd.Font;
            }
        }
    }
}
