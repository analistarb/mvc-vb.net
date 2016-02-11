Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Dominio
Imports Repositorio


Public Class AlunoAplicacao
    Private contexto As Contexto

    Private Sub Inserir(aluno As Aluno)
        Dim strQuery = ""
        strQuery += " INSERT INTO ALUNO (Nome, Mae, DataNascimento, ci_sexo, nr_cpf, ci_Cadeirante, ci_Fala, p172, p15,nr_idade,nm_email,nr_dinheiro,dc_obs,nm_usuario,nm_senha,ci_raca) "
        strQuery += String.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}') ", aluno.Nome, aluno.Mae, aluno.DataNascimento, aluno.ci_sexo, aluno.nr_cpf, _
            aluno.ci_Cadeirante.BoolToInt(), aluno.ci_Fala.BoolToInt(), aluno.p172, aluno.p15, aluno.nr_idade.ToString().ToInt(), aluno.nm_email, _
            aluno.nr_dinheiro.ToString().ToDecDb(), aluno.dc_obs, aluno.nm_usuario, aluno.nm_senha, aluno.ci_raca)

        Using contexto = New Contexto()
            contexto.ExecutaComando(strQuery)
        End Using

    End Sub


    Private Sub Alterar(aluno As Aluno)
        Dim strQuery = ""
        strQuery += String.Format(" UPDATE ALUNO SET ")
        strQuery += String.Format(" Nome = '{0}', ", aluno.Nome)
        strQuery += String.Format(" Mae = '{0}', ", aluno.Mae)
        strQuery += String.Format(" DataNascimento = '{0}', ", aluno.DataNascimento)
        strQuery += String.Format(" ci_sexo = '{0}', ", aluno.ci_sexo)
        strQuery += String.Format(" ci_raca = '{0}', ", aluno.ci_raca)
        strQuery += String.Format(" nr_cpf  = '{0}', ", aluno.nr_cpf)
        strQuery += String.Format(" ci_Cadeirante = '{0}', ", aluno.ci_Cadeirante.BoolToInt())
        strQuery += String.Format(" ci_Fala = '{0}', ", aluno.ci_Fala.BoolToInt())
        strQuery += String.Format(" p172 = '{0}', ", aluno.p172)
        strQuery += String.Format(" p15  = '{0}', ", aluno.p15)

        strQuery += String.Format(" nr_idade  = '{0}', ", aluno.nr_idade.ToString().ToInt())
        strQuery += String.Format(" nm_email  = '{0}', ", aluno.nm_email)
        strQuery += String.Format(" nr_dinheiro  = '{0}', ", aluno.nr_dinheiro.ToString().ToDecDb())
        strQuery += String.Format(" dc_obs  = '{0}', ", aluno.dc_obs)
        strQuery += String.Format(" nm_usuario  = '{0}', ", aluno.nm_usuario)
        strQuery += String.Format(" nm_senha  = '{0}' ", aluno.nm_senha)

        strQuery += String.Format(" WHERE Id = {0} ", aluno.Id)

        Using contexto = New Contexto()
            contexto.ExecutaComando(strQuery)
        End Using

    End Sub


    Public Sub Salvar(aluno As Aluno)
        If aluno.Id > 0 Then
            Alterar(aluno)
        Else
            Inserir(aluno)
        End If

    End Sub

    Public Sub Excluir(id As String)
        Using contexto = New Contexto()
            Dim strQuery = String.Format(" DELETE FROM ALUNO WHERE Id = {0}", id)
            contexto.ExecutaComando(strQuery)
        End Using

    End Sub

    Public Function ListarTodos() As List(Of Aluno)
        Using contexto = New Contexto()
            Dim strQuery = " Select *,replace(replace(t1.ci_sexo,1,'Masculino'),2,'Feminino') dc_sexo,replace(replace(t1.p172,'1','Sim'),'2','Não') dc_p172,t2.dc_raca from Aluno t1 left join raca t2 on t1.ci_raca=t2.ci_raca "
            Dim retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery)
            Return TransformaReaderEmListaDeObjeto(retornoDataReader)
        End Using
    End Function


    Public Function ListarPorId(id As String) As Aluno
        Using contexto = New Contexto()
            Dim strQuery = String.Format(" Select *,replace(replace(t1.ci_sexo,1,'Masculino'),2,'Feminino') dc_sexo,replace(replace(t1.p172,'1','Sim'),'2','Não') dc_p172,t2.dc_raca from Aluno t1 left join raca t2 on t1.ci_raca=t2.ci_raca where t1.Id = {0}", id)
            Dim retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery)

            Return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault()
        End Using
    End Function


    Private Function TransformaReaderEmListaDeObjeto(reader As SqlDataReader) As List(Of Aluno)
        Dim alunos = New List(Of Aluno)()
        While reader.Read()
            Dim temObjeto = New Aluno()

            temObjeto.Id = reader("Id").ToString().ToInt()
            temObjeto.Nome = reader("Nome").ToString()
            temObjeto.Mae = reader("Mae").ToString()
            temObjeto.DataNascimento = reader("DataNascimento").ToString().ToDate()
            temObjeto.ci_sexo = reader("ci_sexo").ToString().ToInt()
            temObjeto.dc_sexo = reader("dc_sexo").ToString()
            temObjeto.ci_raca = reader("ci_raca").ToString().ToInt()
            temObjeto.dc_raca = reader("dc_raca").ToString()
            temObjeto.nr_cpf = reader("nr_cpf").ToString()
            temObjeto.ci_Cadeirante = reader("ci_Cadeirante").ToString().ToBool()
            temObjeto.ci_Fala = reader("ci_Fala").ToString().ToBool()
            temObjeto.p172 = reader("p172").ToString()
            temObjeto.dc_p172 = reader("dc_p172").ToString()
            temObjeto.p15 = reader("p15").ToString()
            temObjeto.nr_idade = reader("nr_idade").ToString().ToInt()
            temObjeto.nm_email = reader("nm_email").ToString()
            temObjeto.nr_dinheiro = reader("nr_dinheiro").ToString().ToDec()
            temObjeto.dc_obs = reader("dc_obs").ToString()
            temObjeto.nm_usuario = reader("nm_usuario").ToString()
            temObjeto.nm_senha = reader("nm_senha").ToString()

            alunos.Add(temObjeto)
        End While
        reader.Close()
        Return alunos
    End Function


End Class
