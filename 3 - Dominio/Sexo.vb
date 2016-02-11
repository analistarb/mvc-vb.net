Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations


Public Class Sexo
    Public Property ci_sexo() As Integer
        Get
            Return m_ci_sexo
        End Get
        Set(value As Integer)
            m_ci_sexo = Value
        End Set
    End Property
    Private m_ci_sexo As Integer
    Public Property dc_sexo() As String
        Get
            Return m_dc_sexo
        End Get
        Set(value As String)
            m_dc_sexo = Value
        End Set
    End Property
    Private m_dc_sexo As String
End Class
