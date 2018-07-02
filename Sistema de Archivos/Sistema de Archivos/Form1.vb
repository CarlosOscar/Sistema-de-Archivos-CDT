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
            Dim cmm As New SqlCommand("sp_mant_infcdt", cnn)
            cmm.CommandType = CommandType.StoredProcedure
            cmm.Parameters.AddWithValue("@folioCDT", foliocdt_txt.Text)
            cmm.Parameters.AddWithValue("@folio_GINP", folioginp_txt.Text)
            cmm.Parameters.AddWithValue("@OT_GINP", otginp_txt.Text)
            cmm.Parameters.AddWithValue("@fecha_recibido", fecharecibido_date.Value)
            cmm.Parameters.AddWithValue("@fecha_requerido", requeridopara_txt.Value)
            cmm.Parameters.AddWithValue("@procedencia", procedencia_txt.Text)
            cmm.Parameters.AddWithValue("@asunto", asunto_txt.Text)
            cmm.Parameters.AddWithValue("@observaciones", observaciones_txt.Text)
            If CheckBox1.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido1", CheckBox1.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido1", DBNull.Value)
            End If
            If CheckBox2.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido2", CheckBox2.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido2", DBNull.Value)
            End If
            If CheckBox3.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido3", CheckBox3.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido3", DBNull.Value)
            End If
            If CheckBox4.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido4", CheckBox4.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido4", DBNull.Value)
            End If
            If CheckBox5.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido5", CheckBox5.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido5", DBNull.Value)
            End If
            If CheckBox6.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido6", CheckBox6.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido6", DBNull.Value)
            End If
            If CheckBox7.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido7", CheckBox7.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido7", DBNull.Value)
            End If
            If CheckBox8.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido8", CheckBox8.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido8", DBNull.Value)
            End If
            If CheckBox9.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido9", CheckBox9.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido9", DBNull.Value)
            End If
            If CheckBox10.Checked = True Then
                cmm.Parameters.AddWithValue("@dirigido10", CheckBox10.Text)
            Else
                cmm.Parameters.AddWithValue("@dirigido10", DBNull.Value)
            End If
            If CheckBox11.Checked = True Then
                cmm.Parameters.AddWithValue("@accion1", CheckBox11.Text)
            Else
                cmm.Parameters.AddWithValue("@accion1", DBNull.Value)
            End If
            If CheckBox12.Checked = True Then
                cmm.Parameters.AddWithValue("@accion2", CheckBox12.Text)
            Else
                cmm.Parameters.AddWithValue("@accion2", DBNull.Value)
            End If
            If CheckBox13.Checked = True Then
                cmm.Parameters.AddWithValue("@accion3", CheckBox13.Text)
            Else
                cmm.Parameters.AddWithValue("@accion3", DBNull.Value)
            End If
            If CheckBox14.Checked = True Then
                cmm.Parameters.AddWithValue("@accion4", CheckBox14.Text)
            Else
                cmm.Parameters.AddWithValue("@accion4", DBNull.Value)
            End If
            If CheckBox15.Checked = True Then
                cmm.Parameters.AddWithValue("@accion5", CheckBox15.Text)
            Else
                cmm.Parameters.AddWithValue("@accion5", DBNull.Value)
            End If
            If CheckBox16.Checked = True Then
                cmm.Parameters.AddWithValue("@accion6", CheckBox16.Text)
            Else
                cmm.Parameters.AddWithValue("@accion6", DBNull.Value)
            End If
            cmm.Parameters.AddWithValue("@arch_pdf", binario)
            'ejecutar
            Try
                cnn.Open()
                cmm.ExecuteNonQuery()

                MsgBox("Datos registrados correctamente", vbInformation)

                foliocdt_txt.Text = ""
                folioginp_txt.Text = ""
                otginp_txt.Text = ""
                procedencia_txt.Text = ""
                observaciones_txt.Text = ""
                asunto_txt.Text = ""
                txt_ruta.Text = ""
                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
                CheckBox8.Checked = False
                CheckBox9.Checked = False
                CheckBox10.Checked = False
                CheckBox11.Checked = False
                CheckBox12.Checked = False
                CheckBox13.Checked = False
                CheckBox14.Checked = False
                CheckBox15.Checked = False
                CheckBox16.Checked = False
                ArcPDF.LoadFile("nada.pdf")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Dispose()
                cmm.Dispose()
            End Try
        Catch ex As Exception

        End Try


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
     
    End Sub
End Class
