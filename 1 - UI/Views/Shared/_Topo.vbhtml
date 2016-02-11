
<p>Todo do Meu site</p>


@If Session("usuarioLogadoID") IsNot Nothing Then
    @<text>
        <h3> Bem-Vindo @Session("usuarioLogadoNome").ToString() </h3>
    </text>
End If

    
    


