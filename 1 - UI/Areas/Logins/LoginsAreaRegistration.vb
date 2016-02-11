Namespace Areas.Logins
    Public Class LoginsAreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "Logins"
            End Get
        End Property

        Public Overrides Sub RegisterArea(ByVal context As System.Web.Mvc.AreaRegistrationContext)
            context.MapRoute( _
                "Logins_default", _
               "Logins/{controller}/{action}/{id}", _
                New With {.action = "Index", .id = UrlParameter.Optional} _
            )
        End Sub
    End Class
End Namespace

