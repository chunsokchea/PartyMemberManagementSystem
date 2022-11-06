'By: CHUN SOKCHEA
'Student of Build Bright University
'Mail: chunsokchea@gmail.com
'Phone: 087 397 317
Public Module myCustomeDate
    Private Function numbertokh(ByVal IntNum As String) As String
        Dim list = {{"0", "០"}, {"1", "១"}, {"2", "២"}, {"3", "៣"}, {"4", "៤"}, {"5", "៥"}, {"6", "៦"}, {"7", "៧"}, {"8", "៨"}, {"9", "៩"}, {".", ","}, {" ", " "}}
        Dim num As New ArrayList
        Dim ByteCount As Integer
        Dim SplitChar As String
        For ByteCount = 1 To Len(CStr(IntNum))
            Try
                SplitChar = Mid(CStr(IntNum.Trim), ByteCount, 1)
                num.Add(list(SplitChar, 1))
            Catch ex As Exception

            End Try

        Next
        'For i = 1 To list.Length
        '    SplitChar = Mid(CStr(IntNum.Trim), i, 1).ToString
        '    num.Add(list(SplitChar, 1))
        'Next

        Dim result As String = ""
        For i = 0 To num.Count - 1
            result += num(i)
        Next
        Return result
    End Function

    Private Function convertday(ByVal ti As String)
        If UCase(ti) = "MON" Then
            Return "ច័ន្ទ"
        ElseIf UCase(ti) = "TUE" Then
            Return "អង្គារ"
        ElseIf UCase(ti) = "WED" Then
            Return "ពុធ"
        ElseIf UCase(ti) = "THU" Then
            Return "ព្រហស្បតិ៍"
        ElseIf UCase(ti) = "FRI" Then
            Return "សុក្រ"
        ElseIf UCase(ti) = "SAT" Then
            Return "សៅរ៍"
        ElseIf UCase(ti) = "SUN" Then
            Return "អាទិត្យ"
        End If
    End Function

    Private Function convertmonth(ByVal ti As Integer)
        If ti = 1 Then
            Return "មករា"
        ElseIf ti = 2 Then
            Return "កុម្ភៈ"
        ElseIf ti = 3 Then
            Return "មិនា"
        ElseIf ti = 4 Then
            Return "មេសា"
        ElseIf ti = 5 Then
            Return "ឧសភា"
        ElseIf ti = 6 Then
            Return "មិថុនា"
        ElseIf ti = 7 Then
            Return "កក្កដា"
        ElseIf ti = 8 Then
            Return "សីសា"
        ElseIf ti = 9 Then
            Return "កញ្ញា"
        ElseIf ti = 10 Then
            Return "តុលា"
        ElseIf ti = 11 Then
            Return "វិច្ឆិការ"
        ElseIf ti = 12 Then
            Return "ធ្នូរ"
        End If
    End Function
    Public Function khmertime(ByVal text As Object)
        text.Text = ("ថ្ងៃ " & convertday(Now.Date.ToString("ddd")) & " ទី " & numbertokh(Now.Date.ToString("dd")) & " ខែ​ " & convertmonth(Now.Date.ToString("MM")) & " ឆ្នាំ " & numbertokh(Now.Date.ToString("yyyy")) & " ម៉ោង " & numbertokh(TimeOfDay.ToString("hh")) & ":" & numbertokh(TimeOfDay.ToString("mm")) & ":" & numbertokh(TimeOfDay.ToString("ss")) & IIf(TimeOfDay.ToString("tt") = "PM", " ល្ងាច", " ព្រឹក"))
        Return text
    End Function
    Friend Function datimepikerkhmer(ByVal text As Object, ByVal dt As DateTimePicker)
        text.Text = convertday(dt.Value.ToString("ddd")) & ",  " & numbertokh(dt.Value.ToString("dd")) & ",  " & convertmonth(dt.Value.ToString("MM")) & ",  " & numbertokh(dt.Value.ToString("yyyy"))
        Return text
    End Function
End Module
