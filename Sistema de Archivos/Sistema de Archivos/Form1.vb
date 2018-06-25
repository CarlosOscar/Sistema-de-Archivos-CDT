Imports System.Data.SqlClient
Public Class Form1

    Dim conexion As conexion = New conexion()

    Private Const V As String = "Archivos PDF | *.pdf"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conexion.conectar()
        MostrarDatos()


    End Sub

    Public Sub MostrarDatos()
        conexion.Consulta("Select * from cdt_info", "cdt_info")
        Me.DataGridView1.DataSource = conexion.ds.Tables("cdt_info")



    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        OpenFileDialog1.Filter = "Archivos PDF | *.pdf"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub checkedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub dirigido_box_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim agregar As String = "insert into cdt_info values (" + foliocdt_txt.Text + ", " + folioginp_txt.Text + ", " + otginp_txt.Text + ", '" + fecharecibido_date.Value + "', '" + requeridopara_txt.Value + "',
        '" + procedencia_txt.Text + "' . '" + asunto_txt.Text + "', '" + observaciones_txt.Text + "', '" + CheckBox1.Text + "', '" + CheckBox2.Text + "', '" + CheckBox3.Text + "'. '" + CheckBox4.Text + "'. '" + CheckBox5.Text + "',
        '" + CheckBox6.Text + "', '" + CheckBox7.Text + "', '" + CheckBox8.Text + "', '" + CheckBox9.Text + "', '" + CheckBox10.Text + "', '" + CheckBox11.Text + "', '" + CheckBox12.Text + "', '" + CheckBox13.Text + "',
        '" + CheckBox14.Text + "', '" + CheckBox15.Text + "', '" + CheckBox16.Text + "')"

        If (conexion.Insertar(agregar)) Then
            MessageBox.Show("Registro agregado correctamente")
            MostrarDatos()
        Else
            MessageBox.Show("No se pudo agregar")
        End If
    End Sub
End Class
