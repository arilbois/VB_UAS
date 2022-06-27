Imports System.Data.OleDb
Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.ReportAppServer
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.Windows
Public Class Form1
    Dim da As OleDbDataAdapter
    Dim dset As DataSet
    Private crv As Object
    Dim jenisKelamin, Sprodi, Snama, StempatLahir, Sagama, Salamat, Semail, tanggal As String
    Dim Snop, SnoHP As Int64


    Sub View()
        da = New OleDbDataAdapter(" SELECT * FROM siswa", koneksi)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        diskonek()

    End Sub

    Sub clear()
        nop.Clear()
        nama.Clear()
        TempatLahir.Clear()
        alamat.Clear()
        noHP.Clear()
        email.Clear()
    End Sub
    Sub Var()
        Snop = Val(nop.Text)
        Sprodi = prodi.Text
        Snama = nama.Text
        StempatLahir = TempatLahir.Text
        tanggal = TanggalLahir.Text
        Sagama = agama.Text
        Salamat = alamat.Text
        SnoHP = Val(noHP.Text)
        Semail = email.Text
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles TanggalLahir.ValueChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        View()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Var()

        If find = False Then
            ' simpan data
            konek()
            cmd = New OleDbCommand(" INSERT INTO siswa VALUES('" & Snop & "','" & Sprodi & "','" & Snama & "','" & jenisKelamin & "','" & StempatLahir & "','" & tanggal & "','" & Sagama & "','" & Salamat & "','" & SnoHP & "','" & Semail & "')", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
            View()
            clear()
            diskonek()
        Else
            ' edit data
            konek()
            cmd = New OleDbCommand(" UPDATE siswa set nama = '" & Snama & "',prodi = '" & Sprodi & "',jenisKelamin = '" & jenisKelamin & "',tempatLahir = '" & StempatLahir & "',tanggalLahir = '" & tanggal & "',agama = '" & Sagama & "',alamat = '" & Salamat & "',noHP = '" & SnoHP & "', email = '" & Semail & "' WHERE nop = '" & Snop & "' ", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah")
            View()
            clear()
            diskonek()
        End If
    End Sub

    Private Sub noHP_TextChanged(sender As Object, e As EventArgs) Handles noHP.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles nop.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nop.KeyPress
        Var()
        If e.KeyChar = Chr(13) Then

            konek()
            cmd = New OleDbCommand("SELECT * FROM siswa WHERE nop= '" & Snop & "' ", koneksi)
            dr = cmd.ExecuteReader
            If dr.Read Then
                prodi.Text = dr.Item(1)
                nama.Text = dr.Item(2)
                TempatLahir.Text = dr.Item(4)
                agama.Text = dr.Item(6)
                alamat.Text = dr.Item(7)
                noHP.Text = dr.Item(8)
                email.Text = dr.Item(9)
                find = True

            Else
                MsgBox("Maaf, Data tidak ditemukan!")
                find = False
            End If

            diskonek()


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Var()
        Dim pilih = MessageBox.Show("Hapus Data?", "Perhatian!", MessageBoxButtons.YesNo)
        If pilih = vbYes Then
            konek()
            cmd = New OleDbCommand("DELETE FROM siswa WHERE nop = '" & Snop & "' ", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil dihapus!")
            diskonek()

            View()
            clear()


        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub rd1_CheckedChanged(sender As Object, e As EventArgs) Handles rd1.CheckedChanged
        If rd1.Checked = True Then
            jenisKelamin = "Laki - Laki"
        End If
    End Sub

    Private Sub rd2_CheckedChanged(sender As Object, e As EventArgs) Handles rd2.CheckedChanged
        If rd2.Checked = True Then
            jenisKelamin = "Perempuan"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        clear()
    End Sub
End Class
