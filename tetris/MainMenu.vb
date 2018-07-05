Public Class MainMenu


    Public Sub New(username As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblUsername.Text = "logged in as " & username.Replace("#", "")
    End Sub

    Private Sub btnLeaderboards_Click(sender As Object, e As EventArgs) Handles btnLeaderboards.Click
        Dim leaderboards As New Leaderboards
        Me.Hide()
        leaderboards.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btnPlayerStats_Click(sender As Object, e As EventArgs) Handles btnPlayerStats.Click
        Dim playerstats As New PlayerStatistics
        Me.Hide()
        playerstats.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnPlayGame_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        Dim thegame As New TheGame
        Me.Hide()
        thegame.ShowDialog()
        Me.Show()
    End Sub
End Class
