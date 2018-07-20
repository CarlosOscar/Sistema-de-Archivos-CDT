
Imports System.Data.SqlClient
Imports System.IO
Public Class Form2
    Public Sub Ocultar()
        Me.DataGridView2.Columns("arch_pdf").Visible = False
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

                Me.DataGridView2.DataSource = ds.Tables("cdt_informacion")

            Catch ex As Exception
                MsgBox(ex.Message)


            Finally
                con.Dispose()
                cmm.Dispose()
            End Try
        Catch ex As Exception

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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        refrescar()
        Ocultar()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Try
            Dim str_cadena As String
            str_cadena = " UPDATE cdt_informacion SET observaciones = '" & observaciones3txt.Text & "' where folioCDT=" & foliocdt3_txt.Text
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

    Private Sub Asunto3_Click(sender As Object, e As EventArgs) Handles Asunto3.Click
        Try
            Dim con As New SqlConnection(conexion)
            Dim sql As String = "SELECT * FROM cdt_informacion where asunto Like %'" & asunto3txt.Text & "'%"
            Dim cmm As New SqlCommand(sql, con)


            Try

                Dim da As New SqlDataAdapter(cmm)
                Dim ds As New DataSet
                da.Fill(ds, "cdt_informacion")

                Me.DataGridView2.DataSource = ds.Tables("cdt_informacion")

            Catch ex As Exception
                MsgBox(ex.Message)


            Finally
                con.Dispose()
                cmm.Dispose()
            End Try
        Catch ex As Exception

        End Try


    End Sub



    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim i As Integer
        Dim k As Integer

        i = DataGridView2.CurrentRow.Index
        k = DataGridView2.CurrentCell.ColumnIndex
        foliocdt3_txt.Text = DataGridView2.Item(k, i).Value


        Try
            Dim directorioArchivo As String
            directorioArchivo = System.AppDomain.CurrentDomain.BaseDirectory() & "temp.pdf"

            Dim str_cadena As String
            str_cadena = " select * from cdt_informacion where folioCDT=" & foliocdt3_txt.Text
            If conectar() = False Then
                Exit Sub
            End If
            dr = fun_ExecuteReader(str_cadena)
            If dr.HasRows Then
                While dr.Read

                    observaciones3txt.Text = dr("observaciones")

                    If dr("arch_pdf") IsNot DBNull.Value Then
                        Dim bytes() As Byte
                        bytes = dr("arch_pdf")

                        BytesAArchivo(bytes, directorioArchivo)
                        ArcPDF3.src = directorioArchivo
                        My.Computer.FileSystem.DeleteFile(directorioArchivo)

                    End If
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class