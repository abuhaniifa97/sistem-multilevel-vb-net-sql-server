Public Class Form_Utama
    Private Sub btn_logut_Click(sender As Object, e As EventArgs) Handles btn_logut.Click
        Me.Close()

    End Sub

    Private Sub btn_mangemntmurid_Click(sender As Object, e As EventArgs) Handles btn_mangemntmurid.Click
        Me.Hide()
        Management_Murid.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Edit.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        Edit.Show()
    End Sub

    Private Sub Form_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class