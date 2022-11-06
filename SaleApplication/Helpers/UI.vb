Imports System.Runtime.InteropServices

Module UI
    Public Sub FormatDataGrid(ByRef dgv As DataGridView)
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.ReadOnly = True
        dgv.RowHeadersVisible = False
        dgv.AllowUserToResizeRows = False
        dgv.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.DataGridViewAlternativeColor
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv.RowTemplate.Height = My.Settings.DataGridViweRowHeight
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.MultiSelect = False
        dgv.DefaultCellStyle.Font = My.Settings.DataGridViweFont
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Public Sub SetPlaceHolder(ByRef textbox As TextBox, Optional ByVal text As String = "ស្វែងរក")
        SendMessage(textbox.Handle, &H1501, 0, text)
    End Sub
End Module
