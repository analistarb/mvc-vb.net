@ModelType Dominio.Aluno

@Code
    ViewData("Title") = "Cadastrar"
End Code

<h2>Cadastrar</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(False)

    @<fieldset>
        <legend>Aluno</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Nome)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Nome)
            @Html.ValidationMessageFor(Function(model) model.Nome)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Mae)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Mae)
            @Html.ValidationMessageFor(Function(model) model.Mae)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.DataNascimento)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.DataNascimento)
            @Html.ValidationMessageFor(Function(model) model.DataNascimento)
        </div>




        <div class="editor-label">
            @Html.LabelFor(Function(model) model.nr_cpf)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.nr_cpf)
            @Html.ValidationMessageFor(Function(model) model.nr_cpf)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.ci_Cadeirante)
        </div>
        <div class="editor-field">
            @Html.CheckBoxFor(Function(model) model.ci_Cadeirante)
            @Html.ValidationMessageFor(Function(model) model.ci_Cadeirante)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.ci_Fala)
        </div>
        <div class="editor-field">
            @Html.CheckBoxFor(Function(model) model.ci_Fala)
            @Html.ValidationMessageFor(Function(model) model.ci_Fala)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.p172)
        </div>
        <div class="editor-field">
            @Html.RadioButtonFor(Function(model) model.p172, "1") Sim
            @Html.RadioButtonFor(Function(model) model.p172, "2") Não
            @Html.ValidationMessageFor(Function(model) model.p172)
        </div>            

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.p15)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.p15)
            @Html.ValidationMessageFor(Function(model) model.p15)
        </div>
             

        


        <div class="editor-label">
            @Html.LabelFor(Function(model) model.ci_raca)
        </div>
        <div class="editor-field">
            @Html.DropDownListFor(Function(model) model.ci_raca, New SelectList(ViewBag.raca, "ci_raca", "dc_raca"), "Selecione")
            @Html.ValidationMessageFor(Function(model) model.ci_raca)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.ci_sexo)
        </div>
        
        <div class="editor-field">                            
            @Html.DropDownListFor(Function(model) model.ci_sexo, New SelectListItem() { _
                                               New SelectListItem With {.Text = "", .Value = 0}, _
                                               New SelectListItem With {.Text = "Masculino", .Value = 1}, _
                                               New SelectListItem With {.Text = "Feminino", .Value = 2} _
                                               }, New With {.style = "margin-top:7px; width:190px;"})                  
            @Html.ValidationMessageFor(Function(model) model.ci_sexo)
        </div>
        




        <div class="editor-label">
            @Html.LabelFor(Function(model) model.nr_idade)
        </div>
        <div class="editor-field">
            @Html.TextBoxFor(Function(model) model.nr_idade)
            @Html.ValidationMessageFor(Function(model) model.nr_idade)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.nm_email)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.nm_email)
            @Html.ValidationMessageFor(Function(model) model.nm_email)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.nr_dinheiro)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.nr_dinheiro)
            @Html.ValidationMessageFor(Function(model) model.nr_dinheiro)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.dc_obs)
        </div>
        <div class="editor-field">
            @Html.TextAreaFor(Function(model) model.dc_obs)
            @Html.ValidationMessageFor(Function(model) model.dc_obs)
        </div>



         <div class="editor-label">
            @Html.LabelFor(Function(model) model.nm_usuario)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.nm_usuario)
            @Html.ValidationMessageFor(Function(model) model.nm_usuario)
        </div>
        
        <div class="editor-label">
            @Html.LabelFor(Function(model) model.nm_senha)
        </div>
        <div class="editor-field">
            @Html.PasswordFor(Function(model) model.nm_senha)
            @Html.ValidationMessageFor(Function(model) model.nm_senha)
        </div>
        
        <div class="editor-label">
            @Html.LabelFor(Function(model) model.ConfirmarSenha)
        </div>
        <div class="editor-field">
            @Html.PasswordFor(Function(model) model.ConfirmarSenha)
            @Html.ValidationMessageFor(Function(model) model.ConfirmarSenha)
        </div>



        <p>
            <input type="submit" value="Cadastrar" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Voltar", "Index")
</div>



@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")

    <script type="text/javascript">
        //$.noConflict();
        $(document).ready(function() {

            $("#DataNascimento").mask("00/00/0000");
            $("#nr_cpf").mask("000.000.000-00");
            $("#nr_idade").mask("000", { reverse: true });
            $("#nr_dinheiro").mask("000000000000000,00", { reverse: true });
        });

    </script>
End Section



@Code
    ViewBag.Title = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code