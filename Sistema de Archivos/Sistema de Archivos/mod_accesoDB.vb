﻿Imports System.Data.SqlClient
Module mod_accesoDB
    Dim cnn As SqlConnection
    Private cmb As SqlCommandBuilder

    Public da As SqlDataAdapter
    Dim cmd As SqlCommand
    Public dr As SqlDataReader

    Public conexion As String = "Data Source=(localdb)\CDT;Initial Catalog=CDT;Integrated Security=True"

    Public Function conectar() As Boolean
        Try
            conectar = False
            cnn = New SqlConnection
            cnn.ConnectionString = conexion
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            conectar = True
        Catch ex As Exception
            conectar = False
        End Try
    End Function

    Public Function desconectar() As Boolean
        Try
            desconectar = False
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                desconectar = True
            End If
        Catch ex As Exception
            desconectar = False
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function fun_ExecuteReader(ByVal cadenasql As String, Optional i As Integer = 0) As SqlDataReader
        Try
            cmd = New SqlCommand
            cmd.CommandText = cadenasql
            If i = 0 Then
                cmd.CommandType = CommandType.Text
            Else
                cmd.CommandType = CommandType.StoredProcedure
            End If
            cmd.Connection = cnn
            Return cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



End Module
