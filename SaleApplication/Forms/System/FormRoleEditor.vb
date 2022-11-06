Public Class FormRoleEditor

    Public Sub LoadPermission() 
        Dim node = New TreeNode()
        node.Text = "System"
        node.Tag = 0
        node.ToolTipText = "System"
        node.Checked = False
        Me.TreeView1.Nodes.Add(node)
        LoadPermission(node)

        checking = True
        For Each childNode As TreeNode In node.Nodes
            If childNode.Checked Then
                node.Checked = True
                Exit For
            End If
        Next
        checking = False
    End Sub

    Public Sub LoadPermission(ByVal parentNode As TreeNode)
        Try
            cmd.Parameters("@RoleId") = Me.txtRoleId.Text
            cmd.Parameters("@ParentId") = parentNode.Tag

            Dim sql = "SELECT Active,PermissionName,PermissionId,Note FROM qrEditUserRole2 "
            Dim dt = cmd.ExecuteDataTable(sql)


            ''WHERE [ParentId]= @ParentId AND [RoleId]= @RoleId;" Active=ISNULL(rp.Active,0)

            'Dim dt = cmd.ExecuteDataTable("SELECT IIf(rp.Active Is Null,0,rp.Active) AS Active,p.PermissionName,p.PermissionId,p.Note FROM [system_Permission] p LEFT JOIN [system_RolePermission] rp ON (rp.PermissionId=p.PermissionId AND rp.RoleId=@RoleId AND rp.Active=true) WHERE p.Active=true AND ParentId=@ParentId")

            For Each row In dt.Rows
                Dim node = New TreeNode()
                node.Text = row("PermissionName")
                node.Tag = row("PermissionId")
                node.ToolTipText = row("Note")
                node.Checked = row("Active")
                parentNode.Nodes.Add(node)
                LoadPermission(node)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If Me.txtRoleName.Text.Trim() = "" Then
            MsgBox("Please input role name!")
            Me.txtRoleName.Focus()
            Exit Sub
        End If

        Cmd.Parameters("@RoleName") = Me.txtRoleName.Text
        Cmd.Parameters("@RoleId") = Me.txtRoleId.Text
        If txtRoleId.Enabled Then
            cmd.ExecuteNonQuery("INSERT INTO [system_Role] (RoleName,Active) VALUES(@RoleName,true)")
            Me.txtRoleId.Text = cmd.ExecuteScalar("SELECT MAX(RoleId) FROM [system_Role]")
        Else
            cmd.ExecuteNonQuery("UPDATE [system_Role] SET RoleName=@RoleName WHERE RoleId=@RoleId")
        End If

        For Each node As TreeNode In Me.TreeView1.Nodes
            SaveNode(node)
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub SaveNode(ByRef parentNode As TreeNode)

        For Each node As TreeNode In parentNode.Nodes
            cmd.Parameters("@RoleId") = Me.txtRoleId.Text
            cmd.Parameters("@PermissionId") = node.Tag
            'cmd.Parameters("@Active") = node.Checked
            Dim sqls = "SELECT COUNT(*) FROM [system_RolePermission] WHERE PermissionId=@PermissionId AND RoleId=@RoleId"
            Dim result = cmd.ExecuteScalar(sqls)
            'MessageBox.Show(result)
            cmd.Parameters("@RoleId") = Me.txtRoleId.Text
            cmd.Parameters("@PermissionId") = node.Tag
            cmd.Parameters("@Active") = node.Checked
            If result = 0 Then
                Dim sqlI = "INSERT INTO [system_RolePermission] (RoleId, PermissionId, [Active]) VALUES(@RoleId,@PermissionId,@Active);"
                cmd.ExecuteNonQuery(sqlI)
            Else
                Dim sqlU = "UPDATE [system_RolePermission] SET [Active]=@Active WHERE PermissionId=@PermissionId AND RoleId=@RoleId;"
                cmd.ExecuteNonQuery(sqlU)
            End If
            'cmd.ExecuteNonQuery("IF NOT EXISTS(SELECT * FROM [system_RolePermission] WHERE PermissionId=@PermissionId AND RoleId=@RoleId) INSERT INTO [system_RolePermission] VALUES(@RoleId,@PermissionId,@Active); ELSE  UPDATE [system_RolePermission] SET Active=@Active WHERE PermissionId=@PermissionId AND RoleId=@RoleId;")
            SaveNode(node)
        Next
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FormRoleEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPermission()
        'testData()
    End Sub

    Private Sub testData()
        cmd.Parameters("@ParentId") = 2
        cmd.Parameters("@RoleId") = 2
        Dim sql = "SELECT Active,PermissionName,PermissionId,Note FROM qrEditUserRole;"
        Dim dt As New DataTable
        dt = cmd.ExecuteDataTable(sql)
        DataGridView1.DataSource = dt
    End Sub


    Private checking As Boolean = False

    Private Sub tree_AfterCheck(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles TreeView1.AfterCheck
        If Not checking Then
            checking = True
            downwardApply(e.Node)
            upwardApply(e.Node)
            checking = False
        End If
    End Sub

    Private Sub downwardApply(ByVal node As TreeNode)
        For Each downNode As TreeNode In node.Nodes
            downNode.Checked = node.Checked
            ' apply it down recursively.
            downwardApply(downNode)
        Next
    End Sub

    Private Sub upwardApply(ByVal node As TreeNode)
        If node.Parent IsNot Nothing Then
            If node.Checked Then
                node.Parent.Checked = True
            Else
                Dim allNodesIsUnChecked As Boolean = True
                For Each relativeNode As TreeNode In node.Parent.Nodes
                    If relativeNode.Checked Then
                        allNodesIsUnChecked = False
                    End If
                Next
                If allNodesIsUnChecked Then
                    node.Parent.Checked = False
                End If
            End If

            ' apply it up recursively.
            upwardApply(node.Parent)
        End If
    End Sub
End Class