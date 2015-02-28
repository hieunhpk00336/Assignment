Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmhoadon
    Dim ketnoi As New SqlConnection("workstation id=hieunhpk00336.mssql.somee.com;packet size=4096;user id=hieunhpk;pwd=hieunhpk00336;data source=hieunhpk00336.mssql.somee.com;persist security info=False;initial catalog=hieunhpk00336")
    Public Property Value As String
    Private Sub frmhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddulieuhoadon()
        loaddulieukhachhang()
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
        lsvhoadon.Items.Clear()

        For Each cot As DataRow In dulieubanghoadon.Rows
            lsvhoadon.Items.Add(cot("MaHD").ToString())
            lsvhoadon.Items(i).SubItems.Add(cot("TenKH").ToString())
            lsvhoadon.Items(i).SubItems.Add(cot("NgaylapHD").ToString())
            lsvhoadon.Items(i).SubItems.Add(cot("MotaHD").ToString())
            i += 1
        Next
    End Sub
    Private Sub loaddulieukhachhang()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from KhachHang", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubangkhachhang As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubangkhachhang)
        ketnoi.Close()
        lsvkhachhang.Items.Clear()

        For Each cot As DataRow In dulieubangkhachhang.Rows
            lsvkhachhang.Items.Add(cot("MaKH").ToString())
            lsvkhachhang.Items(i).SubItems.Add(cot("TenKH").ToString())
            i += 1
        Next
    End Sub

    Private Sub txttenkhachhang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttenkhachhang.KeyPress
        Try
            If e.KeyChar = Chr(8) Then Exit Sub
            Dim s As String = e.KeyChar
            Dim f As Short = s / 1 'tạo lỗi
        Catch ex As Exception
            e.KeyChar = ""
        End Try
    End Sub

    Private Sub txtthem_Click(sender As Object, e As EventArgs) Handles txtthem.Click
        Try


            Dim mahoadon As String = txtmahoadon.Text
            Dim makh As String = txttenkhachhang.Text
            Dim ngaylap As String = txtngaylap.Text
            Dim mota As String = txtmota.Text

            Dim truyvan1 As String = "insert into HoaDon (MaKH_HD,NgaylapHD,MotaHD) Values(N'" + makh + "',N'" + ngaylap + "',N'" + mota + "')"
            thucthi(truyvan1)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieuhoadon()

            txttenkhachhang.Text = ""
            txtngaylap.Text = ""
            txtmota.Text = ""


        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub lsvhoadon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvhoadon.SelectedIndexChanged
        For Each dsachsp As ListViewItem In lsvhoadon.SelectedItems
            txtmahoadon.Text = dsachsp.SubItems(0).Text
            txttenkhachhang.Text = dsachsp.SubItems(1).Text
            txtngaylap.Text = dsachsp.SubItems(2).Text
            txtmota.Text = dsachsp.SubItems(3).Text

        Next
    End Sub

    Private Sub txtsua_Click(sender As Object, e As EventArgs) Handles txtsua.Click
        Try

            Dim mahoadon As String = txtmahoadon.Text
            Dim makh As String = txttenkhachhang.Text
            Dim ngaylap As String = txtngaylap.Text
            Dim mota As String = txtmota.Text

            ketnoi.Open()
            Dim sualsp As New SqlCommand("update HoaDon set MaKH_HD = N'" + makh + "', NgaylapHD = '" + ngaylap + "', MotaHD = N'" + mota + "' where MaHD = '" + mahoadon + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieuhoadon()
            txttenkhachhang.Text = ""
            txtngaylap.Text = ""
            txtmota.Text = ""
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtxoa_Click(sender As Object, e As EventArgs) Handles txtxoa.Click
        Try

            Dim mahd As String = txtmahoadon.Text

            ketnoi.Open()
            Dim xoakh As New SqlCommand(" DELETE FROM HoaDon WHERE MaHD = '" + mahd + "'", ketnoi)
            xoakh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieuhoadon()
            txttenkhachhang.Text = ""
            txtngaylap.Text = ""
            txtmota.Text = ""
        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class