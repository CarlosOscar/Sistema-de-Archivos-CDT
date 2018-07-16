
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

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

    End Sub

    Private Sub Asunto3_Click(sender As Object, e As EventArgs) Handles Asunto3.Click
        Try


            Dim str_cadena As String
            str_cadena = " select * from cdt_informacion where asunto Like %'" & asunto3txt.Text & "'%"
            If conectar() = False Then
                Exit Sub
            End If
            dr = fun_ExecuteReader(str_cadena)
            If dr.HasRows Then
                While dr.Read
                    asunto3txt.Text = dr("asunto")
                    observaciones3txt.Text = dr("observaciones")




                End While
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class