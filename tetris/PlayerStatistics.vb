Public Class PlayerStatistics
    Private Sub PlayerStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        findplayer()

    End Sub

    Private Sub findplayer()
        Dim found As Boolean = False
        Dim doesntexist As Boolean = False
        'playername, numberofgames, easyscore, mediumscore, hardscore
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("PlayerStatistics.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")
            Dim currentRow As String()

            currentRow = MyReader.ReadFields()
            Dim currentField As String
            Dim data(20) As String
            Dim i As Integer = 0
            For Each currentField In currentRow
                ReDim Preserve data(i)
                data(i) = currentField
                i += 1
            Next

            found = False
            Dim playername As String
                playername = InputBox("Enter the name of the player.")
                playername = fifteen(playername)
                doesntexist = False

                Dim j As Integer = 0
                j = 0
                While found = False And doesntexist = False
                    j = 0
                    If fifteen(data(5 * j)) = playername Then
                        found = True
                        Dim numberofgames As Integer = data((5 * j) + 1)
                        Dim easyscore As Integer = data((5 * j) + 2)
                        Dim mediumscore As Integer = data((5 * j) + 3)
                        Dim hardscore As Integer = data((5 * j) + 4)
                        showstats(playername, numberofgames, easyscore, mediumscore, hardscore)
                    End If
                    j += 1
                    If (5 * j) > (data.Length - 1) Then
                        doesntexist = True
                    End If
                End While

                If found = True Then
                MsgBox("Player found")
            ElseIf doesntexist = True Then
                MsgBox("Player not found")
            End If


        End Using
    End Sub

    Private Function fifteen(ByVal text As String)
        While text.Length < 15
            text = text & " "
        End While
        Return text
    End Function
    Private Sub showstats(name As String, numberofgames As Integer, easyscore As Integer, mediumscore As Integer, hardscore As Integer)
        lblNamePlayer.Text = name
        lblPlayedGames.Text = numberofgames
        lblScoreEasy.Text = easyscore
        lblScoreMedium.Text = mediumscore
        lblScoreHard.Text = hardscore
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFindAnother_Click(sender As Object, e As EventArgs) Handles btnFindAnother.Click
        findplayer()
    End Sub
End Class