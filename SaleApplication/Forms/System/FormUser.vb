Imports System.Data.SqlClient 


Public Class FormUser

    Private Sub FormCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnAdd.Enabled = App.IsAuthorized(Permissions.Security_User_Add)
        Me.btnEdit.Enabled = App.IsAuthorized(Permissions.Security_User_Edit)
        Me.btnDelete.Enabled = App.IsAuthorized(Permissions.Security_User_Delete)

        UI.SetPlaceHolder(Me.txtSearch)
        UI.FormatDataGrid(Me.dgv)
        LoadData()
    End Sub

    Private Sub LoadData()
        Cmd.Parameters("@S") = "%" & txtSearch.Text & "%"
        Me.dgv.DataSource = cmd.ExecuteDataTable("SELECT * FROM [system_User] WHERE ([UserName] & [FullName]) LIKE @S AND Active=true;")
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        LoadData()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If Me.dgv.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        If MessageBox.Show("Are you sure want to delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim row = dgv.SelectedRows(0)
        Dim id = row.Cells(0).Value

        Cmd.Parameters("@Id") = id
        cmd.ExecuteNonQuery("UPDATE [system_User] SET [Active]=false WHERE UserId=@Id")

        LoadData()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New FormUserEditor()
        frm.LoadRoleByUser(0)
        If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            LoadData()
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If Me.dgv.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim row = dgv.SelectedRows(0)

        Dim frm As New FormUserEditor()
        frm.txtUserName.Enabled = False
         
        frm.txtUserId.Text = row.Cells("UserId").Value
        frm.txtUserName.Text = row.Cells("UserName").Value
        frm.txtFullName.Text = row.Cells("FullName").Value
        frm.txtEmail.Text = row.Cells("Email").Value
        frm.txtPassword.Text = frm.PasswordMashText
        frm.chkLocked.Checked = row.Cells("Locked").Value
        frm.chkChangePasswordAtLogon.Checked = row.Cells("ChangePasswordAtLogOn").Value
        frm.LoadRoleByUser(row.Cells("UserId").Value) 
        If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            LoadData()
        End If 
    End Sub
End Class