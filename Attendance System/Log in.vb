Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Focus()
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
        ElseIf TxtUsername.Text = "Farrezs" And TxtPassword.Text = "23456" Then
            MsgBox("Login Berhasil", MsgBoxStyle.Information, "Akses Berhasil")
            FormMenuUtama.Show()
            Me.Hide()
        Else
            MsgBox("Kombinasi Username dan Password Salah!", MsgBoxStyle.Critical, "Silakan Cek Username dan Password")
            Call Bersih()
            TxtUsername.Focus()
        End If
    End Sub

    Sub Bersih()
        TxtUsername.Text = ""
        TxtPassword.Text = ""

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
        TxtPassword.Focus()
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TxtUsername.Text = "" And TxtPassword.Text = "" Then
                MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
            ElseIf TxtUsername.Text = "Farrezs" And TxtPassword.Text = "23456" Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Akses Berhasil")
                FormMenuUtama.Show()
                Me.Hide()
            Else
                MsgBox("Kombinasi Username dan Password Salah!", MsgBoxStyle.Critical, "Silakan Cek Username dan Password")
                Call Bersih()
                TxtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub TxtAbout_TextChanged(sender As Object, e As EventArgs)
        sender = MsgBox("Version 1.1")
    End Sub

    Private Sub LblAbout_Click(sender As Object, e As EventArgs) Handles LblAbout.Click
        sender = MsgBox("Version 1.1")
    End Sub
End Class