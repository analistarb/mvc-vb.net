Namespace Areas.Alunos
    Public Class AlunosAreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "Alunos"
            End Get
        End Property

        Public Overrides Sub RegisterArea(ByVal context As System.Web.Mvc.AreaRegistrationContext)
            context.MapRoute( _
                "Alunos_default", _
               "Alunos/{controller}/{action}/{id}", _
                New With {.action = "Index", .id = UrlParameter.Optional} _
            )
        End Sub
    End Class
End Namespace

