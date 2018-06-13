Public Class Form1
    Private Const V As String = "Archivos PDF | *.pdf"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        OpenFileDialog1.Filter = "Archivos PDF | *.pdf"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub checkedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles checkedListBox2.SelectedIndexChanged

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class
