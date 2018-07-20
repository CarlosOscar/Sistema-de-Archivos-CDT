Imports System.Data.SqlClient
Imports System.IO

Public Class Form1



    Private Const V As String = "Archivos PDF | *.pdf"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        refrescar()
        Ocultar()

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
                refrescar()
                Ocultar()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Dispose()
                cmm.Dispose()
            End Try
        Catch ex As Exception

        End Try


    End Sub

    Public Sub refrescar()
        Try
            Dim con As New SqlConnection(conexion)
            Dim sql As String = "SELECT * FROM cdt_informacion"
            Dim cmm As New SqlCommand(sql, con)


            Try

                Dim da As New SqlDataAdapter(cmm)
                Dim ds As New DataSet
                da.Fill(ds, "cdt_informacion")

                Me.DataGridView1.DataSource = ds.Tables("cdt_informacion")

            Catch ex As Exception
                MsgBox(ex.Message)


            Finally
                con.Dispose()
                cmm.Dispose()
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Try
            Dim directorioArchivo As String
            directorioArchivo = System.AppDomain.CurrentDomain.BaseDirectory() & "temp.pdf"

            Dim str_cadena As String
            str_cadena = " select * from cdt_informacion where folioCDT=" & foliocdt2_txt.Text
            If conectar() = False Then
                Exit Sub
            End If
            dr = fun_ExecuteReader(str_cadena)
            If dr.HasRows Then
                While dr.Read
                    foliocdt2_txt.Text = dr("folioCDT")
                    observaciones2_txt.Text = dr("observaciones")

                    If dr("arch_pdf") IsNot DBNull.Value Then
                        Dim bytes() As Byte
                        bytes = dr("arch_pdf")

                        BytesAArchivo(bytes, directorioArchivo)
                        ArcPDF2.src = directorioArchivo
                        My.Computer.FileSystem.DeleteFile(directorioArchivo)

                    End If
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BytesAArchivo(ByVal bytes() As Byte, ByVal Path As String)
        Dim K As Long
        If bytes Is Nothing Then Exit Sub
        Try
            K = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, K)
            fs.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub Ocultar()
        Me.DataGridView1.Columns("arch_pdf").Visible = False
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        Dim k As Integer
        i = DataGridView1.CurrentRow.Index
        k = DataGridView1.CurrentCell.ColumnIndex
        foliocdt2_txt.Text = DataGridView1.Item(k, i).Value

    End Sub



    Private Sub asunto2_txt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim str_cadena As String
            str_cadena = " UPDATE cdt_informacion SET observaciones = '" & observaciones2_txt.Text & "' where folioCDT=" & foliocdt2_txt.Text
            If conectar() = False Then
                Exit Sub
            End If
            dr = fun_ExecuteReader(str_cadena)
            If dr.HasRows Then
                While dr.Read


                End While
            End If
            MsgBox("Datos actualizados correctamente", vbInformation)

            refrescar()
            Ocultar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CnsxAsunto_Click(sender As Object, e As EventArgs) Handles CnsxAsunto.Click
        Form2.Show()
    End Sub
End Class
