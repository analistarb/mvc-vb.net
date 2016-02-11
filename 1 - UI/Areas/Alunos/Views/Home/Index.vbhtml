@ModelType IEnumerable(Of Dominio.Aluno)

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>           
    @Html.ActionLink("Novo Aluno", "Cadastrar")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mae)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DataNascimento)
        </th>        
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Nome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Mae)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.DataNascimento)
        </td>        
        <td>
            @Html.ActionLink("Editar", "Editar", New With {.id = currentItem.Id}) |
            @Html.ActionLink("Detalhes", "Detalhes", New With {.id = currentItem.Id}) |
            @Html.ActionLink("Excluir", "Excluir", New With {.id = currentItem.Id})
        </td>
    </tr>
Next

</table>


@section rodape
   <p>Meu rodape especifico da pagina</p>
   <p>Veja mais em @Html.ActionLink("Sobre", "Index", "Home")</p>
End section

@Code
    ViewBag.Title = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
