<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ReelControl3 = New Slot_Machine.ReelControl()
        Me.ReelControl2 = New Slot_Machine.ReelControl()
        Me.ReelControl1 = New Slot_Machine.ReelControl()
        Me.winTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(705, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 47)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Timer2
        '
        Me.Timer2.Interval = 80
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 273)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 75)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "0"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 186)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 75)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "0"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(12, 99)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 75)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "0"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(12, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 75)
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "100"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(12, 424)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(38, 16)
        Me.totalLabel.TabIndex = 40
        Me.totalLabel.Text = "$0.00"
        '
        'Timer3
        '
        Me.Timer3.Interval = 2100
        '
        'ReelControl3
        '
        Me.ReelControl3.BackColor = System.Drawing.Color.Transparent
        Me.ReelControl3.itemValue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(481, 138)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Seed = 15
        Me.ReelControl3.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl3.spinTime = 2000
        Me.ReelControl3.TabIndex = 43
        '
        'ReelControl2
        '
        Me.ReelControl2.BackColor = System.Drawing.Color.Transparent
        Me.ReelControl2.itemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(316, 138)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Seed = 5
        Me.ReelControl2.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl2.spinTime = 2000
        Me.ReelControl2.TabIndex = 42
        '
        'ReelControl1
        '
        Me.ReelControl1.BackColor = System.Drawing.Color.Transparent
        Me.ReelControl1.itemValue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(152, 138)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Seed = 10
        Me.ReelControl1.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl1.spinTime = 2000
        Me.ReelControl1.TabIndex = 41
        '
        'winTB
        '
        Me.winTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.winTB.Cursor = System.Windows.Forms.Cursors.No
        Me.winTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winTB.Location = New System.Drawing.Point(133, 37)
        Me.winTB.Name = "winTB"
        Me.winTB.ReadOnly = True
        Me.winTB.Size = New System.Drawing.Size(519, 54)
        Me.winTB.TabIndex = 44
        Me.winTB.Text = "Spin"
        Me.winTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.winTB)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents totalLabel As Label
    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents Timer3 As Timer
    Friend WithEvents winTB As TextBox
End Class
