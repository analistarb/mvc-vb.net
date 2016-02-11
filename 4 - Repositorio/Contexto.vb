Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient



Public Class Contexto

    Implements IDisposable

    Private ReadOnly minhaConexao As SqlConnection

    Public Sub New()

        minhaConexao = New SqlConnection("data source=.\SQL2012;Integrated Security=SSPI;Initial Catalog=BDSQL2012")
        minhaConexao.Open()
    End Sub


    Public Sub ExecutaComando(strQuery As String)
        Dim cmdComando = New SqlCommand()
        cmdComando.CommandText = strQuery
        cmdComando.CommandType = CommandType.Text
        cmdComando.Connection = minhaConexao

        cmdComando.ExecuteNonQuery()
    End Sub


    Public Function ExecutaComandoComRetorno(strQuery As String) As SqlDataReader
        Dim cmdComando = New SqlCommand(strQuery, minhaConexao)
        Return cmdComando.ExecuteReader()
    End Function


    Public Sub Dispose() Implements IDisposable.Dispose
        If minhaConexao.State = ConnectionState.Open Then
            minhaConexao.Close()
        End If
    End Sub

End Class
