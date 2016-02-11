@ModelType Dominio.Aluno

@Code
    ViewData("Title") = "Detalhes"
End Code

<h2>Detalhes</h2>

<fieldset>
    <legend>Aluno</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Nome)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Nome)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Mae)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Mae)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.DataNascimento)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.DataNascimento)
    </div>



    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.nr_cpf)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.nr_cpf)
    </div>    
        




    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.ci_raca)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.dc_raca)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.ci_sexo)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.dc_sexo)
    </div>
    




    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.ci_Cadeirante)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.ci_Cadeirante)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.ci_Fala)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.ci_Fala)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.p172)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.dc_p172)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.p15)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.p15)
    </div>


    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.nr_idade)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.nr_idade)
    </div>

    

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.nm_email)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.nm_email)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.nr_dinheiro)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.nr_dinheiro)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.dc_obs)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.dc_obs)
    </div>



    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.nm_usuario)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.nm_usuario)
    </div>
        
    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.nm_senha)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.nm_senha)
    </div>



</fieldset>
<p>

    @Html.ActionLink("Editar", "Editar", New With {.id = Model.Id}) |
    @Html.ActionLink("Voltar", "Index")
</p>

@Code
    ViewBag.Title = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code