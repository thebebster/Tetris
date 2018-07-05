<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerStatistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblGamesPlayed = New System.Windows.Forms.Label()
        Me.lblEasyScore = New System.Windows.Forms.Label()
        Me.lblMediumScore = New System.Windows.Forms.Label()
        Me.lblHardScore = New System.Windows.Forms.Label()
        Me.lblPlayedGames = New System.Windows.Forms.Label()
        Me.lblScoreEasy = New System.Windows.Forms.Label()
        Me.lblNamePlayer = New System.Windows.Forms.Label()
        Me.lblScoreMedium = New System.Windows.Forms.Label()
        Me.lblScoreHard = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFindAnother = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(15, 25)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(98, 20)
        Me.lblPlayerName.TabIndex = 0
        Me.lblPlayerName.Text = "Player Name"
        '
        'lblGamesPlayed
        '
        Me.lblGamesPlayed.AutoSize = True
        Me.lblGamesPlayed.Location = New System.Drawing.Point(15, 60)
        Me.lblGamesPlayed.Name = "lblGamesPlayed"
        Me.lblGamesPlayed.Size = New System.Drawing.Size(75, 13)
        Me.lblGamesPlayed.TabIndex = 1
        Me.lblGamesPlayed.Text = "Games Played"
        '
        'lblEasyScore
        '
        Me.lblEasyScore.AutoSize = True
        Me.lblEasyScore.Location = New System.Drawing.Point(15, 80)
        Me.lblEasyScore.Name = "lblEasyScore"
        Me.lblEasyScore.Size = New System.Drawing.Size(100, 13)
        Me.lblEasyScore.TabIndex = 2
        Me.lblEasyScore.Text = "Highest Easy Score"
        '
        'lblMediumScore
        '
        Me.lblMediumScore.AutoSize = True
        Me.lblMediumScore.Location = New System.Drawing.Point(15, 100)
        Me.lblMediumScore.Name = "lblMediumScore"
        Me.lblMediumScore.Size = New System.Drawing.Size(114, 13)
        Me.lblMediumScore.TabIndex = 3
        Me.lblMediumScore.Text = "Highest Medium Score"
        '
        'lblHardScore
        '
        Me.lblHardScore.AutoSize = True
        Me.lblHardScore.Location = New System.Drawing.Point(15, 120)
        Me.lblHardScore.Name = "lblHardScore"
        Me.lblHardScore.Size = New System.Drawing.Size(100, 13)
        Me.lblHardScore.TabIndex = 4
        Me.lblHardScore.Text = "Highest Hard Score"
        '
        'lblPlayedGames
        '
        Me.lblPlayedGames.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlayedGames.AutoSize = True
        Me.lblPlayedGames.Location = New System.Drawing.Point(180, 60)
        Me.lblPlayedGames.Name = "lblPlayedGames"
        Me.lblPlayedGames.Size = New System.Drawing.Size(22, 13)
        Me.lblPlayedGames.TabIndex = 5
        Me.lblPlayedGames.Text = "-----"
        '
        'lblScoreEasy
        '
        Me.lblScoreEasy.AutoSize = True
        Me.lblScoreEasy.Location = New System.Drawing.Point(180, 80)
        Me.lblScoreEasy.Name = "lblScoreEasy"
        Me.lblScoreEasy.Size = New System.Drawing.Size(22, 13)
        Me.lblScoreEasy.TabIndex = 6
        Me.lblScoreEasy.Text = "-----"
        '
        'lblNamePlayer
        '
        Me.lblNamePlayer.AutoSize = True
        Me.lblNamePlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamePlayer.Location = New System.Drawing.Point(180, 25)
        Me.lblNamePlayer.Name = "lblNamePlayer"
        Me.lblNamePlayer.Size = New System.Drawing.Size(34, 20)
        Me.lblNamePlayer.TabIndex = 7
        Me.lblNamePlayer.Text = "-----"
        '
        'lblScoreMedium
        '
        Me.lblScoreMedium.AutoSize = True
        Me.lblScoreMedium.Location = New System.Drawing.Point(180, 100)
        Me.lblScoreMedium.Name = "lblScoreMedium"
        Me.lblScoreMedium.Size = New System.Drawing.Size(22, 13)
        Me.lblScoreMedium.TabIndex = 8
        Me.lblScoreMedium.Text = "-----"
        '
        'lblScoreHard
        '
        Me.lblScoreHard.AutoSize = True
        Me.lblScoreHard.Location = New System.Drawing.Point(180, 120)
        Me.lblScoreHard.Name = "lblScoreHard"
        Me.lblScoreHard.Size = New System.Drawing.Size(22, 13)
        Me.lblScoreHard.TabIndex = 9
        Me.lblScoreHard.Text = "-----"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(19, 238)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFindAnother
        '
        Me.btnFindAnother.Location = New System.Drawing.Point(143, 238)
        Me.btnFindAnother.Name = "btnFindAnother"
        Me.btnFindAnother.Size = New System.Drawing.Size(127, 23)
        Me.btnFindAnother.TabIndex = 11
        Me.btnFindAnother.Text = "Find Another Player"
        Me.btnFindAnother.UseVisualStyleBackColor = True
        '
        'PlayerStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.btnFindAnother)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblScoreHard)
        Me.Controls.Add(Me.lblScoreMedium)
        Me.Controls.Add(Me.lblNamePlayer)
        Me.Controls.Add(Me.lblScoreEasy)
        Me.Controls.Add(Me.lblPlayedGames)
        Me.Controls.Add(Me.lblHardScore)
        Me.Controls.Add(Me.lblMediumScore)
        Me.Controls.Add(Me.lblEasyScore)
        Me.Controls.Add(Me.lblGamesPlayed)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Name = "PlayerStatistics"
        Me.Text = "PlayerStatistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblGamesPlayed As Label
    Friend WithEvents lblEasyScore As Label
    Friend WithEvents lblMediumScore As Label
    Friend WithEvents lblHardScore As Label
    Friend WithEvents lblPlayedGames As Label
    Friend WithEvents lblScoreEasy As Label
    Friend WithEvents lblNamePlayer As Label
    Friend WithEvents lblScoreMedium As Label
    Friend WithEvents lblScoreHard As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnFindAnother As Button
End Class
