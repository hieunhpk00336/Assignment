<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhoadon))
        Me.lsvhoadon = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvkhachhang = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.txttenkhachhang = New System.Windows.Forms.TextBox()
        Me.txtngaylap = New System.Windows.Forms.TextBox()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtthem = New System.Windows.Forms.Button()
        Me.txtsua = New System.Windows.Forms.Button()
        Me.txtxoa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsvhoadon
        '
        Me.lsvhoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvhoadon.FullRowSelect = True
        Me.lsvhoadon.GridLines = True
        Me.lsvhoadon.Location = New System.Drawing.Point(12, 32)
        Me.lsvhoadon.Name = "lsvhoadon"
        Me.lsvhoadon.Size = New System.Drawing.Size(516, 412)
        Me.lsvhoadon.TabIndex = 0
        Me.lsvhoadon.UseCompatibleStateImageBehavior = False
        Me.lsvhoadon.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã Hóa Đơn"
        Me.ColumnHeader1.Width = 86
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên Khách Hàng"
        Me.ColumnHeader2.Width = 149
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ngày Lập"
        Me.ColumnHeader3.Width = 108
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mô Tả"
        Me.ColumnHeader4.Width = 168
        '
        'lsvkhachhang
        '
        Me.lsvkhachhang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvkhachhang.FullRowSelect = True
        Me.lsvkhachhang.GridLines = True
        Me.lsvkhachhang.Location = New System.Drawing.Point(558, 32)
        Me.lsvkhachhang.Name = "lsvkhachhang"
        Me.lsvkhachhang.Size = New System.Drawing.Size(226, 248)
        Me.lsvkhachhang.TabIndex = 1
        Me.lsvkhachhang.UseCompatibleStateImageBehavior = False
        Me.lsvkhachhang.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Mã Khách Hàng"
        Me.ColumnHeader5.Width = 95
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tên Khách Hàng"
        Me.ColumnHeader6.Width = 127
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 450)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Hóa Đơn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(546, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 284)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông Tin Khách Hàng"
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Location = New System.Drawing.Point(640, 302)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.ReadOnly = True
        Me.txtmahoadon.Size = New System.Drawing.Size(157, 20)
        Me.txtmahoadon.TabIndex = 4
        '
        'txttenkhachhang
        '
        Me.txttenkhachhang.Location = New System.Drawing.Point(640, 328)
        Me.txttenkhachhang.Name = "txttenkhachhang"
        Me.txttenkhachhang.Size = New System.Drawing.Size(157, 20)
        Me.txttenkhachhang.TabIndex = 4
        '
        'txtngaylap
        '
        Me.txtngaylap.Location = New System.Drawing.Point(640, 354)
        Me.txtngaylap.Name = "txtngaylap"
        Me.txtngaylap.Size = New System.Drawing.Size(157, 20)
        Me.txtngaylap.TabIndex = 4
        Me.txtngaylap.Text = "12-31-2014"
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(640, 380)
        Me.txtmota.Multiline = True
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(157, 40)
        Me.txtmota.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(566, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(545, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(581, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ngày Lập"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(596, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mô Tả"
        '
        'txtthem
        '
        Me.txtthem.Location = New System.Drawing.Point(558, 434)
        Me.txtthem.Name = "txtthem"
        Me.txtthem.Size = New System.Drawing.Size(75, 23)
        Me.txtthem.TabIndex = 6
        Me.txtthem.Text = "Thêm"
        Me.txtthem.UseVisualStyleBackColor = True
        '
        'txtsua
        '
        Me.txtsua.Location = New System.Drawing.Point(640, 434)
        Me.txtsua.Name = "txtsua"
        Me.txtsua.Size = New System.Drawing.Size(75, 23)
        Me.txtsua.TabIndex = 6
        Me.txtsua.Text = "Sửa"
        Me.txtsua.UseVisualStyleBackColor = True
        '
        'txtxoa
        '
        Me.txtxoa.Location = New System.Drawing.Point(721, 434)
        Me.txtxoa.Name = "txtxoa"
        Me.txtxoa.Size = New System.Drawing.Size(75, 23)
        Me.txtxoa.TabIndex = 6
        Me.txtxoa.Text = "Xóa"
        Me.txtxoa.UseVisualStyleBackColor = True
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(801, 469)
        Me.Controls.Add(Me.txtxoa)
        Me.Controls.Add(Me.txtsua)
        Me.Controls.Add(Me.txtthem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txtngaylap)
        Me.Controls.Add(Me.txttenkhachhang)
        Me.Controls.Add(Me.txtmahoadon)
        Me.Controls.Add(Me.lsvkhachhang)
        Me.Controls.Add(Me.lsvhoadon)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmhoadon"
        Me.Text = "Hóa Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvhoadon As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvkhachhang As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents txttenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtngaylap As System.Windows.Forms.TextBox
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtthem As System.Windows.Forms.Button
    Friend WithEvents txtsua As System.Windows.Forms.Button
    Friend WithEvents txtxoa As System.Windows.Forms.Button
End Class
