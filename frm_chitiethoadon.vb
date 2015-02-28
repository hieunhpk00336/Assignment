Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmchitiethoadon
    Dim ketnoi As New SqlConnection("workstation id=hieunhpk00336.mssql.somee.com;packet size=4096;user id=hieunhpk;pwd=hieunhpk00336;data source=hieunhpk00336.mssql.somee.com;persist security info=False;initial catalog=hieunhpk00336")
    Public Property Value As String
    Private Sub frmchitiethoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddulieuhoadon()
        loaddulieusanpham()
        loaddulieuchitiethoadon()
    End Sub
    Private Sub thucthi(str As String)
        ketnoi.Open()
        Dim com As New SqlCommand(str, ketnoi)
        com.ExecuteNonQuery()
        ketnoi.Close()
    End Sub
    Private Sub loaddulieuhoadon()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from HoaDon left join KhachHang on HoaDon.MaKH_HD = KhachHang.MaKH", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubanghoadon As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubanghoadon)
        ketnoi.Close()
        lsvtthd.Items.Clear()

        For Each cot As DataRow In dulieubanghoadon.Rows
            lsvtthd.Items.Add(cot("MaHD").ToString())
            lsvtthd.Items(i).SubItems.Add(cot("TenKH").ToString())
            lsvtthd.Items(i).SubItems.Add(cot("NgaylapHD").ToString())
            i += 1
        Next
    End Sub
    Private Sub loaddulieusanpham()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from SanPham left join LoaiSanPham on SanPham.MaLsp_SP = LoaiSanPham.MaLsp", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubangsanpham As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubangsanpham)
        ketnoi.Close()
        lsvttsp.Items.Clear()

        For Each cot As DataRow In dulieubangsanpham.Rows
            lsvttsp.Items.Add(cot("MaSp").ToString())
            lsvttsp.Items(i).SubItems.Add(cot("TenSp").ToString())
            lsvttsp.Items(i).SubItems.Add(cot("MotaSP").ToString())
            i += 1
        Next
    End Sub
    Private Sub loaddulieuchitiethoadon()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from ChiTietHD left join HoaDon on ChiTietHD.MaHD_CTHD = HoaDon.MaHD left join KhachHang on HoaDon.MaKH_HD = KhachHang.MaKH left join SanPham on SanPham.MaSp = ChiTietHD.MaSp_CTHD", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubangsanpham As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubangsanpham)
        ketnoi.Close()
        lsvcthd.Items.Clear()

        For Each cot As DataRow In dulieubangsanpham.Rows
            lsvcthd.Items.Add(cot("MaCTHD").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("TenKH").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("MaHD").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("TenSp").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("Soluong").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("Dongia").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("NgaylapHD").ToString())
            i += 1
        Next
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try

            Dim macthd As String = txtmacthd.Text
            Dim mahd As String = txtmahoadon.Text
            Dim masp As String = txtmasanpham.Text
            Dim soluong As String = txtsoluong.Text
            Dim dongia As String = txtdongia.Text

            Dim truyvan1 As String = "insert into ChiTietHD (MaHD_CTHD,Masp_CTHD,Soluong,DonGia) Values(N'" + mahd + "',N'" + masp + "',N'" + soluong + "',N'" + dongia + "')"
            thucthi(truyvan1)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieuchitiethoadon()


            txtmahoadon.Text = ""
            txtmasanpham.Text = ""
            txtdongia.Text = ""
            txtsoluong.Text = ""

        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtmahoadon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmahoadon.KeyPress
        Try
            If e.KeyChar = Chr(8) Then Exit Sub
            Dim s As String = e.KeyChar
            Dim f As Short = s / 1 'tạo lỗi
        Catch ex As Exception
            e.KeyChar = ""
        End Try
    End Sub

    Private Sub txtmasanpham_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmasanpham.KeyPress
        Try
            If e.KeyChar = Chr(8) Then Exit Sub
            Dim s As String = e.KeyChar
            Dim f As Short = s / 1 'tạo lỗi
        Catch ex As Exception
            e.KeyChar = ""
        End Try
    End Sub

    Private Sub txtsoluong_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsoluong.KeyPress
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

    Private Sub lsvcthd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvcthd.SelectedIndexChanged
        For Each dsachsp As ListViewItem In lsvcthd.SelectedItems
            txtmacthd.Text = dsachsp.SubItems(0).Text
            txtmahoadon.Text = dsachsp.SubItems(2).Text
            txtmasanpham.Text = dsachsp.SubItems(3).Text
            txtsoluong.Text = dsachsp.SubItems(4).Text
            txtdongia.Text = dsachsp.SubItems(5).Text
        Next
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try

            Dim macthd As String = txtmacthd.Text

            ketnoi.Open()
            Dim xoakh As New SqlCommand(" DELETE FROM ChiTietHD WHERE MaCTHD = '" + macthd + "'", ketnoi)
            xoakh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieuchitiethoadon()
            txtmacthd.Text = ""
            txtmahoadon.Text = ""
            txtmasanpham.Text = ""
            txtdongia.Text = ""
            txtsoluong.Text = ""

        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click
        Try
            Dim macthd As String = txtmacthd.Text
            Dim mahd As String = txtmahoadon.Text
            Dim masp As String = txtmasanpham.Text
            Dim soluong As String = txtsoluong.Text
            Dim dongia As String = txtdongia.Text

            ketnoi.Open()
            Dim sualsp As New SqlCommand("update ChiTietHD set MaHD_CTHD = '" + mahd + "', Masp_CTHD = '" + masp + "', Soluong = '" + soluong + "', DonGia = '" + dongia + "' where MaCTHD = '" + macthd + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieuchitiethoadon()
            txtmacthd.Text = ""
            txtmahoadon.Text = ""
            txtmasanpham.Text = ""
            txtdongia.Text = ""
            txtsoluong.Text = ""
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class