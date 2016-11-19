Public Class Form1
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Process.Start("C:\Program Files (x86)\Readiris Pro 15\readiris.exe")
    End Sub
End Class
