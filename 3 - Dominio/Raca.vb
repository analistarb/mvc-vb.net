Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations


Public Class Raca
    Public Property ci_raca() As Integer
        Get
            Return m_ci_raca
        End Get
        Set(value As Integer)
            m_ci_raca = value
        End Set
    End Property
    Private m_ci_raca As Integer
    Public Property dc_raca() As String
        Get
            Return m_dc_raca
        End Get
        Set(value As String)
            m_dc_raca = value
        End Set
    End Property
    Private m_dc_raca As String
End Class
