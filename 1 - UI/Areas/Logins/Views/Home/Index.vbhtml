@ModelType Dominio.Login

@Code
    ViewData("Title") = "Login"
End Code

<h2>Login</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()

    @Html.ValidationSummary(False)

    @<fieldset>
        <legend>Login</legend>
        <div class="editor-label">
            @Html.LabelFor(Function(model) model.nm_login)
        </div>
        <div class="editor-field">
            @Html.TextBoxFor(Function(model) model.nm_login, New With {Key .Value = "teste_login"})
            @Html.ValidationMessageFor(Function(model) model.nm_login)
        </div>             
        <p>
            <input type="submit" value="Entrar" />
        </p>

    </fieldset>
End Using


@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section


@section seguranca
End Section  

@Code
    ViewBag.Title = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

