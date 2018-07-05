<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnLeaderboards = New System.Windows.Forms.Button()
        Me.btnPlayerStats = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnAIGame = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlayGame
        '
        Me.btnPlayGame.Location = New System.Drawing.Point(20, 200)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(80, 40)
        Me.btnPlayGame.TabIndex = 0
        Me.btnPlayGame.Text = "Play Game"
        Me.btnPlayGame.UseVisualStyleBackColor = True
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(120, 200)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(80, 40)
        Me.btnInstructions.TabIndex = 1
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnLeaderboards
        '
        Me.btnLeaderboards.Location = New System.Drawing.Point(220, 200)
        Me.btnLeaderboards.Name = "btnLeaderboards"
        Me.btnLeaderboards.Size = New System.Drawing.Size(80, 40)
        Me.btnLeaderboards.TabIndex = 2
        Me.btnLeaderboards.Text = "View Leaderboards"
        Me.btnLeaderboards.UseVisualStyleBackColor = True
        '
        'btnPlayerStats
        '
        Me.btnPlayerStats.Location = New System.Drawing.Point(320, 200)
        Me.btnPlayerStats.Name = "btnPlayerStats"
        Me.btnPlayerStats.Size = New System.Drawing.Size(80, 40)
        Me.btnPlayerStats.TabIndex = 3
        Me.btnPlayerStats.Text = "Player Satistics"
        Me.btnPlayerStats.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(620, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 40)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(520, 200)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(80, 40)
        Me.btnLogOut.TabIndex = 5
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnAIGame
        '
        Me.btnAIGame.Location = New System.Drawing.Point(420, 200)
        Me.btnAIGame.Name = "btnAIGame"
        Me.btnAIGame.Size = New System.Drawing.Size(80, 40)
        Me.btnAIGame.TabIndex = 4
        Me.btnAIGame.Text = "Watch AI Game"
        Me.btnAIGame.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(15, 33)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(49, 16)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Label1"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 253)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnAIGame)
        Me.Controls.Add(Me.btnPlayerStats)
        Me.Controls.Add(Me.btnLeaderboards)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlayGame As Button
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnLeaderboards As Button
    Friend WithEvents btnPlayerStats As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnAIGame As Button
    Friend WithEvents lblUsername As Label
End Class
