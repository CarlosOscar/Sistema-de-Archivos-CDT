Imports System.Data.SqlClient
Imports System.IO

Public Class Form1



    Private Const V As String = "Archivos PDF | *.pdf"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub



    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Try
            Dim archivo As New OpenFileDialog
            archivo.Filter = "Archivo PDF|*.pdf"
            If archivo.ShowDialog = DialogResult.OK Then
                txt_ruta.Text = archivo.FileName
                ArcPDF.src = archivo.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        Try
            Dim strPath As String
            strPath = txt_ruta.Text
            Dim ruta As New FileStream(strPath, FileMode.Open, FileAccess.Read)
            Dim binario(ruta.Length) As Byte
            ruta.Read(binario, 0, ruta.Length) 'Leo el archivo y lo convierto a binario 
            ruta.Close() 'Cierro el FileStream 

            Dim cnn As New SqlConnection(conexion)
            Dim cmm As New SqlCommand("sp_mant_info", cnn)
            cmm.CommandType = CommandType.StoredProcedure
            cmm.Parameters.AddWithValue("@folioCDT", foliocdt_txt.Text)
            cmm.Parameters.AddWithValue("@folio_GINP", folioginp_txt.Text)
            cmm.Parameters.AddWithValue("@OT_GINP", otginp_txt.Text)
            cmm.Parameters.AddWithValue("@fecha_recibido", fecharecibido_date.Value)
            cmm.Parameters.AddWithValue("@fecha_requerido", requeridopara_txt.Value)
            cmm.Parameters.AddWithValue("@procedencia", procedencia_txt.Text)
            cmm.Parameters.AddWithValue("@asunto", asunto_txt.Text)
            cmm.Parameters.AddWithValue("@observaciones", observaciones_txt.Text)
            cmm.Parameters.AddWithValue("@dirigido1", CheckBox1.Text)
            cmm.Parameters.AddWithValue("@dirigido2", CheckBox2.Text)
            cmm.Parameters.AddWithValue("@dirigido3", CheckBox3.Text)
            cmm.Parameters.AddWithValue("@dirigido4", CheckBox4.Text)
            cmm.Parameters.AddWithValue("@dirigido5", CheckBox5.Text)
            cmm.Parameters.AddWithValue("@dirigido6", CheckBox6.Text)
            cmm.Parameters.AddWithValue("@dirigido7", CheckBox7.Text)
            cmm.Parameters.AddWithValue("@dirigido8", CheckBox8.Text)
            cmm.Parameters.AddWithValue("@dirigido9", CheckBox9.Text)
            cmm.Parameters.AddWithValue("@dirigido10", CheckBox10.Text)
            cmm.Parameters.AddWithValue("@accion1", CheckBox11.Text)
            cmm.Parameters.AddWithValue("@accion2", CheckBox12.Text)
            cmm.Parameters.AddWithValue("@accion3", CheckBox13.Text)
            cmm.Parameters.AddWithValue("@accion4", CheckBox14.Text)
            cmm.Parameters.AddWithValue("@accion5", CheckBox15.Text)
            cmm.Parameters.AddWithValue("@accion6", CheckBox16.Text)
            cmm.Parameters.AddWithValue("@arch_pdf", binario)
            'ejecutar
            Try
                cnn.Open()
                cmm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Dispose()
                cmm.Dispose()
            End Try
        Catch ex As Exception

        End Try

    End Sub
End Class
