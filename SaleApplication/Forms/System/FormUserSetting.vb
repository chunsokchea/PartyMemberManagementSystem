Public Class FormUserSetting

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtDataGridViewAlternativeColor_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDataGridViewAlternativeColor.MouseClick
        Dim cd As New ColorDialog()
        cd.Color = Me.txtDataGridViewAlternativeColor.BackColor
        If (cd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Me.txtDataGridViewAlternativeColor.BackColor = cd.Color
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Settings.DataGridViewAlternativeColor = Me.txtDataGridViewAlternativeColor.BackColor
        My.Settings.DataGridViweRowHeight = Me.txtDataGridViewRowHeigt.Text
        My.Settings.DataGridViweFont = Me.txtDataGridViwFontName.Font
        My.Settings.Languguage = Me.cboLanguage.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub FormUserSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDataGridViewAlternativeColor.BackColor = My.Settings.DataGridViewAlternativeColor
        Me.txtDataGridViewRowHeigt.Text = My.Settings.DataGridViweRowHeight
        Me.txtDataGridViwFontName.Font = My.Settings.DataGridViweFont
        Me.cboLanguage.Text = My.Settings.Languguage 
    End Sub

    Private Sub txtDataGridViwFontName_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDataGridViwFontName.MouseClick
        Dim fd As New FontDialog()
        fd.Font = Me.txtDataGridViwFontName.Font
        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtDataGridViwFontName.Font = fd.Font
        End If
    End Sub
 
End Class