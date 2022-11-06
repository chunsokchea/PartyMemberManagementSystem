Imports System.Text.RegularExpressions

Public Module Validator

    Friend Function IsDecimal(ByVal text As String) As Boolean
        Dim tmp As Decimal
        Dim canConvert = Decimal.TryParse(text, tmp)
        Return canConvert
    End Function

    Friend Function IsInteger(ByVal text As String) As Boolean
        Dim tmp As Int16
        Dim res = Int16.TryParse(text, tmp)
        Return res
    End Function

    Friend Function IsEmail(ByVal text As String) As Boolean
        Dim result = Regex.IsMatch(text, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")
        Return result
    End Function

    Friend Function IsWebAddress(ByVal text As String) As Boolean
        Dim result = Regex.IsMatch(text, "^(|https?:\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)$")
        Return result
    End Function

    Friend Function IsPhone(ByVal text As String) As Boolean
        Dim result = Regex.IsMatch(text, "^0[0-9]{2} [0-9]{3} [0-9]{3,4}$")
        Return result
    End Function
    '@"^[A-Za-z]+\d+.*$"
    Friend Function IsStrongPassword(ByVal text As String) As Boolean
        If (text.Trim() = "") Then Return False

        Dim result = Regex.IsMatch(text, "^[A-Za-z]+\d+.*$")
        Return result
    End Function
     
End Module
