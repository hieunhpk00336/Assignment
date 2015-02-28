Public Class frm_main

    Private Sub BánHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BánHàngToolStripMenuItem.Click
        Dim banhang = New frm_BanHang()
        banhang.MdiParent = Me
        banhang.Show()
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_login.ShowDialog()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        Dim sanpham = New frm_SanPham()
        sanpham.MdiParent = Me
        sanpham.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        If MsgBox("Bạn Chắc Chắn Sẽ Thoát Chương Trình ?", MsgBoxStyle.OkCancel, "Thông Báo") = MsgBoxResult.Ok Then
            Application.Exit()
        Else

        End If
    End Sub
    Private Sub ThoátToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        Dim sanpham = New frmhoadon()
        sanpham.MdiParent = Me
        sanpham.Show()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        Dim sanpham = New frmchitiethoadon()
        sanpham.MdiParent = Me
        sanpham.Show()
    End Sub
End Class