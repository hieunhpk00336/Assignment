<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchitiethoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchitiethoadon))
        Me.lsvcthd = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lsvtthd = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lsvttsp = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.txtmacthd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvcthd
        '
        Me.lsvcthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader14, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvcthd.FullRowSelect = True
        Me.lsvcthd.GridLines = True
        Me.lsvcthd.Location = New System.Drawing.Point(9, 23)
        Me.lsvcthd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lsvcthd.Name = "lsvcthd"
        Me.lsvcthd.Size = New System.Drawing.Size(793, 626)
        Me.lsvcthd.TabIndex = 0
        Me.lsvcthd.UseCompatibleStateImageBehavior = False
        Me.lsvcthd.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã CTHD"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên Khách Hàng"
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mã Hóa Đơn"
        Me.ColumnHeader3.Width = 86
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Tên Sản Phẩm"
        Me.ColumnHeader14.Width = 132
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Số Lượng"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Đơn Giá"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Ngày Lập"
        Me.ColumnHeader6.Width = 88
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvcthd)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(812, 657)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Chi Tiết Hóa Đơn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lsvtthd)
        Me.GroupBox2.Location = New System.Drawing.Point(827, 167)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(501, 242)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông Tin Hóa Đơn"
        '
        'lsvtthd
        '
        Me.lsvtthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lsvtthd.FullRowSelect = True
        Me.lsvtthd.GridLines = True
        Me.lsvtthd.Location = New System.Drawing.Point(8, 23)
        Me.lsvtthd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lsvtthd.Name = "lsvtthd"
        Me.lsvtthd.Size = New System.Drawing.Size(483, 211)
        Me.lsvtthd.TabIndex = 0
        Me.lsvtthd.UseCompatibleStateImageBehavior = False
        Me.lsvtthd.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Mã Hoá Đơn"
        Me.ColumnHeader7.Width = 94
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Tên Khách Hàng"
        Me.ColumnHeader9.Width = 175
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Ngày Lập"
        Me.ColumnHeader10.Width = 86
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lsvttsp)
        Me.GroupBox3.Location = New System.Drawing.Point(827, 418)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(501, 242)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông Tin Sản Phẩm"
        '
        'lsvttsp
        '
        Me.lsvttsp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lsvttsp.FullRowSelect = True
        Me.lsvttsp.GridLines = True
        Me.lsvttsp.Location = New System.Drawing.Point(8, 23)
        Me.lsvttsp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lsvttsp.Name = "lsvttsp"
        Me.lsvttsp.Size = New System.Drawing.Size(483, 211)
        Me.lsvttsp.TabIndex = 0
        Me.lsvttsp.UseCompatibleStateImageBehavior = False
        Me.lsvttsp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Mã Sản Phẩm"
        Me.ColumnHeader11.Width = 105
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Tên Sản Phẩm"
        Me.ColumnHeader12.Width = 130
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Mô Tả"
        Me.ColumnHeader13.Width = 116
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnxoa)
        Me.GroupBox4.Controls.Add(Me.bntsua)
        Me.GroupBox4.Controls.Add(Me.btnthem)
        Me.GroupBox4.Controls.Add(Me.txtdongia)
        Me.GroupBox4.Controls.Add(Me.txtsoluong)
        Me.GroupBox4.Controls.Add(Me.txtmasanpham)
        Me.GroupBox4.Controls.Add(Me.txtmahoadon)
        Me.GroupBox4.Controls.Add(Me.txtmacthd)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(827, 4)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(501, 156)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(376, 113)
        Me.btnxoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(100, 28)
        Me.btnxoa.TabIndex = 2
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(376, 68)
        Me.bntsua.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(100, 28)
        Me.bntsua.TabIndex = 2
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(376, 23)
        Me.btnthem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(100, 28)
        Me.btnthem.TabIndex = 2
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(112, 127)
        Me.txtdongia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(235, 22)
        Me.txtdongia.TabIndex = 1
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(112, 97)
        Me.txtsoluong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(235, 22)
        Me.txtsoluong.TabIndex = 1
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(112, 69)
        Me.txtmasanpham.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.Size = New System.Drawing.Size(235, 22)
        Me.txtmasanpham.TabIndex = 1
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Location = New System.Drawing.Point(112, 41)
        Me.txtmahoadon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.Size = New System.Drawing.Size(235, 22)
        Me.txtmahoadon.TabIndex = 1
        '
        'txtmacthd
        '
        Me.txtmacthd.Location = New System.Drawing.Point(112, 12)
        Me.txtmacthd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmacthd.Name = "txtmacthd"
        Me.txtmacthd.ReadOnly = True
        Me.txtmacthd.Size = New System.Drawing.Size(235, 22)
        Me.txtmacthd.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Đơn Giá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số Lượng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã Sản Phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Hóa Đơn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã CTHD"
        '
        'frmchitiethoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 665)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmchitiethoadon"
        Me.Text = "Chi Tiết Hóa Đơn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvcthd As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvtthd As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvttsp As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtmasanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtmacthd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
End Class
