<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SanPham))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.btnsuasanpham = New System.Windows.Forms.Button()
        Me.btnxoasanpham = New System.Windows.Forms.Button()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttensanpham = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnthemsanpham = New System.Windows.Forms.Button()
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsvsanpham = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsualoaisanpham = New System.Windows.Forms.Button()
        Me.txtmotaloaisanpham = New System.Windows.Forms.TextBox()
        Me.btnxoaloaisanpham = New System.Windows.Forms.Button()
        Me.btnthemloaisanpham = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lsvloaisanpham = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txttenloaisanpham = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmaloaisanpham = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmaloai)
        Me.GroupBox1.Controls.Add(Me.btnsuasanpham)
        Me.GroupBox1.Controls.Add(Me.btnxoasanpham)
        Me.GroupBox1.Controls.Add(Me.txtmota)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtdongia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttensanpham)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnthemsanpham)
        Me.GroupBox1.Controls.Add(Me.txtmasanpham)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lsvsanpham)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 467)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin sản phẩm"
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(88, 88)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(251, 20)
        Me.txtmaloai.TabIndex = 12
        '
        'btnsuasanpham
        '
        Me.btnsuasanpham.Location = New System.Drawing.Point(250, 226)
        Me.btnsuasanpham.Name = "btnsuasanpham"
        Me.btnsuasanpham.Size = New System.Drawing.Size(75, 23)
        Me.btnsuasanpham.TabIndex = 8
        Me.btnsuasanpham.Text = "Sửa"
        Me.btnsuasanpham.UseVisualStyleBackColor = True
        '
        'btnxoasanpham
        '
        Me.btnxoasanpham.Location = New System.Drawing.Point(169, 226)
        Me.btnxoasanpham.Name = "btnxoasanpham"
        Me.btnxoasanpham.Size = New System.Drawing.Size(75, 23)
        Me.btnxoasanpham.TabIndex = 7
        Me.btnxoasanpham.Text = "Xóa"
        Me.btnxoasanpham.UseVisualStyleBackColor = True
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(88, 139)
        Me.txtmota.Multiline = True
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(251, 81)
        Me.txtmota.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mô tả"
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(88, 113)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(251, 20)
        Me.txtdongia.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Đơn giá"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mã loại"
        '
        'txttensanpham
        '
        Me.txttensanpham.Location = New System.Drawing.Point(88, 61)
        Me.txttensanpham.Name = "txttensanpham"
        Me.txttensanpham.Size = New System.Drawing.Size(251, 20)
        Me.txttensanpham.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tên sản phẩm"
        '
        'btnthemsanpham
        '
        Me.btnthemsanpham.Location = New System.Drawing.Point(88, 226)
        Me.btnthemsanpham.Name = "btnthemsanpham"
        Me.btnthemsanpham.Size = New System.Drawing.Size(75, 23)
        Me.btnthemsanpham.TabIndex = 6
        Me.btnthemsanpham.Text = "Thêm"
        Me.btnthemsanpham.UseVisualStyleBackColor = True
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(88, 35)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.ReadOnly = True
        Me.txtmasanpham.Size = New System.Drawing.Size(251, 20)
        Me.txtmasanpham.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã sản phẩm"
        '
        'lsvsanpham
        '
        Me.lsvsanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvsanpham.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsvsanpham.FullRowSelect = True
        Me.lsvsanpham.GridLines = True
        Me.lsvsanpham.Location = New System.Drawing.Point(3, 255)
        Me.lsvsanpham.Name = "lsvsanpham"
        Me.lsvsanpham.Size = New System.Drawing.Size(383, 209)
        Me.lsvsanpham.TabIndex = 0
        Me.lsvsanpham.UseCompatibleStateImageBehavior = False
        Me.lsvsanpham.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã sản phẩm"
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên sản phẩm"
        Me.ColumnHeader2.Width = 85
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Loại"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Đơn giá"
        Me.ColumnHeader4.Width = 79
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Mô tả"
        Me.ColumnHeader5.Width = 68
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnsualoaisanpham)
        Me.GroupBox2.Controls.Add(Me.txtmotaloaisanpham)
        Me.GroupBox2.Controls.Add(Me.btnxoaloaisanpham)
        Me.GroupBox2.Controls.Add(Me.btnthemloaisanpham)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lsvloaisanpham)
        Me.GroupBox2.Controls.Add(Me.txttenloaisanpham)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtmaloaisanpham)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(407, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 467)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin loại sản phẩm"
        '
        'btnsualoaisanpham
        '
        Me.btnsualoaisanpham.Location = New System.Drawing.Point(267, 174)
        Me.btnsualoaisanpham.Name = "btnsualoaisanpham"
        Me.btnsualoaisanpham.Size = New System.Drawing.Size(75, 23)
        Me.btnsualoaisanpham.TabIndex = 5
        Me.btnsualoaisanpham.Text = "Sửa"
        Me.btnsualoaisanpham.UseVisualStyleBackColor = True
        '
        'txtmotaloaisanpham
        '
        Me.txtmotaloaisanpham.Location = New System.Drawing.Point(92, 87)
        Me.txtmotaloaisanpham.Multiline = True
        Me.txtmotaloaisanpham.Name = "txtmotaloaisanpham"
        Me.txtmotaloaisanpham.Size = New System.Drawing.Size(251, 81)
        Me.txtmotaloaisanpham.TabIndex = 2
        '
        'btnxoaloaisanpham
        '
        Me.btnxoaloaisanpham.Location = New System.Drawing.Point(186, 174)
        Me.btnxoaloaisanpham.Name = "btnxoaloaisanpham"
        Me.btnxoaloaisanpham.Size = New System.Drawing.Size(75, 23)
        Me.btnxoaloaisanpham.TabIndex = 4
        Me.btnxoaloaisanpham.Text = "Xóa"
        Me.btnxoaloaisanpham.UseVisualStyleBackColor = True
        '
        'btnthemloaisanpham
        '
        Me.btnthemloaisanpham.Location = New System.Drawing.Point(105, 174)
        Me.btnthemloaisanpham.Name = "btnthemloaisanpham"
        Me.btnthemloaisanpham.Size = New System.Drawing.Size(75, 23)
        Me.btnthemloaisanpham.TabIndex = 3
        Me.btnthemloaisanpham.Text = "Thêm"
        Me.btnthemloaisanpham.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Mô tả"
        '
        'lsvloaisanpham
        '
        Me.lsvloaisanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lsvloaisanpham.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsvloaisanpham.FullRowSelect = True
        Me.lsvloaisanpham.GridLines = True
        Me.lsvloaisanpham.Location = New System.Drawing.Point(3, 203)
        Me.lsvloaisanpham.Name = "lsvloaisanpham"
        Me.lsvloaisanpham.Size = New System.Drawing.Size(377, 261)
        Me.lsvloaisanpham.TabIndex = 1
        Me.lsvloaisanpham.UseCompatibleStateImageBehavior = False
        Me.lsvloaisanpham.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Mã loại"
        Me.ColumnHeader6.Width = 57
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tên loại"
        Me.ColumnHeader7.Width = 125
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Mô tả"
        Me.ColumnHeader8.Width = 190
        '
        'txttenloaisanpham
        '
        Me.txttenloaisanpham.Location = New System.Drawing.Point(92, 61)
        Me.txttenloaisanpham.Name = "txttenloaisanpham"
        Me.txttenloaisanpham.Size = New System.Drawing.Size(251, 20)
        Me.txttenloaisanpham.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Tên loại"
        '
        'txtmaloaisanpham
        '
        Me.txtmaloaisanpham.Location = New System.Drawing.Point(92, 35)
        Me.txtmaloaisanpham.Name = "txtmaloaisanpham"
        Me.txtmaloaisanpham.ReadOnly = True
        Me.txtmaloaisanpham.Size = New System.Drawing.Size(251, 20)
        Me.txtmaloaisanpham.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Mã loại"
        '
        'frm_SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 491)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_SanPham"
        Me.Text = "Quản Lý Sản Phẩm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsuasanpham As System.Windows.Forms.Button
    Friend WithEvents btnxoasanpham As System.Windows.Forms.Button
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttensanpham As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnthemsanpham As System.Windows.Forms.Button
    Friend WithEvents txtmasanpham As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lsvsanpham As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsualoaisanpham As System.Windows.Forms.Button
    Friend WithEvents txtmotaloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents btnxoaloaisanpham As System.Windows.Forms.Button
    Friend WithEvents btnthemloaisanpham As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lsvloaisanpham As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txttenloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmaloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
End Class
