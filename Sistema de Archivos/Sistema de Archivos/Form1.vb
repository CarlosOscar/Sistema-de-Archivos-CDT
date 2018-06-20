Imports System.Data.SqlClient
Public Class Form1
    Private Const V As String = "Archivos PDF | *.pdf"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "SELECT * FROM cdt_informacion"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "cdt_informacion")

            Me.DataGridView1.DataSource = ds.Tables("cdt_informacion")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        OpenFileDialog1.Filter = "Archivos PDF | *.pdf"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub checkedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles accion_box.SelectedIndexChanged

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub dirigido_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dirigido_box.SelectedIndexChanged

    End Sub
End Class
