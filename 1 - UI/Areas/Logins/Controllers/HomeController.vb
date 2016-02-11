Imports Aplicacao
Imports Dominio
Imports System.Collections.ObjectModel


Namespace Areas.Logins.Controllers

    Public Class HomeController
        Inherits System.Web.Mvc.Controller



        Public Function Index() As ActionResult
            Dim login = New Login()
            Return View(login)
        End Function



        <HttpPost> _
        Public Function Index(login As Login) As ActionResult
            If login.nm_login = "teste_login" Then
                Session("usuarioLogadoID") = "1"
                Session("usuarioLogadoNome") = "João da Silva"



                TempData("alert") = "Login realizado com sucesso!!!"



                Return RedirectToAction("Index", "Home", New With {.area = "Alunos"})
            Else
                Return View(login)
            End If

        End Function


        Public Function Sair() As ActionResult
            Session("usuarioLogadoID") = Nothing
            Session("usuarioLogadoNome") = Nothing
            Return RedirectToAction("Index", "Home", New With {.area = ""})
        End Function


    End Class

End Namespace


