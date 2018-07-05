Public Class TheGame
    Dim field(10, 20) As tile
    Dim fallingpiece As piece
    Dim WithEvents timer As System.Windows.Forms.Timer

    Private Sub TheGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer = New System.Windows.Forms.Timer
        timer.Interval = 200
        timer.Enabled = True
        timer.Start()

        For i = 1 To 10
            For j = 1 To 20
                field(i, j) = New tile(Color.White)
            Next
        Next
        Dim Rnd As New Random
        Dim x As Integer = Rnd.Next(1, 8)
        Select Case x
            Case 1
                fallingpiece = New pieceT
            Case 2
                fallingpiece = New pieceS
            Case 3
                fallingpiece = New pieceZ
            Case 4
                fallingpiece = New pieceL
            Case 5
                fallingpiece = New pieceO
            Case 6
                fallingpiece = New pieceJ
            Case 7
                fallingpiece = New pieceI
        End Select
        fallingpiece.position = New point(5, 18)
    End Sub

    Private Sub timerevent(myObject As Object, e As EventArgs) Handles timer.Tick
        Dim valid As Boolean = True

        For i = 0 To 3
            If (fallingpiece.position.ypos - fallingpiece.points(i).ypos) - 1 < 1 Then
                valid = False
            End If
        Next
        If valid Then
            For i = 0 To 3
                If Not (field((fallingpiece.position.xpos + fallingpiece.points(i).xpos), (fallingpiece.position.ypos - fallingpiece.points(i).ypos) - 1).colour = System.Drawing.Color.White) Then
                    valid = False
                End If
            Next
        End If
        If valid Then
            fallingpiece.position.ypos -= 1
        Else
            placepiece()
        End If

        Me.Refresh()

    End Sub

    Private Sub TheGame_Keydown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                Dim valid As Boolean = True
                For i = 0 To 3
                    If (fallingpiece.position.xpos + fallingpiece.points(i).xpos) - 1 < 1 Then
                        valid = False
                    End If
                Next
                If valid Then
                    For i = 0 To 3
                        If Not (field((fallingpiece.position.xpos + fallingpiece.points(i).xpos) - 1, (fallingpiece.position.ypos - fallingpiece.points(i).ypos)).colour = System.Drawing.Color.White) Then
                            valid = False
                        End If
                    Next
                End If
                If valid Then
                    fallingpiece.position.xpos -= 1
                    Me.Refresh()
                End If
            Case Keys.Right
                Dim valid As Boolean = True
                For i = 0 To 3
                    If (fallingpiece.position.xpos + fallingpiece.points(i).xpos) + 1 > 10 Then
                        valid = False
                    End If
                Next
                If valid Then
                    For i = 0 To 3
                        If Not (field((fallingpiece.position.xpos + fallingpiece.points(i).xpos) + 1, (fallingpiece.position.ypos - fallingpiece.points(i).ypos)).colour = System.Drawing.Color.White) Then
                            valid = False
                        End If
                    Next
                End If
                If valid Then
                    fallingpiece.position.xpos += 1
                    Me.Refresh()
                End If
            Case Keys.X
                checkright()
                Me.Refresh()
            Case Keys.Z
                checkleft()
                Me.Refresh()
        End Select

    End Sub

    Private Sub translate(number As Integer)
        fallingpiece.position.xpos += number
    End Sub


    Private Sub checkleft()
        Dim number As Integer = 0
        fallingpiece.rotateleft()
        For i = 0 To 3
            If (fallingpiece.position.xpos + fallingpiece.points(i).xpos) > 10 Then
                If Math.Abs(number) < (fallingpiece.position.xpos + fallingpiece.points(i).xpos) - 10 Then
                    number = (fallingpiece.position.xpos + fallingpiece.points(i).xpos - 10)
                End If
            ElseIf (fallingpiece.position.xpos + fallingpiece.points(i).xpos) < 1 Then
                If Math.Abs(number) < Math.Abs((fallingpiece.position.xpos + fallingpiece.points(i).xpos) - 1) Then
                    number = (fallingpiece.position.xpos + fallingpiece.points(i).xpos - 1)
                End If
            End If
        Next
        translate(-number)
    End Sub

    Private Sub checkright()
        Dim number As Integer = 0
        fallingpiece.rotateright()
        For i = 0 To 3
            If (fallingpiece.position.xpos + fallingpiece.points(i).xpos) > 10 Then
                If Math.Abs(number) < (fallingpiece.position.xpos + fallingpiece.points(i).xpos) - 10 Then
                    number = (fallingpiece.position.xpos + fallingpiece.points(i).xpos - 10)
                End If
            ElseIf (fallingpiece.position.xpos + fallingpiece.points(i).xpos) < 1 Then
                If Math.Abs(number) < Math.Abs((fallingpiece.position.xpos + fallingpiece.points(i).xpos) - 1) Then
                    number = (fallingpiece.position.xpos + fallingpiece.points(i).xpos - 1)
                End If
            End If
        Next
        translate(-number)
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim tilewidth As Integer = 20
        Dim tileheight As Integer = 20
        For x = 1 To 10
            For y = 1 To 20
                Dim brush1 As New Drawing.SolidBrush(field(x, y).colour)
                e.Graphics.FillRectangle(brush1, 20 + (tilewidth * x), 20 + (tileheight * (20 - y)), tilewidth, tileheight)
            Next
        Next
        Dim brush2 As New Drawing.SolidBrush(fallingpiece.colour)
        For i = 0 To 3
            e.Graphics.FillRectangle(brush2, 20 + (tilewidth * (fallingpiece.position.xpos + fallingpiece.points(i).xpos)), 20 + (tileheight * (20 - (fallingpiece.position.ypos - fallingpiece.points(i).ypos))), tilewidth, tileheight)
        Next
    End Sub

    Private Sub placepiece()
        Dim Rnd As New Random
        For i = 0 To 3
            field(fallingpiece.position.xpos + fallingpiece.points(i).xpos, fallingpiece.position.ypos - fallingpiece.points(i).ypos) = New tile(fallingpiece.colour)
        Next
        Dim x As Integer = Rnd.Next(1, 8)
        Select Case x
            Case 1
                fallingpiece = New pieceT
            Case 2
                fallingpiece = New pieceS
            Case 3
                fallingpiece = New pieceZ
            Case 4
                fallingpiece = New pieceL
            Case 5
                fallingpiece = New pieceO
            Case 6
                fallingpiece = New pieceJ
            Case 7
                fallingpiece = New pieceI
        End Select
        fallingpiece.position = New point(5, 18)
        rowcomplete()
    End Sub

    Private Sub rowcomplete()
        Dim rows_complete(0) As Integer
        Dim complete As Boolean = False
        For y = 1 To 20
            complete = True
            For x = 1 To 10
                If field(x, y).colour = System.Drawing.Color.White Then
                    complete = False
                End If
            Next
            If complete = True Then
                ReDim Preserve rows_complete(rows_complete.Length)
                rows_complete(rows_complete.Length - 1) = y
            End If
        Next
        If rows_complete.Length > 1 = True Then
            For y = 1 To rows_complete.Length - 1
                For y2 = rows_complete(y) To 19
                    For x = 1 To 10
                        field(x, y2) = field(x, y2 + 1)
                    Next
                Next
            Next
        End If
    End Sub
