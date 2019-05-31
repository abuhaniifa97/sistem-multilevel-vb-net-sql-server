Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        njir()

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        cmd = New SqlCommand("SELECT * FROM login WHERE Username='" & txt_user.Text & "'AND Password='" & txt_pass.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()


        If Not dr.HasRows Then
            MsgBox("Login Gagal")
            txt_user.Text = ""
            txt_pass.Text = ""
            txt_user.Focus()
            dr.Close()


        Else
            Form_Utama.Show()
            lbl_hilang.Text = dr.Item("Role")

            If lbl_hilang.Text = "admin" Then
                Form_Utama.panel_admin.Visible = True
                Form_Utama.Panel_guru.Visible = False
                dr.Close()
            ElseIf lbl_hilang.Text = "guru"
                Form_Utama.Panel_guru.Visible = True
                Form_Utama.panel_admin.Visible = False
                dr.Close()

            End If
        End If

    End Sub
End Class
