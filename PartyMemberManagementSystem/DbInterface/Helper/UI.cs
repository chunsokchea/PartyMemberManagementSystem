using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using PartyMemberManagementSystem.Properties;
public class UI
{
    public static void FormatDataGrid(DataGridView dgv)
    {
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.ReadOnly = true;
        dgv.RowHeadersVisible = false;
        dgv.AllowUserToResizeRows = false;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Settings.Default.DataGridViewAlternativeColor;
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dgv.RowTemplate.Height = Settings.Default.DataGridViweRowHeight;
        dgv.BackgroundColor = Color.WhiteSmoke;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.DefaultCellStyle.Font = Settings.Default.DataGridViweFont;
        dgv.MultiSelect = false;

        DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
        columnHeaderStyle.Font = new Font("Khmer OS Battambang", 11);
        //, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
    }

    //[DllImport("user32.dll", CharSet = CharSet.Auto)]
   // private static Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]
   //     string lParam);
    private const int EM_SETCUEBANNER = 0x1501;
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

    public static void SetPlaceHolder( TextBox textbox, string text = "Search")
    {
        SendMessage(textbox.Handle, EM_SETCUEBANNER, 0, text);
    }
}