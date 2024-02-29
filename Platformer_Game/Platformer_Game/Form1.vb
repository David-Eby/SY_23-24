Public Class Form1
    Dim moveSpeed As Integer = 5

    Dim isJumping As Boolean
    Dim jumpForce As Integer = 10

    Dim gravForce As Integer = 9

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Enabled = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.W
                For Each b As Control In Me.Controls
                    If TypeOf b Is PictureBox Then
                        If b.Tag = "bound" Then
                            If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                                maxJumpTime.Enabled = True
                                tmrUp.Enabled = True
                                isJumping = True
                            End If
                        End If
                    End If
                Next
            Case Keys.A
                tmrLeft.Enabled = True
            Case Keys.D
                tmrRight.Enabled = True
            Case Keys.Up
                For Each b As Control In Me.Controls
                    If TypeOf b Is PictureBox Then
                        If b.Tag = "bound" Then
                            If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                                maxJumpTime.Enabled = True
                                tmrUp.Enabled = True
                                isJumping = True
                            End If
                        End If
                    End If
                Next
            Case Keys.Left
                tmrLeft.Enabled = True
            Case Keys.Right
                tmrRight.Enabled = True
            Case Keys.Space
                For Each b As Control In Me.Controls
                    If TypeOf b Is PictureBox Then
                        If b.Tag = "bound" Then
                            If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                                maxJumpTime.Enabled = True
                                tmrUp.Enabled = True
                                isJumping = True
                            End If
                        End If
                    End If
                Next
        End Select
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.W
                maxJumpTime.Enabled = False
                tmrUp.Enabled = False
                isJumping = False
            Case Keys.A
                tmrLeft.Enabled = False
            Case Keys.D
                tmrRight.Enabled = False
            Case Keys.Up
                maxJumpTime.Enabled = False
                tmrUp.Enabled = False
                isJumping = False
            Case Keys.Left
                tmrLeft.Enabled = False
            Case Keys.Right
                tmrRight.Enabled = False
            Case Keys.Space
                isJumping = False
                maxJumpTime.Enabled = False
                tmrUp.Enabled = False
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += moveSpeed
    End Sub
    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= moveSpeed
    End Sub
    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= jumpForce
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGrav.Enabled = False
        Else
            If isJumping = False Then
                tmrGrav.Enabled = True
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGrav.Enabled = False
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub tmrGrav_Tick(sender As Object, e As EventArgs) Handles tmrGrav.Tick
        picPlayer.Top += gravForce
    End Sub
    Private Sub maxJumpTime_Tick(sender As Object, e As EventArgs) Handles maxJumpTime.Tick
        tmrUp.Enabled = False
        isJumping = False
        tmrGrav.Enabled = True
        maxJumpTime.Enabled = False
    End Sub
End Class