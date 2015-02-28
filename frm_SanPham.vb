Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frm_SanPham
    Dim ketnoi As New SqlConnection("workstation id=hieunhpk00336.mssql.somee.com;packet size=4096;user id=hieunhpk;pwd=hieunhpk00336;data source=hieunhpk00336.mssql.somee.com;persist security info=False;initial catalog=hieunhpk00336")
    Public Property Value As String

    Private Sub frm_SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddulieusanpham()
        loaddulieuloaisanpham()


    End Sub
  
    Private Sub loaddulieusanpham()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from SanPham left join LoaiSanPham on SanPham.MaLsp_SP = LoaiSanPham.MaLsp", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubangsanpham As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubangsanpham)
        ketnoi.Close()
        lsvsanpham.Items.Clear()

        For Each cot As DataRow In dulieubangsanpham.Rows
            lsvsanpham.Items.Add(cot("MaSp").ToString())
            lsvsanpham.Items(i).SubItems.Add(cot("TenSp").ToString())
            lsvsanpham.Items(i).SubItems.Add(cot("TenLsp").ToString())
            lsvsanpham.Items(i).SubItems.Add(cot("DongiaSP").ToString())
            lsvsanpham.Items(i).SubItems.Add(cot("MotaSP").ToString())
            i += 1
        Next
    End Sub
    Private Sub loaddulieuloaisanpham()
        ketnoi.Open()
        Dim truyvanlsp As New SqlCommand("select * from loaisanpham", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvanlsp)
        Dim dulieubanglsp As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubanglsp)
        ketnoi.Close()
        lsvloaisanpham.Items.Clear()

        For Each cot As DataRow In dulieubanglsp.Rows
            lsvloaisanpham.Items.Add(cot("MaLsp").ToString())
            lsvloaisanpham.Items(i).SubItems.Add(cot("TenLsp").ToString())
            lsvloaisanpham.Items(i).SubItems.Add(cot("MotaLsp").ToString())
            i += 1
        Next
    End Sub
    Private Sub thucthi(str As String)
        ketnoi.Open()
        Dim com As New SqlCommand(str, ketnoi)
        com.ExecuteNonQuery()
        ketnoi.Close()
    End Sub
    Private Sub btnthemloaisanpham_Click(sender As Object, e As EventArgs) Handles btnthemloaisanpham.Click
        Try


            Dim TENLOAISANPHAM As String = txttenloaisanpham.Text
            Dim MOTA As String = txtmotaloaisanpham.Text

            Dim truyvan1 As String = "insert into LOAISANPHAM (TenLsp,MotaLsp) Values(N'" + TENLOAISANPHAM + "',N'" + MOTA + "')"
            thucthi(truyvan1)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieuloaisanpham()

            txttenloaisanpham.Text = ""
            txtmotaloaisanpham.Text = ""

        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub lsvloaisanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvloaisanpham.SelectedIndexChanged
        For Each dsachlsp As ListViewItem In lsvloaisanpham.SelectedItems
            txtmaloaisanpham.Text = dsachlsp.SubItems(0).Text
            txttenloaisanpham.Text = dsachlsp.SubItems(1).Text
            txtmotaloaisanpham.Text = dsachlsp.SubItems(2).Text

        Next
    End Sub

    Private Sub btnxoaloaisanpham_Click(sender As Object, e As EventArgs) Handles btnxoaloaisanpham.Click

        Try

            Dim MALOAISANPHAM As String = txtmaloaisanpham.Text

            ketnoi.Open()
            Dim xoalsp As New SqlCommand(" DELETE FROM LoaiSanPham WHERE MaLsp = '" + MALOAISANPHAM + "'", ketnoi)
            xoalsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieuloaisanpham()
            txtmaloaisanpham.Text = ""
            txttenloaisanpham.Text = ""
            txtmotaloaisanpham.Text = ""
        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnsualoaisanpham_Click(sender As Object, e As EventArgs) Handles btnsualoaisanpham.Click
        Try
            Dim maloaisanpham As String = txtmaloaisanpham.Text
            Dim tenloaisanpham As String = txttenloaisanpham.Text
            Dim motaloaisanpham As String = txtmotaloaisanpham.Text
            ketnoi.Open()
            Dim sualsp As New SqlCommand("update LoaiSanPham set TenLsp = N'" + tenloaisanpham + "', MotaLsp = '" + motaloaisanpham + "' where MaLsp = '" + maloaisanpham + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieuloaisanpham()
            txtmaloaisanpham.Text = ""
            txttenloaisanpham.Text = ""
            txtmotaloaisanpham.Text = ""
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    

    Private Sub btnthemsanpham_Click(sender As Object, e As EventArgs) Handles btnthemsanpham.Click
        Try


            Dim TENSANPHAM As String = txttensanpham.Text
            Dim motasp As String = txtmota.Text
            Dim dongia As String = txtdongia.Text
            Dim maloaisp As String = txtmaloai.Text

            Dim truyvan2 As String = "insert into SANPHAM (TenSp,MaLsp_SP,DongiaSP,MotaSP) Values(N'" + TENSANPHAM + "','" + maloaisp + "','" + dongia + "',N'" + motasp + "')"
            thucthi(truyvan2)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieusanpham()
            txtmasanpham.Text = ""
            txttensanpham.Text = ""
            txtmota.Text = ""
            txtmaloai.Text = ""
            txtdongia.Text = ""

        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công, Vui Lòng Kiểm Tra Lại Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnxoasanpham_Click(sender As Object, e As EventArgs) Handles btnxoasanpham.Click
        Try

            Dim MASANPHAM As String = txtmasanpham.Text

            ketnoi.Open()
            Dim xoasp As New SqlCommand(" DELETE FROM SanPham WHERE MaSP = '" + MASANPHAM + "'", ketnoi)
            xoasp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieusanpham()
            txtmasanpham.Text = ""
            txttensanpham.Text = ""
            txtmota.Text = ""
            txtmaloai.Text = ""
            txtdongia.Text = ""
        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub lsvsanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvsanpham.SelectedIndexChanged
        For Each dsachsp As ListViewItem In lsvsanpham.SelectedItems
            txtmasanpham.Text = dsachsp.SubItems(0).Text
            txttensanpham.Text = dsachsp.SubItems(1).Text
            txtmaloai.Text = dsachsp.SubItems(2).Text
            txtdongia.Text = dsachsp.SubItems(3).Text
            txtmota.Text = dsachsp.SubItems(4).Text
        Next
    End Sub

    Private Sub btnsuasanpham_Click(sender As Object, e As EventArgs) Handles btnsuasanpham.Click
        Try
            Dim masp As String = txtmasanpham.Text
            Dim TENSANPHAM As String = txttensanpham.Text
            Dim maloaisp As String = txtmaloai.Text
            Dim dongia As String = txtdongia.Text
            Dim motasp As String = txtmota.Text

            ketnoi.Open()
            Dim sualsp As New SqlCommand("update SanPham set TenSP = N'" + TENSANPHAM + "', MaLsp_SP = '" + maloaisp + "', DongiaSP = '" + dongia + "', MotaSP = '" + motasp + "' where MaSp = '" + masp + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieusanpham()
            txtmasanpham.Text = ""
            txttensanpham.Text = ""
            txtmota.Text = ""
            txtmaloai.Text = ""
            txtdongia.Text = ""
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtmaloai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmaloai.KeyPress
        Try
            If e.KeyChar = Chr(8) Then Exit Sub
            Dim s As String = e.KeyChar
            Dim f As Short = s / 1 'tạo lỗi
        Catch ex As Exception
            e.KeyChar = ""
        End Try
    End Sub

    Private Sub txtdongia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdongia.KeyPress
        Try
            If e.KeyChar = Chr(8) Then Exit Sub
            Dim s As String = e.KeyChar
            Dim f As Short = s / 1 'tạo lỗi
        Catch ex As Exception
            e.KeyChar = ""
        End Try
    End Sub
End Class