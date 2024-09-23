<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addproduct
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pnametxtbox = New System.Windows.Forms.TextBox()
        Me.descriptiontxtbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pidtxtbox = New System.Windows.Forms.TextBox()
        Me.Pidgeneratebtn = New System.Windows.Forms.Button()
        Me.productimage = New System.Windows.Forms.PictureBox()
        Me.photoselectbtn = New System.Windows.Forms.Button()
        Me.addproductbtn = New System.Windows.Forms.Button()
        Me.categorycombobx = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addppanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.endtimepicker = New System.Windows.Forms.DateTimePicker()
        Me.starttimepicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ppricetxtbox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pathlbl = New System.Windows.Forms.Label()
        Me.pathname = New System.Windows.Forms.Label()
        Me.clearimage = New System.Windows.Forms.Button()
        CType(Me.productimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addppanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(40, 0, 640, 0)
        Me.Label1.Size = New System.Drawing.Size(961, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(161, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(161, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'Pnametxtbox
        '
        Me.Pnametxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pnametxtbox.Location = New System.Drawing.Point(160, 130)
        Me.Pnametxtbox.Multiline = True
        Me.Pnametxtbox.Name = "Pnametxtbox"
        Me.Pnametxtbox.Size = New System.Drawing.Size(209, 38)
        Me.Pnametxtbox.TabIndex = 3
        '
        'descriptiontxtbox
        '
        Me.descriptiontxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptiontxtbox.Location = New System.Drawing.Point(160, 240)
        Me.descriptiontxtbox.Multiline = True
        Me.descriptiontxtbox.Name = "descriptiontxtbox"
        Me.descriptiontxtbox.Size = New System.Drawing.Size(498, 102)
        Me.descriptiontxtbox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(449, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Product ID"
        '
        'Pidtxtbox
        '
        Me.Pidtxtbox.Cursor = System.Windows.Forms.Cursors.No
        Me.Pidtxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pidtxtbox.Location = New System.Drawing.Point(449, 130)
        Me.Pidtxtbox.Multiline = True
        Me.Pidtxtbox.Name = "Pidtxtbox"
        Me.Pidtxtbox.ReadOnly = True
        Me.Pidtxtbox.Size = New System.Drawing.Size(209, 38)
        Me.Pidtxtbox.TabIndex = 8
        Me.Pidtxtbox.TabStop = False
        Me.Pidtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pidgeneratebtn
        '
        Me.Pidgeneratebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pidgeneratebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pidgeneratebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Pidgeneratebtn.Location = New System.Drawing.Point(664, 135)
        Me.Pidgeneratebtn.Name = "Pidgeneratebtn"
        Me.Pidgeneratebtn.Size = New System.Drawing.Size(98, 29)
        Me.Pidgeneratebtn.TabIndex = 9
        Me.Pidgeneratebtn.Text = "Generate"
        Me.Pidgeneratebtn.UseVisualStyleBackColor = True
        '
        'productimage
        '
        Me.productimage.BackColor = System.Drawing.Color.Transparent
        Me.productimage.Image = Global.addproductpanel.My.Resources.Resources.add_image
        Me.productimage.Location = New System.Drawing.Point(712, 217)
        Me.productimage.Name = "productimage"
        Me.productimage.Size = New System.Drawing.Size(200, 200)
        Me.productimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productimage.TabIndex = 16
        Me.productimage.TabStop = False
        '
        'photoselectbtn
        '
        Me.photoselectbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.photoselectbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.photoselectbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.photoselectbtn.Location = New System.Drawing.Point(712, 441)
        Me.photoselectbtn.Name = "photoselectbtn"
        Me.photoselectbtn.Size = New System.Drawing.Size(200, 35)
        Me.photoselectbtn.TabIndex = 17
        Me.photoselectbtn.Text = "Select Photo"
        Me.photoselectbtn.UseVisualStyleBackColor = True
        '
        'addproductbtn
        '
        Me.addproductbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.addproductbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addproductbtn.FlatAppearance.BorderSize = 0
        Me.addproductbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addproductbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addproductbtn.ForeColor = System.Drawing.Color.White
        Me.addproductbtn.Location = New System.Drawing.Point(334, 588)
        Me.addproductbtn.Name = "addproductbtn"
        Me.addproductbtn.Size = New System.Drawing.Size(200, 51)
        Me.addproductbtn.TabIndex = 18
        Me.addproductbtn.Text = "Add Product"
        Me.addproductbtn.UseVisualStyleBackColor = False
        '
        'categorycombobx
        '
        Me.categorycombobx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.categorycombobx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorycombobx.ForeColor = System.Drawing.Color.Gray
        Me.categorycombobx.FormattingEnabled = True
        Me.categorycombobx.Items.AddRange(New Object() {"Art", "Electronics", "Furniture", "Collectibles", "Fashion", "Sports Equipment", "Home Appliances", "Toys", "Books", "Vehicles"})
        Me.categorycombobx.Location = New System.Drawing.Point(483, 400)
        Me.categorycombobx.Name = "categorycombobx"
        Me.categorycombobx.Size = New System.Drawing.Size(159, 28)
        Me.categorycombobx.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(484, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Label4.Size = New System.Drawing.Size(99, 28)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Category"
        '
        'addppanel
        '
        Me.addppanel.BackColor = System.Drawing.Color.White
        Me.addppanel.Controls.Add(Me.clearimage)
        Me.addppanel.Controls.Add(Me.pathname)
        Me.addppanel.Controls.Add(Me.pathlbl)
        Me.addppanel.Controls.Add(Me.PictureBox1)
        Me.addppanel.Controls.Add(Me.endtimepicker)
        Me.addppanel.Controls.Add(Me.starttimepicker)
        Me.addppanel.Controls.Add(Me.Label8)
        Me.addppanel.Controls.Add(Me.Label7)
        Me.addppanel.Controls.Add(Me.Label6)
        Me.addppanel.Controls.Add(Me.Ppricetxtbox)
        Me.addppanel.Controls.Add(Me.Label4)
        Me.addppanel.Controls.Add(Me.categorycombobx)
        Me.addppanel.Controls.Add(Me.addproductbtn)
        Me.addppanel.Controls.Add(Me.photoselectbtn)
        Me.addppanel.Controls.Add(Me.productimage)
        Me.addppanel.Controls.Add(Me.Pidgeneratebtn)
        Me.addppanel.Controls.Add(Me.Pidtxtbox)
        Me.addppanel.Controls.Add(Me.Label5)
        Me.addppanel.Controls.Add(Me.descriptiontxtbox)
        Me.addppanel.Controls.Add(Me.Pnametxtbox)
        Me.addppanel.Controls.Add(Me.Label3)
        Me.addppanel.Controls.Add(Me.Label2)
        Me.addppanel.Controls.Add(Me.Label1)
        Me.addppanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addppanel.ForeColor = System.Drawing.Color.White
        Me.addppanel.Location = New System.Drawing.Point(0, 0)
        Me.addppanel.Name = "addppanel"
        Me.addppanel.Size = New System.Drawing.Size(962, 691)
        Me.addppanel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.addproductpanel.My.Resources.Resources.rupee
        Me.PictureBox1.Location = New System.Drawing.Point(129, 406)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'endtimepicker
        '
        Me.endtimepicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.endtimepicker.Location = New System.Drawing.Point(483, 510)
        Me.endtimepicker.Name = "endtimepicker"
        Me.endtimepicker.Size = New System.Drawing.Size(209, 20)
        Me.endtimepicker.TabIndex = 28
        '
        'starttimepicker
        '
        Me.starttimepicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.starttimepicker.Location = New System.Drawing.Point(160, 510)
        Me.starttimepicker.Name = "starttimepicker"
        Me.starttimepicker.Size = New System.Drawing.Size(209, 20)
        Me.starttimepicker.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(483, 473)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Auction End Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(161, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Auction Start Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(161, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Product Price"
        '
        'Ppricetxtbox
        '
        Me.Ppricetxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ppricetxtbox.Location = New System.Drawing.Point(160, 400)
        Me.Ppricetxtbox.Multiline = True
        Me.Ppricetxtbox.Name = "Ppricetxtbox"
        Me.Ppricetxtbox.Size = New System.Drawing.Size(209, 38)
        Me.Ppricetxtbox.TabIndex = 23
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pathlbl
        '
        Me.pathlbl.AutoSize = True
        Me.pathlbl.BackColor = System.Drawing.Color.White
        Me.pathlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathlbl.ForeColor = System.Drawing.Color.Black
        Me.pathlbl.Location = New System.Drawing.Point(697, 422)
        Me.pathlbl.Name = "pathlbl"
        Me.pathlbl.Size = New System.Drawing.Size(40, 16)
        Me.pathlbl.TabIndex = 30
        Me.pathlbl.Text = "Path :"
        Me.pathlbl.Visible = False
        '
        'pathname
        '
        Me.pathname.AutoSize = True
        Me.pathname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathname.ForeColor = System.Drawing.Color.Black
        Me.pathname.Location = New System.Drawing.Point(734, 422)
        Me.pathname.Name = "pathname"
        Me.pathname.Size = New System.Drawing.Size(0, 16)
        Me.pathname.TabIndex = 31
        '
        'clearimage
        '
        Me.clearimage.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clearimage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearimage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearimage.ForeColor = System.Drawing.Color.White
        Me.clearimage.Location = New System.Drawing.Point(712, 482)
        Me.clearimage.Name = "clearimage"
        Me.clearimage.Size = New System.Drawing.Size(200, 35)
        Me.clearimage.TabIndex = 32
        Me.clearimage.Text = "Clear Image"
        Me.clearimage.UseVisualStyleBackColor = False
        Me.clearimage.Visible = False
        '
        'addproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 691)
        Me.Controls.Add(Me.addppanel)
        Me.Name = "addproduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.productimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addppanel.ResumeLayout(False)
        Me.addppanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Pnametxtbox As TextBox
    Friend WithEvents descriptiontxtbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Pidtxtbox As TextBox
    Friend WithEvents Pidgeneratebtn As Button
    Friend WithEvents productimage As PictureBox
    Friend WithEvents photoselectbtn As Button
    Friend WithEvents addproductbtn As Button
    Friend WithEvents categorycombobx As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addppanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents endtimepicker As DateTimePicker
    Friend WithEvents starttimepicker As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Ppricetxtbox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pathlbl As Label
    Friend WithEvents pathname As Label
    Friend WithEvents clearimage As Button
End Class
