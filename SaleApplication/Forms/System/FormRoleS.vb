Public Class FormRoleS
    Private Sub FormRole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnAdd.Enabled = App.IsAuthorized(Permissions.Security_Role_Add)
        Me.btnEdit.Enabled = App.IsAuthorized(Permissions.Security_Role_Edit)
        Me.btnDelete.Enabled = App.IsAuthorized(Permissions.Security_Role_Delete)

        UI.SetPlaceHolder(Me.txtSearch)
        UI.FormatDataGrid(dgv)
        LoadData()
    End Sub

    Public Sub LoadData()
        Cmd.Parameters("@S") = "%" & Me.txtSearch.Text & "%"
        Me.dgv.DataSource = cmd.ExecuteDataTable("SELECT * FROM [system_Role] WHERE UCase(RoleName) LIKE UCase(@S) AND Active=true")
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        LoadData()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New FormRoleEditor()
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadData()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Me.dgv.SelectedRows.Count = 0 Then
            Exit Sub
        End If


        Dim row As DataGridViewRow = Me.dgv.SelectedRows(0)
        Dim id = row.Cells("RoleId").Value

        Cmd.Parameters("@Id") = id
        Dim count = cmd.ExecuteScalar("SELECT COUNT(*) FROM [system_UserRole] WHERE RoleId=@Id AND Active=true")

        If count > 0 Then
            MsgBox("Role is already in used")
            Exit Sub
        End If

        If MessageBox.Show("តើលោកអ្នកចង់លុបប្រភេទនៃក្រុមមួយនេះមែនទេ?", "លុបប្រភេទនៃក្រុម", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Cmd.Parameters("@Id") = id
        cmd.ExecuteNonQuery("UPDATE [system_Role] SET Active=false WHERE RoleId=@Id")

        LoadData()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Me.dgv.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgv.SelectedRows(0)
        Dim RoleId = row.Cells("RoleId").Value
        Dim RoleName = row.Cells("RoleName").Value

        Dim frm As New FormRoleEditor()
        frm.txtRoleId.Enabled = False
        frm.txtRoleId.Text = RoleId
        frm.txtRoleName.Text = RoleName

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadData()
        End If
    End Sub
End Class