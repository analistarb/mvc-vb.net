Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Dominio
Imports Repositorio


Public Class RacaAplicacao
    Private contexto As Contexto



    Public Function ListarPorId(ci_raca As String) As Raca
        Using contexto = New Contexto()
            Dim strQuery = String.Format(" Select * from Raca where ci_raca = {0}", ci_raca)
            Dim retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery)
            Return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault()
        End Using
    End Function

    '----------------------------------------------------------------------------------



    Public Function ListarTodos() As List(Of Raca)
        Using contexto = New Contexto()
            Dim strQuery = " Select * from Raca "
            Dim retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery)
            Return TransformaReaderEmListaDeObjeto(retornoDataReader)
        End Using
    End Function


    '----------------------------------------------------------------------------------

    Private Function TransformaReaderEmListaDeObjeto(reader As SqlDataReader) As List(Of Raca)
        Dim racas = New List(Of Raca)()
        While reader.Read()
            Dim temObjeto = New Raca()
            temObjeto.ci_raca = Integer.Parse(reader("ci_raca").ToString())
            temObjeto.dc_raca = reader("dc_raca").ToString()

            racas.Add(temObjeto)
        End While
        reader.Close()
        Return racas
    End Function


End Class
