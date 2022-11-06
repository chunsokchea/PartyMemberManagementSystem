Module Generator

    Public Function GenerateNewPurchaseNo() As String

        Dim obj As Object = Cmd.ExecuteScalar("SELECT MAX(PurchaseNo) FROM Purchase;")
         
        Dim lastNo As String
        If obj Is DBNull.Value Then
            lastNo = "PUC-0000000"
        Else
            lastNo = obj.ToString()
        End If

        ' PUC-000031
        lastNo = lastNo.Replace("PUC-", "")
        ' 000031
        Dim nextNo As Int16 = Convert.ToInt16(lastNo) + 1
        ' 32
        Dim result = "PUC-" & nextNo.ToString("000000")
        Return result

    End Function

    Public Function GenerateNewInvoiceNo() As String

        Dim obj As Object = Cmd.ExecuteScalar("SELECT MAX(InvoiceNo) FROM Invoice;")

        Dim lastNo As String
        If obj Is DBNull.Value Then
            lastNo = "INV-0000000"
        Else
            lastNo = obj.ToString()
        End If

        ' PUC-000031
        lastNo = lastNo.Replace("INV-", "")
        ' 000031
        Dim nextNo As Int16 = Convert.ToInt16(lastNo) + 1
        ' 32
        Dim result = "INV-" & nextNo.ToString("000000")
        Return result

    End Function

    Public Function GenerateNewTransferNo() As String

        Dim obj As Object = Cmd.ExecuteScalar("SELECT MAX(TransferNo) FROM Transfer;")

        Dim lastNo As String
        If obj Is DBNull.Value Then
            lastNo = "TNS-0000000"
        Else
            lastNo = obj.ToString()
        End If

        ' PUC-000031
        lastNo = lastNo.Replace("TNS-", "")
        ' 000031
        Dim nextNo As Int16 = Convert.ToInt16(lastNo) + 1
        ' 32
        Dim result = "TNS-" & nextNo.ToString("000000")
        Return result

    End Function

End Module
