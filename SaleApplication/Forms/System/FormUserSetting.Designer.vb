<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserSetting
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDataGridViewAlternativeColor = New System.Windows.Forms.TextBox()
        Me.txtDataGridViewRowHeigt = New System.Windows.Forms.TextBox()
        Me.txtDataGridViwFontName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data View"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alternative Row Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Row Height "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Font "
        '
        'txtDataGridViewAlternativeColor
        '
        Me.txtDataGridViewAlternativeColor.Location = New System.Drawing.Point(170, 66)
        Me.txtDataGridViewAlternativeColor.Name = "txtDataGridViewAlternativeColor"
        Me.txtDataGridViewAlternativeColor.Size = New System.Drawing.Size(176, 20)
        Me.txtDataGridViewAlternativeColor.TabIndex = 4
        '
        'txtDataGridViewRowHeigt
        '
        Me.txtDataGridViewRowHeigt.Location = New System.Drawing.Point(170, 93)
        Me.txtDataGridViewRowHeigt.Name = "txtDataGridViewRowHeigt"
        Me.txtDataGridViewRowHeigt.Size = New System.Drawing.Size(176, 20)
        Me.txtDataGridViewRowHeigt.TabIndex = 5
        '
        'txtDataGridViwFontName
        '
        Me.txtDataGridViwFontName.Location = New System.Drawing.Point(170, 119)
        Me.txtDataGridViwFontName.Name = "txtDataGridViwFontName"
        Me.txtDataGridViwFontName.Size = New System.Drawing.Size(176, 20)
        Me.txtDataGridViwFontName.TabIndex = 6
        Me.txtDataGridViwFontName.Text = "Sample Text"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save Setting"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Lanaguage"
        '
        'cboLanguage
        '
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Items.AddRange(New Object() {"en-US", "km-KH"})
        Me.cboLanguage.Location = New System.Drawing.Point(170, 145)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(176, 21)
        Me.cboLanguage.TabIndex = 12
        '
        'FormUserSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 228)
        Me.Controls.Add(Me.cboLanguage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDataGridViwFontName)
        Me.Controls.Add(Me.txtDataGridViewRowHeigt)
        Me.Controls.Add(Me.txtDataGridViewAlternativeColor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUserSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDataGridViewAlternativeColor As System.Windows.Forms.TextBox
    Friend WithEvents txtDataGridViewRowHeigt As System.Windows.Forms.TextBox
    Friend WithEvents txtDataGridViwFontName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboLanguage As System.Windows.Forms.ComboBox
End Class
