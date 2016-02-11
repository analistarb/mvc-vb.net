<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>




    <!---Comando para Fazer Include "RenderPage"--->
    @RenderPage("~/Views/Shared/_Topo.vbhtml")
    <!---Outro comando para Fazer Include "Html.Partial"--->
    @Html.Partial("_Menu")
    


    <hr/>
    @RenderBody()
    <hr/>
    



    @If IsSectionDefined("rodape") Then
        @RenderSection("rodape")
        'Caso contrario  inclui o Rodape Padrão
    Else
        @Html.Partial("_Rodape")
    end if




    @Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required:=False)
</body>
</html>






@If TempData("alert") IsNot Nothing Then
    @<text>
    <script type="text/javascript">
        alert("@Html.Encode(TempData("alert"))");
    </script>
    </text>
End If





@If IsSectionDefined("seguranca") Then
    @RenderSection("seguranca")

Else
    @Html.Partial("_seguranca")
End If


