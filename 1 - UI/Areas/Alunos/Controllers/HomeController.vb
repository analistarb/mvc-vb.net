Imports Aplicacao
Imports Dominio
Imports System.Collections.ObjectModel



Namespace Areas.Alunos.Controllers

    Public Class HomeController
        Inherits System.Web.Mvc.Controller


        Public Function Index() As ActionResult
            Dim appAluno = New AlunoAplicacao()
            Dim listaDeAlunos = appAluno.ListarTodos()
            Return View(listaDeAlunos)
        End Function



        Public Function Cadastrar() As ActionResult
            Dim appRaca = New RacaAplicacao()
            Dim raca = appRaca.ListarTodos()
            ViewBag.raca = raca


            Return View()
        End Function





        <HttpPost> _
        <ValidateAntiForgeryToken> _
        Public Function Cadastrar(aluno As Aluno) As ActionResult

            Dim appRaca = New RacaAplicacao()
            Dim raca = appRaca.ListarTodos()
            ViewBag.raca = raca
            

           
            If String.IsNullOrEmpty(aluno.Mae) Then
                ModelState.AddModelError("Nome da Mae", "O campo nome da mae é obrigatório")
            End If
            If aluno.nm_senha <> aluno.ConfirmarSenha Then
                ModelState.AddModelError("", "As senhas não conferem")
            End If
            

            If ModelState.IsValid Then
                Dim appAluno = New AlunoAplicacao()
                appAluno.Salvar(aluno)

                Return RedirectToAction("Index")
            End If

            Return View(aluno)
        End Function







        Public Function Editar(id As String) As ActionResult
            Dim appAluno = New AlunoAplicacao()
            Dim aluno = appAluno.ListarPorId(id)


            Dim appRaca = New RacaAplicacao()
            Dim raca = appRaca.ListarTodos()
            ViewBag.raca = raca
            


            If aluno Is Nothing Then
                Return HttpNotFound()
            End If


            Return View(aluno)
        End Function



       
        <HttpPost> _
        <ValidateAntiForgeryToken> _
        Public Function Editar(aluno As Aluno) As ActionResult



            If String.IsNullOrEmpty(aluno.Mae) Then
                ModelState.AddModelError("Nome da Mae", "O campo nome da mae é obrigatório")
            End If
            If aluno.nm_senha <> aluno.ConfirmarSenha Then
                ModelState.AddModelError("", "As senhas não conferem")
            End If
            


            If ModelState.IsValid Then
                Dim appAluno = New AlunoAplicacao()
                appAluno.Salvar(aluno)

                Return RedirectToAction("Index")
            End If

            Return View(aluno)

        End Function




        Public Function Detalhes(id As String) As ActionResult
            Dim appAluno = New AlunoAplicacao()
            Dim aluno = appAluno.ListarPorId(id)


            If aluno Is Nothing Then
                Return HttpNotFound()
            End If


            Return View(aluno)
        End Function



        Public Function Excluir(id As String) As ActionResult
            Dim appAluno = New AlunoAplicacao()
            Dim aluno = appAluno.ListarPorId(id)


            If aluno Is Nothing Then
                Return HttpNotFound()
            End If


            Return View(aluno)
        End Function



        
        <HttpPost, ActionName("Excluir")> _
        <ValidateAntiForgeryToken> _
        Public Function ExcluirConfirmado(id As String) As ActionResult
            Dim appAluno = New AlunoAplicacao()
            appAluno.Excluir(id)
            Return RedirectToAction("Index")
        End Function






        Public Function ValidarCpf(nr_cpf As String) As ActionResult
            Dim Id As Integer = 0


            If nr_cpf.Replace(".", "").Replace("-", "").Length <= 11 Then
                Id = 1
            Else
                Id = 0
            End If

            Dim retorno = (Id > 0)

            Return Json(retorno, JsonRequestBehavior.AllowGet)
        End Function



        Public Function LoginUnico(nm_usuario As String) As ActionResult


            Dim bancoDeNomesDeExemplo = New Collection(Of String)() From { _
                "Rafael", _
                "Anderson", _
                "Renata" _
            }


            Return Json(bancoDeNomesDeExemplo.All(Function(x) x.ToLower() <> nm_usuario.ToLower()), JsonRequestBehavior.AllowGet)
        End Function
 




    End Class

End Namespace

