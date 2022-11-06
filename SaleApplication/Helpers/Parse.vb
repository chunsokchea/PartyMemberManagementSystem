Module Parse

    Public Function ToDecimal(ByVal text As String) As Decimal
        Return Val(text.Replace(",", ""))
    End Function

    Public Function ToInt(ByVal text As String) As Int16
        Return Val(text.Replace(",", ""))
    End Function

End Module
