using SecurityP;
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
    public partial class FormStation : Form
    {
        public FormStation()
        {
            InitializeComponent();

            this.btnAdd.Enabled = App.IsAuthorized(Permissions.List_Member_add);
            this.btnUpdate.Enabled = App.IsAuthorized(Permissions.List_Member_Edit);
            this.btnDelete.Enabled = App.IsAuthorized(Permissions.List_Member_Delete);

            loadStation();
        }

        private void loadStation()
        {
            DataTable dts = new DataTable();
            string sql = "SELECT s.StationID, s.StationName,(SELECT COUNT(*) FROM tblStationNo n WHERE n.Active=true AND n.StationID=s.StationID)AS TotalSNo FROM tblVoteStation s WHERE s.Active=true";
            dts = Cmd.ExecuteDataTable(sql);
            dgvList.DataSource = dts;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormStationNE frm = new FormStationNE();
            //frm.ShowDialog();
            if (frm.ShowDialog()==DialogResult.OK)
            {
                //MessageBox.Show("REFRESH!!!");
                loadStation();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }

            FormStationNE frm = new FormStationNE();
            frm.newEdit = false;
            frm.sId = (int)row.Cells["StationID"].Value;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Edit!!!");
                loadStation();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            Cmd.Parameters["@sid"]=(int)row.Cells["StationID"].Value;
            Cmd.ExecuteNonQuery("UPDATE tblVoteStation SET Active=false WHERE StationID=@sid");
            Cmd.Parameters["@sid"] = (int)row.Cells["StationID"].Value;
            Cmd.ExecuteNonQuery("UPDATE tblStationNo SET Active=false WHERE StationID=@sid");

            MessageBox.Show("លុបទិន្នន័យបាណជោគជ័យ!");
            loadStation();
        }
    }
}
