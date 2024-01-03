Imports System.IO

Public Class FormMenuUtama
    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Arr(3, 1) As String
        Arr(0, 0) = "NAMA"
        Arr(0, 1) = "NIM"
        Arr(1, 0) = "JENIS KELAMIN"
        Arr(1, 1) = "PROGRAM STUDI"
        Arr(2, 0) = "Laki - laki"
        Arr(2, 1) = "Perempuan"
        Arr(3, 0) = "Teknik Informatika"
        Arr(3, 1) = "Sistem Informasi"
        ListView1.GridLines = True
        ListView1.View = View.Details

        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(Arr(baris, kolom), 120)
            Next kolom
        Next baris

        For baris = 2 To 2
            For kolom = 0 To 1
                cmbJenisKelamin.Items.Add(Arr(baris, kolom))
            Next kolom
        Next baris

        For baris = 3 To 3
            For kolom = 0 To 1
                cmbProgramStudi.Items.Add(Arr(baris, kolom))
            Next kolom
        Next baris
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim Arr(3) As String
        Arr(0) = TxtNama.Text
        Arr(1) = TxtNim.Text
        Arr(2) = cmbJenisKelamin.Text
        Arr(3) = cmbProgramStudi.Text

        Dim listitem = New ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))
        TxtNim.Text = TxtNim.Text + 1
        TxtNim.Focus()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtNama.Text = ""
        TxtNim.Text = ""
        cmbJenisKelamin.Text = ""
        cmbProgramStudi.Text = ""
    End Sub
End Class