End Class

MustInherit Class piece
    Public points(3) As point
    Public position As point
    Public colour As System.Drawing.Color

    Public Sub rotateright()
        For i = 1 To 3
            Dim x As Integer = points(i).xpos
            Dim y As Integer = points(i).ypos

            points(i).xpos = -y
            points(i).ypos = x
        Next
    End Sub
    Public Sub rotateleft()
        For i = 1 To 3
            Dim x As Integer = points(i).xpos
            Dim y As Integer = points(i).ypos

            points(i).xpos = y
            points(i).ypos = -x
        Next
    End Sub
End Class

Class pieceT
    Inherits piece

    Public Sub New()
        colour = System.Drawing.Color.Magenta
        points(0) = New point(0, 0)
        points(1) = New point(-1, 0)
        points(2) = New point(1, 0)
        points(3) = New point(0, -1)
    End Sub

End Class

Class pieceS
    Inherits piece

    Public Sub New()
        colour = System.Drawing.Color.Green
        points(0) = New point(0, 0)
        points(1) = New point(1, 0)
        points(2) = New point(0, -1)
        points(3) = New point(-1, -1)
    End Sub

End Class

Class pieceZ
    Inherits piece

    Public Sub New()
        colour = System.Drawing.Color.Red
        points(0) = New point(0, 0)
        points(1) = New point(-1, 0)
        points(2) = New point(0, -1)
        points(3) = New point(1, -1)
    End Sub

End Class

Class pieceL
    Inherits piece

    Public Sub New()
        colour = System.Drawing.Color.Orange
        points(0) = New point(0, 0)
        points(1) = New point(1, 0)
        points(2) = New point(0, 1)
        points(3) = New point(0, 2)
    End Sub

End Class

Class pieceO
    Inherits piece

    Public Sub New()
        colour = System.Drawing.Color.Yellow
        points(0) = New point(0, 0)
        points(1) = New point(1, 0)
        points(2) = New point(1, 1)
        points(3) = New point(0, 1)
    End Sub

End Class

Class pieceJ
    Inherits piece

    Public Sub New()
        colour = System.Drawing.Color.Blue
        points(0) = New point(0, 0)
        points(1) = New point(-1, 0)
        points(2) = New point(0, 1)
        points(3) = New point(0, 2)
    End Sub

End Class

Class pieceI
    Inherits piece

    Public Sub New()
        colour = System.Drawing.Color.Cyan
        points(0) = New point(0, 0)
        points(1) = New point(-1, 0)
        points(2) = New point(1, 0)
        points(3) = New point(2, 0)
    End Sub

End Class

Class point
    Public xpos As Integer
    Public ypos As Integer

    Public Sub New(x As Integer, y As Integer)
        xpos = x
        ypos = y
    End Sub
End Class

Class tile
    Public colour As System.Drawing.Color
    Public Sub New(c As System.Drawing.Color)
        colour = c
    End Sub
End Class