Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc


Public Class Login

    <DisplayName("Nome do Login")> _
            <Required(ErrorMessage:="Preencha o Login")> _
    Public Property nm_login() As String
        Get
            Return m_nm_login
        End Get
        Set(value As String)
            m_nm_login = value
        End Set
    End Property
    Private m_nm_login As String

End Class
