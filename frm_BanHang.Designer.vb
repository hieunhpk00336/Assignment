<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BanHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BanHang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsuakhachhang = New System.Windows.Forms.Button()
        Me.btnxoakhachhang = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsodienthoai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttenkhachhang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmakhachhang = New System.Windows.Forms.TextBox()
        Me.btnthemkhachhang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsvkhachhang = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsuakhachhang)
        Me.GroupBox1.Controls.Add(Me.btnxoakhachhang)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsodienthoai)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txttenkhachhang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtmakhachhang)
        Me.GroupBox1.Controls.Add(Me.btnthemkhachhang)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin khách hàng"
        '
        'btnsuakhachhang
        '
        Me.btnsuakhachhang.Location = New System.Drawing.Point(397, 168)
        Me.btnsuakhachhang.Name = "btnsuakhachhang"
        Me.btnsuakhachhang.Size = New System.Drawing.Size(75, 23)
        Me.btnsuakhachhang.TabIndex = 14
        Me.btnsuakhachhang.Text = "Sửa"
        Me.btnsuakhachhang.UseVisualStyleBackColor = True
        '
        'btnxoakhachhang
        '
        Me.btnxoakhachhang.Location = New System.Drawing.Point(314, 168)
        Me.btnxoakhachhang.Name = "btnxoakhachhang"
        Me.btnxoakhachhang.Size = New System.Drawing.Size(75, 23)
        Me.btnxoakhachhang.TabIndex = 13
        Me.btnxoakhachhang.Text = "Xóa"
        Me.btnxoakhachhang.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(96, 122)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(633, 20)
        Me.txtemail.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(96, 96)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(633, 20)
        Me.txtdiachi.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Địa chỉ"
        '
        'txtsodienthoai
        '
        Me.txtsodienthoai.Location = New System.Drawing.Point(96, 70)
        Me.txtsodienthoai.Name = "txtsodienthoai"
        Me.txtsodienthoai.Size = New System.Drawing.Size(633, 20)
        Me.txtsodienthoai.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Số điện thoại"
        '
        'txttenkhachhang
        '
        Me.txttenkhachhang.Location = New System.Drawing.Point(96, 45)
        Me.txttenkhachhang.Name = "txttenkhachhang"
        Me.txttenkhachhang.Size = New System.Drawing.Size(633, 20)
        Me.txttenkhachhang.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên khách hàng"
        '
        'txtmakhachhang
        '
        Me.txtmakhachhang.Location = New System.Drawing.Point(96, 19)
        Me.txtmakhachhang.Name = "txtmakhachhang"
        Me.txtmakhachhang.ReadOnly = True
        Me.txtmakhachhang.Size = New System.Drawing.Size(633, 20)
        Me.txtmakhachhang.TabIndex = 2
        '
        'btnthemkhachhang
        '
        Me.btnthemkhachhang.Location = New System.Drawing.Point(233, 168)
        Me.btnthemkhachhang.Name = "btnthemkhachhang"
        Me.btnthemkhachhang.Size = New System.Drawing.Size(75, 23)
        Me.btnthemkhachhang.TabIndex = 1
        Me.btnthemkhachhang.Text = "Thêm"
        Me.btnthemkhachhang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng"
        '
        'lsvkhachhang
        '
        Me.lsvkhachhang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvkhachhang.FullRowSelect = True
        Me.lsvkhachhang.GridLines = True
        Me.lsvkhachhang.Location = New System.Drawing.Point(12, 225)
        Me.lsvkhachhang.MultiSelect = False
        Me.lsvkhachhang.Name = "lsvkhachhang"
        Me.lsvkhachhang.Size = New System.Drawing.Size(755, 269)
        Me.lsvkhachhang.TabIndex = 3
        Me.lsvkhachhang.UseCompatibleStateImageBehavior = False
        Me.lsvkhachhang.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã khách hàng"
        Me.ColumnHeader1.Width = 87
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên khách hàng"
        Me.ColumnHeader2.Width = 126
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SĐT"
        Me.ColumnHeader4.Width = 156
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Địa chỉ"
        Me.ColumnHeader5.Width = 196
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Email"
        Me.ColumnHeader6.Width = 184
        '
        'frm_BanHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 506)
        Me.Controls.Add(Me.lsvkhachhang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_BanHang"
        Me.Text = "Quản Lý Bán Hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsuakhachhang As System.Windows.Forms.Button
    Friend WithEvents btnxoakhachhang As System.Windows.Forms.Button
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmakhachhang As System.Windows.Forms.TextBox
    Friend WithEvents btnthemkhachhang As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lsvkhachhang As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
