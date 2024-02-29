<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGrav = New System.Windows.Forms.Timer(Me.components)
        Me.picBound1 = New System.Windows.Forms.PictureBox()
        Me.picBound2 = New System.Windows.Forms.PictureBox()
        Me.picBound3 = New System.Windows.Forms.PictureBox()
        Me.maxJumpTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBound1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBound2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBound3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.SystemColors.Control
        Me.picPlayer.BackgroundImage = CType(resources.GetObject("picPlayer.BackgroundImage"), System.Drawing.Image)
        Me.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPlayer.Location = New System.Drawing.Point(67, 342)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(37, 62)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picGround.Location = New System.Drawing.Point(-4, 403)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(812, 50)
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        Me.picGround.Tag = "bound"
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 10
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 10
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 10
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 5
        '
        'tmrGrav
        '
        Me.tmrGrav.Interval = 10
        '
        'picBound1
        '
        Me.picBound1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picBound1.Location = New System.Drawing.Point(471, 288)
        Me.picBound1.Name = "picBound1"
        Me.picBound1.Size = New System.Drawing.Size(151, 28)
        Me.picBound1.TabIndex = 3
        Me.picBound1.TabStop = False
        Me.picBound1.Tag = "bound"
        '
        'picBound2
        '
        Me.picBound2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picBound2.Location = New System.Drawing.Point(184, 181)
        Me.picBound2.Name = "picBound2"
        Me.picBound2.Size = New System.Drawing.Size(151, 28)
        Me.picBound2.TabIndex = 4
        Me.picBound2.TabStop = False
        Me.picBound2.Tag = "bound"
        '
        'picBound3
        '
        Me.picBound3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picBound3.Location = New System.Drawing.Point(424, 49)
        Me.picBound3.Name = "picBound3"
        Me.picBound3.Size = New System.Drawing.Size(151, 28)
        Me.picBound3.TabIndex = 5
        Me.picBound3.TabStop = False
        Me.picBound3.Tag = "bound"
        '
        'maxJumpTime
        '
        Me.maxJumpTime.Interval = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picBound3)
        Me.Controls.Add(Me.picBound2)
        Me.Controls.Add(Me.picBound1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picGround)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBound1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBound2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBound3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGrav As Timer
    Friend WithEvents picBound1 As PictureBox
    Friend WithEvents picBound2 As PictureBox
    Friend WithEvents picBound3 As PictureBox
    Friend WithEvents maxJumpTime As Timer
End Class
