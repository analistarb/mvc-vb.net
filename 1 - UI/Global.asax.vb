' Observação: Para obter instruções sobre a habilitação do modo clássico IIS6 ou IIS7, 
' visite http://go.microsoft.com/?LinkId=9394802
Imports System.Web.Http
Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()

        WebApiConfig.Register(GlobalConfiguration.Configuration)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
End Class
