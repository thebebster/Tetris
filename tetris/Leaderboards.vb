Public Class Leaderboards
    Dim difficulty As String
    Private Sub frmLeaderboards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        difficulty = "Easy"
        UpdateTable(difficulty)
    End Sub

    Private Sub btnDifficulty_Click(sender As Object, e As EventArgs) Handles btnEasy.Click, btnHard.Click, btnMedium.Click
        Try
            UpdateTable(sender.Name.Substring(3, 4))
        Catch ex1 As Exception
            Try
                UpdateTable(sender.name.substring(3, 6))
            Catch ex2 As Exception
                MsgBox("There has been an error retrieveing leader boards")
            End Try
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub UpdateTable(difficulty As String)
        difficulty = difficulty
        lblLeaderboard.Text = (difficulty & " Leader Boards")
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(difficulty & "LeaderBoard.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")
            Dim currentRow As String()

            currentRow = MyReader.ReadFields()
            Dim currentField As String
            Dim data(20) As String
            Dim i As Integer = 0
            For Each currentField In currentRow
                data(i) = currentField
                i += 1
            Next
            For j As Integer = 1 To 10
                Me.Controls("lblPlayer" & j).Text = data((2 * j) - 2)
                Me.Controls("lblScore" & j).Text = data((2 * j) - 1)

            Next
        End Using

    End Sub
End Class