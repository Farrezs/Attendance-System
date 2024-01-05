Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FormAbsensi
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdDelete As New OleDbCommand
    Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Akademik.accdb"
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet

    Private Sub FormAbsensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = strConnectionString
        cnnOLEDB.Open()
        TampilData()
        ListBox1.Visible = False
        ButtonEnable()
    End Sub

    Sub TampilData()
        ADP = New OleDbDataAdapter("SELECT * FROM Kehadiran ORDER BY NIM", cnnOlEDB)
        DS = New DataSet
        ADP.Fill(DS, "Tabel1")
        DataGridView1.DataSource = DS.Tables("Tabel1")
    End Sub

    Sub ButtonEnable()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtNIM.Enabled = True
    End Sub

    Sub ButtonDisable()
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        txtNIM.Enabled = False
    End Sub

    Sub IsiList()
        Dim query As String
        query = "SELECT Nama_Mhs FROM Master_Mahasiswa WHERE Nama_Mhs LIKE '" & txtNama.Text & "%' ORDER BY NIM "
        ADP = New OleDbDataAdapter(query, cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "List")
        ListBox1.Items.Clear()
        For i = 0 To DS.Tables("List").Rows.Count - 1
            ListBox1.Items.Add(DS.Tables("List").Rows(i).Item("Nama_Mhs").ToString)
        Next
    End Sub

    Sub IsiNim()
        Dim query As String
        query = "SELECT Nama_Mhs FROM Master_Mahasiswa WHERE NIM = '" & txtNIM.Text & "'"
        ADP = New OleDbDataAdapter(query, cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "NIM")
        For i = 0 To DS.Tables("NIM").Rows.Count - 1
            txtNama.Text = (DS.Tables("NIM").Rows(i).Item("Nama_Mhs").ToString)
        Next
        ListBox1.Visible = False
    End Sub

    Sub IsiKelas()
        Dim query As String
        query = "SELECT Kelas FROM Kelas  WHERE NIM = '" & txtNIM.Text & "'"
        ADP = New OleDbDataAdapter(query, cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "Kelas")
        txtKelas.Text = ""
        For i = 0 To DS.Tables("Kelas").Rows.Count - 1
            txtKelas.Text = (DS.Tables("Kelas").Rows(i).Item("Kelas").ToString)
        Next
        ListBox1.Visible = False
    End Sub

    Sub Bersih()
        txtNIM.Text = ""
        txtNama.Text = ""
        txtKelas.Text = ""
        Tgl.Text = ""
        txtSemester.Text = ""
        txtTA.Text = ""
        txtIzin.Text = ""
        txtAlpha.Text = ""
        txtSakit.Text = ""
    End Sub

    Sub GetData(e)
        Dim NIM As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim Semester As Object = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Dim TA As Object = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Dim Tanggal As Object = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Dim Izin As Object = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Dim Alpha As Object = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Dim Sakit As Object = DataGridView1.Rows(e.RowIndex).Cells(6).Value

        txtNIM.Text = CType(NIM, String)
        txtSemester.Text = CType(Semester, String)
        txtTA.Text = CType(TA, String)
        Tgl.Text = CType(Tanggal, String)
        txtIzin.Text = CType(Izin, String)
        txtAlpha.Text = CType(Alpha, String)
        txtSakit.Text = CType(Sakit, String)
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ListBox1.Location = New Point(txtNama.Location.X, txtNama.Location.Y + 20)
        ListBox1.BringToFront()
        ListBox1.Visible = True
        IsiList()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        txtNama.Text = ListBox1.SelectedItem
        ListBox1.Visible = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        GetData(e)
        ButtonDisable()
    End Sub

    Private Sub DataGridView1_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContextMenuStripChanged
        GetData(e)
        ButtonDisable()
    End Sub

    Private Sub txtNIM_TextChanged(sender As Object, e As EventArgs) Handles txtNIM.TextChanged
        If txtNIM.Text.Length() = 12 Then
            IsiNim()
            IsiKelas()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtNIM.Text <> "" And txtNama.Text <> "" And txtKelas.Text <> "" And Tgl.Text <> "" And txtSemester.Text <> "" And txtTA.Text <> "" And txtIzin.Text <> "" And txtSakit.Text <> "" And txtSakit.Text <> "" Then
            Try
                cmdInsert.CommandText = "INSERT INTO Kehadiran " & "(NIM, Semester, Tahun_Akademik, Tanggal, Izin, Sakit, Alpha)" &
                    "VALUES(@NIM, @Semester, @TA, @Tgl, @Izin, @Alpha, @Sakit)"

                cmdInsert.Parameters.AddWithValue("@NIM", Me.txtNIM.Text)
                cmdInsert.Parameters.AddWithValue("@Semester", Me.txtSemester.Text)
                cmdInsert.Parameters.AddWithValue("@TA", Me.txtTA.Text)
                cmdInsert.Parameters.AddWithValue("@Tgl", Me.Tgl.Value.Date)
                cmdInsert.Parameters.AddWithValue("@Izin", Me.txtIzin.Text)
                cmdInsert.Parameters.AddWithValue("@Alpha", Me.txtAlpha.Text)
                cmdInsert.Parameters.AddWithValue("@Sakit", Me.txtSakit.Text)

                cmdInsert.CommandType = CommandType.Text
                cmdInsert.Connection = cnnOLEDB
                cmdInsert.ExecuteNonQuery()
                MsgBox("Record inserted")
                Bersih()
                TampilData()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Masukkan data secara lengkap")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtNIM.Text <> "" And txtNama.Text <> "" And txtKelas.Text <> "" And Tgl.Text <> "" And txtSemester.Text <> "" And txtTA.Text <> "" And txtIzin.Text <> "" And txtSakit.Text <> "" And txtSakit.Text <> "" Then
            Try
                ADP = New OleDbDataAdapter("UPDATE Kehadiran SET NIM = '" & txtNIM.Text &
                    "', Semester = '" & txtSemester.Text & "', Tahun_Akademik = '" & txtTA.Text & "', Tanggal ='" & Tgl.Value.ToString & "', Izin = '" & txtIzin.Text &
                    "', Sakit = '" & txtSakit.Text & "', Alpha = '" & txtAlpha.Text & "' WHERE NIM = '" & txtNIM.Text & "' ", cnnOLEDB)
                ADP.Fill(DS, "Kehadiran")
                MsgBox("Record Updated")
                TampilData()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            cmdDelete.CommandText = "DELETE FROM Kehadiran WHERE NIM=@NIM"
            cmdDelete.Parameters.AddWithValue("@NIM", Me.txtNIM.Text)
            cmdDelete.CommandType = CommandType.Text
            cmdDelete.Connection = cnnOLEDB
            cmdDelete.ExecuteNonQuery()
            MsgBox("Record Deleted")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cmdDelete.Dispose()
        TampilData()
        Bersih()
    End Sub

    Private Sub FormAbsensi_Click(sender As Object, e As EventArgs) Handles Me.Click
        ListBox1.Visible = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Bersih()
        ButtonEnable()
        ListBox1.Visible = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        sender = MsgBox("Version 1.1")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class