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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDTB = New System.Windows.Forms.TextBox()
        Me.productPB = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Product_Control13 = New Vending_Machine.Product_Control()
        Me.Product_Control14 = New Vending_Machine.Product_Control()
        Me.Product_Control15 = New Vending_Machine.Product_Control()
        Me.Product_Control16 = New Vending_Machine.Product_Control()
        Me.Product_Control9 = New Vending_Machine.Product_Control()
        Me.Product_Control10 = New Vending_Machine.Product_Control()
        Me.Product_Control11 = New Vending_Machine.Product_Control()
        Me.Product_Control12 = New Vending_Machine.Product_Control()
        Me.Product_Control5 = New Vending_Machine.Product_Control()
        Me.Product_Control6 = New Vending_Machine.Product_Control()
        Me.Product_Control7 = New Vending_Machine.Product_Control()
        Me.Product_Control8 = New Vending_Machine.Product_Control()
        Me.Product_Control4 = New Vending_Machine.Product_Control()
        Me.Product_Control3 = New Vending_Machine.Product_Control()
        Me.Product_Control2 = New Vending_Machine.Product_Control()
        Me.Product_Control1 = New Vending_Machine.Product_Control()
        CType(Me.productPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(705, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(705, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 75)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(705, 186)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 75)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(705, 273)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 75)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(12, 425)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(38, 16)
        Me.totalLabel.TabIndex = 4
        Me.totalLabel.Text = "$0.00"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(705, 360)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 75)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(616, 360)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 75)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IDTB
        '
        Me.IDTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTB.Location = New System.Drawing.Point(515, 360)
        Me.IDTB.Name = "IDTB"
        Me.IDTB.Size = New System.Drawing.Size(95, 75)
        Me.IDTB.TabIndex = 25
        Me.IDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'productPB
        '
        Me.productPB.Location = New System.Drawing.Point(474, 86)
        Me.productPB.Name = "productPB"
        Me.productPB.Size = New System.Drawing.Size(223, 220)
        Me.productPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productPB.TabIndex = 42
        Me.productPB.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 273)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 186)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 99)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 45
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(83, 75)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 46
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Product_Control13
        '
        Me.Product_Control13.Location = New System.Drawing.Point(203, 315)
        Me.Product_Control13.Name = "Product_Control13"
        Me.Product_Control13.productCount = 10
        Me.Product_Control13.productID = "D2"
        Me.Product_Control13.productPicture = CType(resources.GetObject("Product_Control13.productPicture"), System.Drawing.Image)
        Me.Product_Control13.productPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Product_Control13.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control13.TabIndex = 78
        '
        'Product_Control14
        '
        Me.Product_Control14.Location = New System.Drawing.Point(292, 315)
        Me.Product_Control14.Name = "Product_Control14"
        Me.Product_Control14.productCount = 10
        Me.Product_Control14.productID = "D3"
        Me.Product_Control14.productPicture = CType(resources.GetObject("Product_Control14.productPicture"), System.Drawing.Image)
        Me.Product_Control14.productPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Product_Control14.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control14.TabIndex = 77
        '
        'Product_Control15
        '
        Me.Product_Control15.Location = New System.Drawing.Point(381, 315)
        Me.Product_Control15.Name = "Product_Control15"
        Me.Product_Control15.productCount = 10
        Me.Product_Control15.productID = "D4"
        Me.Product_Control15.productPicture = CType(resources.GetObject("Product_Control15.productPicture"), System.Drawing.Image)
        Me.Product_Control15.productPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Product_Control15.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control15.TabIndex = 76
        '
        'Product_Control16
        '
        Me.Product_Control16.Location = New System.Drawing.Point(114, 315)
        Me.Product_Control16.Name = "Product_Control16"
        Me.Product_Control16.productCount = 10
        Me.Product_Control16.productID = "D1"
        Me.Product_Control16.productPicture = CType(resources.GetObject("Product_Control16.productPicture"), System.Drawing.Image)
        Me.Product_Control16.productPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Product_Control16.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control16.TabIndex = 75
        '
        'Product_Control9
        '
        Me.Product_Control9.Location = New System.Drawing.Point(203, 215)
        Me.Product_Control9.Name = "Product_Control9"
        Me.Product_Control9.productCount = 10
        Me.Product_Control9.productID = "C2"
        Me.Product_Control9.productPicture = CType(resources.GetObject("Product_Control9.productPicture"), System.Drawing.Image)
        Me.Product_Control9.productPrice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.Product_Control9.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control9.TabIndex = 74
        '
        'Product_Control10
        '
        Me.Product_Control10.Location = New System.Drawing.Point(292, 215)
        Me.Product_Control10.Name = "Product_Control10"
        Me.Product_Control10.productCount = 10
        Me.Product_Control10.productID = "C3"
        Me.Product_Control10.productPicture = CType(resources.GetObject("Product_Control10.productPicture"), System.Drawing.Image)
        Me.Product_Control10.productPrice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.Product_Control10.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control10.TabIndex = 73
        '
        'Product_Control11
        '
        Me.Product_Control11.Location = New System.Drawing.Point(381, 215)
        Me.Product_Control11.Name = "Product_Control11"
        Me.Product_Control11.productCount = 10
        Me.Product_Control11.productID = "C4"
        Me.Product_Control11.productPicture = CType(resources.GetObject("Product_Control11.productPicture"), System.Drawing.Image)
        Me.Product_Control11.productPrice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.Product_Control11.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control11.TabIndex = 72
        '
        'Product_Control12
        '
        Me.Product_Control12.Location = New System.Drawing.Point(114, 215)
        Me.Product_Control12.Name = "Product_Control12"
        Me.Product_Control12.productCount = 10
        Me.Product_Control12.productID = "C1"
        Me.Product_Control12.productPicture = CType(resources.GetObject("Product_Control12.productPicture"), System.Drawing.Image)
        Me.Product_Control12.productPrice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.Product_Control12.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control12.TabIndex = 71
        '
        'Product_Control5
        '
        Me.Product_Control5.Location = New System.Drawing.Point(203, 115)
        Me.Product_Control5.Name = "Product_Control5"
        Me.Product_Control5.productCount = 10
        Me.Product_Control5.productID = "B2"
        Me.Product_Control5.productPicture = CType(resources.GetObject("Product_Control5.productPicture"), System.Drawing.Image)
        Me.Product_Control5.productPrice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Product_Control5.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control5.TabIndex = 70
        '
        'Product_Control6
        '
        Me.Product_Control6.Location = New System.Drawing.Point(292, 115)
        Me.Product_Control6.Name = "Product_Control6"
        Me.Product_Control6.productCount = 10
        Me.Product_Control6.productID = "B3"
        Me.Product_Control6.productPicture = CType(resources.GetObject("Product_Control6.productPicture"), System.Drawing.Image)
        Me.Product_Control6.productPrice = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Product_Control6.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control6.TabIndex = 69
        '
        'Product_Control7
        '
        Me.Product_Control7.Location = New System.Drawing.Point(381, 115)
        Me.Product_Control7.Name = "Product_Control7"
        Me.Product_Control7.productCount = 10
        Me.Product_Control7.productID = "B4"
        Me.Product_Control7.productPicture = CType(resources.GetObject("Product_Control7.productPicture"), System.Drawing.Image)
        Me.Product_Control7.productPrice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Product_Control7.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control7.TabIndex = 68
        '
        'Product_Control8
        '
        Me.Product_Control8.Location = New System.Drawing.Point(114, 115)
        Me.Product_Control8.Name = "Product_Control8"
        Me.Product_Control8.productCount = 10
        Me.Product_Control8.productID = "B1"
        Me.Product_Control8.productPicture = CType(resources.GetObject("Product_Control8.productPicture"), System.Drawing.Image)
        Me.Product_Control8.productPrice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Product_Control8.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control8.TabIndex = 67
        '
        'Product_Control4
        '
        Me.Product_Control4.Location = New System.Drawing.Point(203, 15)
        Me.Product_Control4.Name = "Product_Control4"
        Me.Product_Control4.productCount = 10
        Me.Product_Control4.productID = "A2"
        Me.Product_Control4.productPicture = CType(resources.GetObject("Product_Control4.productPicture"), System.Drawing.Image)
        Me.Product_Control4.productPrice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Product_Control4.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control4.TabIndex = 66
        '
        'Product_Control3
        '
        Me.Product_Control3.Location = New System.Drawing.Point(292, 15)
        Me.Product_Control3.Name = "Product_Control3"
        Me.Product_Control3.productCount = 10
        Me.Product_Control3.productID = "A3"
        Me.Product_Control3.productPicture = CType(resources.GetObject("Product_Control3.productPicture"), System.Drawing.Image)
        Me.Product_Control3.productPrice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Product_Control3.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control3.TabIndex = 65
        '
        'Product_Control2
        '
        Me.Product_Control2.Location = New System.Drawing.Point(381, 15)
        Me.Product_Control2.Name = "Product_Control2"
        Me.Product_Control2.productCount = 10
        Me.Product_Control2.productID = "A4"
        Me.Product_Control2.productPicture = CType(resources.GetObject("Product_Control2.productPicture"), System.Drawing.Image)
        Me.Product_Control2.productPrice = New Decimal(New Integer() {75, 0, 0, 131072})
        Me.Product_Control2.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control2.TabIndex = 64
        '
        'Product_Control1
        '
        Me.Product_Control1.Location = New System.Drawing.Point(114, 15)
        Me.Product_Control1.Name = "Product_Control1"
        Me.Product_Control1.productCount = 10
        Me.Product_Control1.productID = "A1"
        Me.Product_Control1.productPicture = CType(resources.GetObject("Product_Control1.productPicture"), System.Drawing.Image)
        Me.Product_Control1.productPrice = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Product_Control1.Size = New System.Drawing.Size(83, 94)
        Me.Product_Control1.TabIndex = 63
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Product_Control13)
        Me.Controls.Add(Me.Product_Control14)
        Me.Controls.Add(Me.Product_Control15)
        Me.Controls.Add(Me.Product_Control16)
        Me.Controls.Add(Me.Product_Control9)
        Me.Controls.Add(Me.Product_Control10)
        Me.Controls.Add(Me.Product_Control11)
        Me.Controls.Add(Me.Product_Control12)
        Me.Controls.Add(Me.Product_Control5)
        Me.Controls.Add(Me.Product_Control6)
        Me.Controls.Add(Me.Product_Control7)
        Me.Controls.Add(Me.Product_Control8)
        Me.Controls.Add(Me.Product_Control4)
        Me.Controls.Add(Me.Product_Control3)
        Me.Controls.Add(Me.Product_Control2)
        Me.Controls.Add(Me.Product_Control1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.productPB)
        Me.Controls.Add(Me.IDTB)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.productPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents totalLabel As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents IDTB As TextBox
    Friend WithEvents productPB As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Product_Control13 As Product_Control
    Friend WithEvents Product_Control14 As Product_Control
    Friend WithEvents Product_Control15 As Product_Control
    Friend WithEvents Product_Control16 As Product_Control
    Friend WithEvents Product_Control9 As Product_Control
    Friend WithEvents Product_Control10 As Product_Control
    Friend WithEvents Product_Control11 As Product_Control
    Friend WithEvents Product_Control12 As Product_Control
    Friend WithEvents Product_Control5 As Product_Control
    Friend WithEvents Product_Control6 As Product_Control
    Friend WithEvents Product_Control7 As Product_Control
    Friend WithEvents Product_Control8 As Product_Control
    Friend WithEvents Product_Control4 As Product_Control
    Friend WithEvents Product_Control3 As Product_Control
    Friend WithEvents Product_Control2 As Product_Control
    Friend WithEvents Product_Control1 As Product_Control
End Class
