Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Dominio
Imports Repositorio


Public Class SexoAplicacao
    Private contexto As Contexto



    Public Function ListarPorId(ci_sexo As String) As Sexo
        Using contexto = New Contexto()
            Dim strQuery = String.Format(" Select * from Sexo where ci_sexo = {0}", ci_sexo)
            Dim retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery)

            Return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault()
        End Using
    End Function



    Public Function ListarTodos() As List(Of Sexo)
        Using contexto = New Contexto()
            Dim strQuery = " Select * from Sexo "
            Dim retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery)
            Return TransformaReaderEmListaDeObjeto(retornoDataReader)
        End Using
    End Function



    Private Function TransformaReaderEmListaDeObjeto(reader As SqlDataReader) As List(Of Sexo)
        Dim sexos = New List(Of Sexo)()
        While reader.Read()
            Dim temObjeto = New Sexo()
            temObjeto.ci_sexo = Integer.Parse(reader("ci_sexo").ToString())
            temObjeto.dc_sexo = reader("dc_sexo").ToString()

            sexos.Add(temObjeto)
        End While
        reader.Close()
        Return sexos
    End Function


End Class
