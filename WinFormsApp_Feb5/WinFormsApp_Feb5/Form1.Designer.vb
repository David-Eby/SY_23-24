﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ClickerControl1 = New WinFormsApp_Feb5.ClickerControl()
        Me.ClickerControl2 = New WinFormsApp_Feb5.ClickerControl()
        Me.ClickerControl3 = New WinFormsApp_Feb5.ClickerControl()
        Me.ClickerControl4 = New WinFormsApp_Feb5.ClickerControl()
        Me.ClickerControl5 = New WinFormsApp_Feb5.ClickerControl()
        Me.SuspendLayout()
        '
        'ClickerControl1
        '
        Me.ClickerControl1.Location = New System.Drawing.Point(13, 13)
        Me.ClickerControl1.Name = "ClickerControl1"
        Me.ClickerControl1.Size = New System.Drawing.Size(211, 64)
        Me.ClickerControl1.TabIndex = 0
        '
        'ClickerControl2
        '
        Me.ClickerControl2.Location = New System.Drawing.Point(13, 84)
        Me.ClickerControl2.Name = "ClickerControl2"
        Me.ClickerControl2.Size = New System.Drawing.Size(211, 64)
        Me.ClickerControl2.TabIndex = 1
        '
        'ClickerControl3
        '
        Me.ClickerControl3.Location = New System.Drawing.Point(13, 155)
        Me.ClickerControl3.Name = "ClickerControl3"
        Me.ClickerControl3.Size = New System.Drawing.Size(211, 64)
        Me.ClickerControl3.TabIndex = 2
        '
        'ClickerControl4
        '
        Me.ClickerControl4.Location = New System.Drawing.Point(13, 226)
        Me.ClickerControl4.Name = "ClickerControl4"
        Me.ClickerControl4.Size = New System.Drawing.Size(211, 64)
        Me.ClickerControl4.TabIndex = 3
        '
        'ClickerControl5
        '
        Me.ClickerControl5.Location = New System.Drawing.Point(13, 297)
        Me.ClickerControl5.Name = "ClickerControl5"
        Me.ClickerControl5.Size = New System.Drawing.Size(211, 64)
        Me.ClickerControl5.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClickerControl5)
        Me.Controls.Add(Me.ClickerControl4)
        Me.Controls.Add(Me.ClickerControl3)
        Me.Controls.Add(Me.ClickerControl2)
        Me.Controls.Add(Me.ClickerControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClickerControl1 As ClickerControl
    Friend WithEvents ClickerControl2 As ClickerControl
    Friend WithEvents ClickerControl3 As ClickerControl
    Friend WithEvents ClickerControl4 As ClickerControl
    Friend WithEvents ClickerControl5 As ClickerControl
End Class
