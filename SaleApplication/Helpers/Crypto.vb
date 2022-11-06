Imports System.Text
Imports System.Security.Cryptography

''' <summary>
''' Crypto class written by RY RITH(092 644 208/ry.rith@gmail.com)
''' </summary>
''' <remarks>Feature MD5 hash, TripleDES key-based encryption</remarks>
Module Crypto

    Public Function PasswordHash(ByVal user As String, ByVal pwd As String)
        Return ComputeMD5Hash(user + pwd + "MyKey")
    End Function

    ' http://social.msdn.microsoft.com/Forums/en-US/ede9585a-f19d-43b2-b915-5fd0cd59236f/using-md5-in-vbnet
    Public Function ComputeMD5Hash(ByVal input As String) As String
        Dim m As MD5 = MD5.Create()
        Dim data As Byte() = m.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

 

    ' http://msdn.microsoft.com/en-us/library/ms172831.aspx
    Public Function Encrypt(ByVal plaintext As String, ByVal key As String)
        Dim TripleDes As New TripleDESCryptoServiceProvider
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)

        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream. 
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream. 
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string. 
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function Decrypt(ByVal encryptedtext As String, ByVal key As String)
        Dim TripleDes As New TripleDESCryptoServiceProvider
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)

        ' Convert the encrypted text string to a byte array. 
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream. 
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream. 
        Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string. 
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function

    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Dim sha1 As New SHA1CryptoServiceProvider
        ' Hash the key. 
        Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)
        ' Truncate or pad the hash. 
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

End Module
