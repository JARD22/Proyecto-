Imports System.Text
Imports System.Security.Cryptography


Module validacion_encriptacion

    'Asignacion del minimo de aparicion de caracteres en la cadena de texto
    Public Function Validacion(ByVal pass As String, Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 1,
    Optional ByVal numNumbers As Integer = 1,
    Optional ByVal numSpecial As Integer = 1) As Boolean

        ' 
        'Reemplace [A-Z] con \ p {Lu}, para permitir letras mayúsculas en Unicode.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Especial es "ninguno de los anteriores"
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pass) < minLength Then Return False
        ' comparando el minimo de ocurrencias de los caracteres
        If upper.Matches(pass).Count < numUpper Then Return False
        If lower.Matches(pass).Count < numLower Then Return False
        If number.Matches(pass).Count < numNumbers Then Return False
        If special.Matches(pass).Count < numSpecial Then Return False



        'Pasando todos los filtros nos retorna un valor verdadero
        Return True




    End Function
    Public Function Validacion(ByVal usuario As String, ByVal pass As String) As Boolean
        If usuario = "" Or pass = "" Then

            Return False
        Else
            Return True

        End If

    End Function
    Public Function Encriptar(ByVal input As String) As String
        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") '

        Dim buffer() As Byte = Encoding.UTF8.GetBytes(input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte =
Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0,
        buffer.Length()))
    End Function



End Module
