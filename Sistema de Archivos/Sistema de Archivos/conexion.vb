Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=(localdb)\CDT;Initial Catalog=CDT;Integrated Security=True")

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("No se conecto")
        Finally
            conexion.Close()
        End Try

    End Sub


    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)

        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)

    End Sub

    Function Insertar(ByVal sql)

        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False

        End If


    End Function


End Class
