Imports System.Data.SqlClient
Public Class Management_Murid
    Private Sub Management_Murid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()


    End Sub
    Sub tampil()
        njir()

        ds = New DataSet
        query = "SELECT Nama,Alamat,Jenis_kelamin,Tanggal_lahir,No_hp FROM Murid"
        da = New SqlDataAdapter(query, conn)
        da.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)



    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs)
        cmd = New SqlCommand
        cmd.Connection = conn
        query = "INSERT INTO Murid Values('" & txt_nama.Text & "','" & txt_alamat.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Value & "','" & txt_nohp.Text & "')"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        tampil()

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs)
        cmd = New SqlCommand
        cmd.Connection = conn
        query = "Update Murid Set Nama='" & txt_nama.Text & "',Alamat='" & txt_alamat.Text & "',Jenis_kelamin='" & ComboBox1.Text & "',Tanggal_lahir='" & DateTimePicker1.Value & "',No_hp='" & txt_nohp.Text & "'WHERE IDMurid='" & txt_idmurid.Text & "'"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        tampil()
        MsgBox("Data Berhasil Di Update")
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs)
        cmd = New SqlCommand
        cmd.Connection = conn
        query = "DELETE FROM Murid WHERE Nama='" & txt_nama.Text & "')"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        tampil()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        'Coding Klik Datagrid Tampil
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txt_nama.Text = DataGridView1.Item(0, i).Value
        txt_alamat.Text = DataGridView1.Item(1, i).Value
        ComboBox1.Text = DataGridView1.Item(2, i).Value
        DateTimePicker1.Text = DataGridView1.Item(3, i).Value
        txt_nohp.Text = DataGridView1.Item(4, i).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_tambah.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cmd = New SqlCommand
        cmd.Connection = conn
        query = "INSERT INTO NAMA TABLE VALUES ('" & txt_nama.Text & "','"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
    End Sub

    Sub bersih()
        txt_nama.Text = ""
        txt_alamat.Text = ""
        txt_nohp.Text = ""
        ComboBox1.Text = ""
    End Sub

    Sub tampildata()
        njir()
        ds = New DataSet
        query = "SELECT * FROM Guru"
        da = New SqlDataAdapter(query, conn)
        da.Fill(ds)


        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Anda Yakin Mau Menghapus Data Ini ?", vbInformation + vbYesNo) = vbYes Then
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "DELETE FROM Teacher WHERE ID=" & txt_alamat.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Simpan")
        End If
    End Sub
    Sub tampildataguru()
        ds = New DataSet
        query = "SELECT * FROM Teacher"
        da = New SqlDataAdapter(query, conn)
        da.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class