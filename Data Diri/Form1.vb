Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String = TextBox1.Text
        Dim nim As String = TextBox2.Text
        Dim jenisKelamin As String = TextBox3.Text
        Dim status As String = TextBox4.Text
        Dim ttl As String = TextBox5.Text
        Dim alamat As String = TextBox6.Text
        Dim agama As String = TextBox7.Text
        Dim pekerjaan As String = TextBox8.Text
        Dim kewarganegaraan As String = TextBox9.Text

        MessageBox.Show($"Nama: {nama}" & vbCrLf & $"NIM: {nim}" & vbCrLf & $"Jenis Kelamin: {jenisKelamin}" & vbCrLf & $"Status: {status}" & vbCrLf & $"Tempat/Tanggal Lahir: {ttl}" & vbCrLf & $"Alamat: {alamat}" & vbCrLf & $"Agama: {agama}" & vbCrLf & $"Pekerjaan: {pekerjaan}" & vbCrLf & $"Kewarganegaraan: {kewarganegaraan}", "Data Diri", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

End Class
