Public Class MenuUtama

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelected1.Click

    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = True
    End Sub

    Private Sub btnDatamaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatamaster.Click
        ' Button dipilih
        lblSelected1.Visible = True
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False
        'Tampilkan Panel Konten
        pnlDataMaster.Visible = True
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
    End Sub

    Private Sub btnTransaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksi.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = True
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False
        'Tampilkan Panel Konten
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = True
        pnlLaporan.Visible = False
    End Sub

    Private Sub btnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporan.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = True
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False
        'Tampilkan Panel Konten
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = True
    End Sub

    Private Sub btnLainnya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLainnya.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = True
        lblSelected5.Visible = False
        lblSelected6.Visible = False
        'Tampilkan Panel Konten
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlLainnya.Visible = True
    End Sub

    Private Sub btnTentang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTentang.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = True
        lblSelected6.Visible = False
        'Tampilkan Panel Konten
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlLainnya.Visible = False
        pnlTentangApl.Visible = True
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKategori.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRak.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click

    End Sub

    Private Sub pnlContent1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlDataMaster.Paint

    End Sub
End Class
