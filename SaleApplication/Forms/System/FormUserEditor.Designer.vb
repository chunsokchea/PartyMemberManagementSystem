<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtFullName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtUserId = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkLocked = New System.Windows.Forms.CheckBox
        Me.chkChangePasswordAtLogon = New System.Windows.Forms.CheckBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Active = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.RoleId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RoleName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ឈ្មោះអ្នកប្រើប្រាស់"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(108, 15)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(216, 27)
        Me.txtUserName.TabIndex = 1
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(108, 48)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(216, 27)
        Me.txtFullName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ឈ្មោះពេញ"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(108, 81)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(216, 27)
        Me.txtEmail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "អ៊ីមែល"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(264, 273)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 28)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "យល់ព្រម"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(345, 273)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "បោះបង់"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(199, 274)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(59, 27)
        Me.txtUserId.TabIndex = 8
        Me.txtUserId.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(108, 114)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(216, 27)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "លេខសំងាត់"
        '
        'chkLocked
        '
        Me.chkLocked.AutoSize = True
        Me.chkLocked.Location = New System.Drawing.Point(108, 174)
        Me.chkLocked.Name = "chkLocked"
        Me.chkLocked.Size = New System.Drawing.Size(92, 23)
        Me.chkLocked.TabIndex = 11
        Me.chkLocked.Text = "ផ្អាកប្រើប្រាស់"
        Me.chkLocked.UseVisualStyleBackColor = True
        '
        'chkChangePasswordAtLogon
        '
        Me.chkChangePasswordAtLogon.AutoSize = True
        Me.chkChangePasswordAtLogon.Checked = True
        Me.chkChangePasswordAtLogon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChangePasswordAtLogon.Location = New System.Drawing.Point(108, 147)
        Me.chkChangePasswordAtLogon.Name = "chkChangePasswordAtLogon"
        Me.chkChangePasswordAtLogon.Size = New System.Drawing.Size(184, 23)
        Me.chkChangePasswordAtLogon.TabIndex = 12
        Me.chkChangePasswordAtLogon.Text = "ប្តូរលេខសំងាត់ពេលចូលប្រើប្រាស់"
        Me.chkChangePasswordAtLogon.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 265)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtUserName)
        Me.TabPage1.Controls.Add(Me.chkChangePasswordAtLogon)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.chkLocked)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtFullName)
        Me.TabPage1.Controls.Add(Me.txtPassword)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 233)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ព័តមានទូទៅ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 233)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "តួនាទី"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ColumnHeadersVisible = False
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Active, Me.RoleId, Me.RoleName})
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(403, 227)
        Me.dgv.TabIndex = 0
        '
        'Active
        '
        Me.Active.DataPropertyName = "Active"
        Me.Active.HeaderText = "Active"
        Me.Active.Name = "Active"
        Me.Active.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Active.Width = 50
        '
        'RoleId
        '
        Me.RoleId.DataPropertyName = "RoleId"
        Me.RoleId.HeaderText = "RoleId"
        Me.RoleId.Name = "RoleId"
        Me.RoleId.Visible = False
        '
        'RoleName
        '
        Me.RoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoleName.DataPropertyName = "RoleName"
        Me.RoleName.HeaderText = "RoleName"
        Me.RoleName.Name = "RoleName"
        '
        'FormUserEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 311)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Font = New System.Drawing.Font("Khmer OS System", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormUserEditor"
        Me.Text = "អ្នកប្រើប្រាស់"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkLocked As System.Windows.Forms.CheckBox
    Friend WithEvents chkChangePasswordAtLogon As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Active As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RoleId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoleName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
