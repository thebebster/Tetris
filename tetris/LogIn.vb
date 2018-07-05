Public Class LogIn

    Private Function encrypt(Text As String) As String

        Dim numbers(15) As Integer
        numbers(0) = 4
        numbers(1) = 25
        numbers(2) = 13
        numbers(3) = 11
        numbers(4) = 21
        numbers(5) = 24
        numbers(6) = 7
        numbers(7) = 14
        numbers(8) = 17
        numbers(9) = 18
        numbers(10) = 20
        numbers(11) = 24
        numbers(12) = 9
        numbers(13) = 3
        numbers(14) = 11

        Dim key(15, 4) As Integer
        Dim thebits As String
        For i = 0 To 14
            thebits = ToBinary(numbers(i))
            While thebits.Length < 5
                thebits = 0 & thebits
            End While
            For j = 0 To 4
                key(i, j) = Convert.ToInt16(thebits.Substring(j, 1))
            Next
        Next

        Dim textnumbers(15, 4) As Integer
        For x As Integer = 0 To 14
            thebits = ToBinary(ToNumber(Text.Substring(x, 1)))
            While thebits.Length < 5
                thebits = 0 & thebits
            End While
            For j = 0 To 4
                textnumbers(x, j) = Convert.ToInt16(thebits.Substring(j, 1))
            Next
        Next

        Dim newbits(15, 4) As Integer
        For z = 0 To 14
            For c = 0 To 4
                newbits(z, c) = Str(0 - (Convert.ToBoolean(textnumbers(z, c)) Xor Convert.ToBoolean(key(z, c))))
            Next
        Next

        Dim newstring As String = ""
        Dim letter As String = ""
        For v = 0 To 14
            letter = ""
            For b = 0 To 4
                letter = letter & newbits(v, b)
            Next
            newstring = newstring & toletter(todec(letter))
        Next

        Return newstring

    End Function

    Private Function todec(text As String) As Integer
        Dim I As Integer = Convert.ToInt32(text, 2)
        I = I Mod 32
        Return I
    End Function

    Private Function toletter(x As Integer) As String
        Select Case x
            Case 0
                Return "#"
            Case 1
                Return "n"
            Case 2
                Return "j"
            Case 3
                Return "g"
            Case 4
                Return "r"
            Case 5
                Return "e"
            Case 6
                Return "k"
            Case 7
                Return "f"
            Case 8
                Return "h"
            Case 9
                Return "x"
            Case 10
                Return "b"
            Case 11
                Return "c"
            Case 12
                Return "z"
            Case 13
                Return "m"
            Case 14
                Return "a"
            Case 15
                Return "p"
            Case 16
                Return "o"
            Case 17
                Return "q"
            Case 18
                Return "d"
            Case 19
                Return "w"
            Case 20
                Return "t"
            Case 21
                Return "y"
            Case 22
                Return "v"
            Case 23
                Return "s"
            Case 24
                Return "i"
            Case 25
                Return "u"
            Case 26
                Return "l"
            Case 27
                Return "/"
            Case 28
                Return "_"
            Case 29
                Return "-"
            Case 30
                Return ","
            Case 31
                Return "."
        End Select
    End Function

    Private Function ToNumber(x As String) As Integer
        Dim y As String = x.ToLower
        Select Case y
            Case "#"
                Return 0
            Case "n"
                Return 1
            Case "j"
                Return 2
            Case "g"
                Return 3
            Case "r"
                Return 4
            Case "e"
                Return 5
            Case "k"
                Return 6
            Case "f"
                Return 7
            Case "h"
                Return 8
            Case "x"
                Return 9
            Case "b"
                Return 10
            Case "c"
                Return 11
            Case "z"
                Return 12
            Case "m"
                Return 13
            Case "a"
                Return 14
            Case "p"
                Return 15
            Case "o"
                Return 16
            Case "q"
                Return 17
            Case "d"
                Return 18
            Case "w"
                Return 19
            Case "t"
                Return 20
            Case "y"
                Return 21
            Case "v"
                Return 22
            Case "s"
                Return 23
            Case "i"
                Return 24
            Case "u"
                Return 25
            Case "l"
                Return 26
            Case "/"
                Return 27
            Case "_"
                Return 28
            Case "-"
                Return 29
            Case ","
                Return 30
            Case "."
                Return 31
        End Select
    End Function

    Private Function ToBinary(dec As Integer) As String
        Dim bin As Integer
        Dim output As String = ""
        While dec <> 0
            If dec Mod 2 = 0 Then
                bin = 0
            Else
                bin = 1
            End If
            dec = dec \ 2
            output = Convert.ToString(bin) & output
        End While
        If output Is Nothing Then
            Return "0"
        Else
            Return output
        End If
    End Function


    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim username As String = tbxUsername.Text
        Dim password As String = tbxPassword.Text
        While password.Length < 15
            password = password & "#"
        End While
        While username.Length < 15
            username = username & "#"
        End While
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("logins.txt")
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters("|")
        Dim currentRow As String()

        currentRow = MyReader.ReadFields()
        Dim currentField As String
        Dim data(0) As String
        Dim valid As Boolean = False
        Dim i As Integer = 0

        For Each currentField In currentRow
            ReDim Preserve data(i)
            data(i) = currentField
            i += 1
        Next

        For j As Integer = 1 To data.Length() / 2
            If encrypt(data((2 * j) - 2)) = username And encrypt(data((2 * j) - 1)) = password Then
                valid = True
            End If
        Next

        If valid = True Then
            Dim mainmenu As New MainMenu(username)
            Me.Hide()
            mainmenu.ShowDialog()
            Me.Close()
        Else
            MsgBox("Invalid Log In")
        End If

    End Sub

    Private Sub btnNewLogin_Click(sender As Object, e As EventArgs) Handles btnNewLogin.Click
        Dim newusername As String = ""
        Dim username As String = ""
        Dim valid As Boolean = False
        While valid = False
            newusername = InputBox("Enter the New username. It must be shorter than 15 characters And only contain lowercase letters And these characters, '/', '_', '-', ',', '.'")
            username = newusername
            While newusername.Length < 15
                newusername = newusername & "#"
            End While

            valid = validusername(newusername)
            If username.Contains("#") Then
                valid = False
            End If
            If Not valid Then
                MsgBox("That is not a valid username. Please enter another one.")
            End If
        End While

        Dim newpassword As String = ""
        Dim password As String = ""
        valid = False
        While valid = False
            newpassword = InputBox("Enter the new password. It must be shorter than 15 characters and only contain lowercase letters and these characters, '/', '_', '-', ',', '.'")
            password = newpassword
            While newpassword.Length < 15
                newpassword = newpassword & "#"
            End While
            valid = validusername(newpassword)
            If password.Contains("#") Then
                valid = False
            End If
            If Not valid Then
                MsgBox("That is not a valid password. Please enter another one.")
            End If
        End While


        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("logins.txt")
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters("|")
        Dim currentRow As String()
        currentRow = MyReader.ReadFields()
        Dim first As Boolean = False
        If currentRow Is Nothing Then
            first = True
        End If

        Dim txt As String = "logins.txt"
        If first = True Then
            System.IO.File.AppendAllText(txt, (encrypt(newusername) & "|" & encrypt(newpassword)))
        Else
            System.IO.File.AppendAllText(txt, ("|" & encrypt(newusername) & "|" & encrypt(newpassword)))
        End If
    End Sub

    Private Function validusername(username As String) As Boolean
        Dim validchars(31) As String
        For x = 0 To 31
            validchars(x) = toletter(x)
        Next
        Dim valid As Boolean = True
        If username = "               " Then
            Return False
        End If
        For i = 0 To 14
            If (validchars.Contains(username.Substring(i, 1)) = False) Then
                valid = False
            End If
        Next
        Return valid
    End Function

End Class