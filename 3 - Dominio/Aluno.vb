Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc



Public Class Aluno
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set(value As Integer)
            m_Id = Value
        End Set
    End Property
    Private m_Id As Integer

    <Required(ErrorMessage:="Preencha o nome do Aluno")> _
    Public Property Nome() As String
        Get
            Return m_Nome
        End Get
        Set(value As String)
            m_Nome = Value
        End Set
    End Property
    Private m_Nome As String

    <DisplayName("Mãe")> _
    Public Property Mae() As String
        Get
            Return m_Mae
        End Get
        Set(value As String)
            m_Mae = Value
        End Set
    End Property
    Private m_Mae As String

    <DisplayName("Data de Nascimento")> _
    <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:dd/MM/yyyy}")> _
    Public Property DataNascimento() As System.Nullable(Of DateTime)
        Get
            Return m_DataNascimento
        End Get
        Set(value As System.Nullable(Of DateTime))
            m_DataNascimento = Value
        End Set
    End Property
    Private m_DataNascimento As System.Nullable(Of DateTime)

    <DisplayName("Sexo")> _
    Public Property ci_sexo() As Integer
        Get
            Return m_ci_sexo
        End Get
        Set(value As Integer)
            m_ci_sexo = value
        End Set
    End Property
    Private m_ci_sexo As Integer
    Public Property dc_sexo() As String
        Get
            Return m_dc_sexo
        End Get
        Set(value As String)
            m_dc_sexo = Value
        End Set
    End Property
    Private m_dc_sexo As String


    Public Property ci_raca() As System.Nullable(Of Integer)
        Get
            Return m_ci_raca
        End Get
        Set(value As System.Nullable(Of Integer))
            m_ci_raca = value
        End Set
    End Property
    Private m_ci_raca As System.Nullable(Of Integer)
    Public Property dc_raca() As String
        Get
            Return m_dc_raca
        End Get
        Set(value As String)
            m_dc_raca = Value
        End Set
    End Property
    Private m_dc_raca As String


    <DisplayName("Cadeirante?")> _
    Public Property ci_Cadeirante() As Boolean
        Get
            Return m_ci_Cadeirante
        End Get
        Set(value As Boolean)
            m_ci_Cadeirante = Value
        End Set
    End Property
    Private m_ci_Cadeirante As Boolean

    <DisplayName("Fala?")> _
    Public Property ci_Fala() As Boolean
        Get
            Return m_ci_Fala
        End Get
        Set(value As Boolean)
            m_ci_Fala = Value
        End Set
    End Property
    Private m_ci_Fala As Boolean

    <DisplayName("Trabalha atualmente?")> _
    Public Property p172() As String
        Get
            Return m_p172
        End Get
        Set(value As String)
            m_p172 = Value
        End Set
    End Property
    Private m_p172 As String
    Public Property dc_p172() As String
        Get
            Return m_dc_p172
        End Get
        Set(value As String)
            m_dc_p172 = Value
        End Set
    End Property
    Private m_dc_p172 As String

    <DisplayName("Qual é a ultima ou atual ocupação?")> _
    <StringLength(10)> _
    Public Property p15() As String
        Get
            Return m_p15
        End Get
        Set(value As String)
            m_p15 = Value
        End Set
    End Property
    Private m_p15 As String


    <DisplayName("Idade")> _
    Public Property nr_idade() As System.Nullable(Of Integer)
        Get
            Return m_nr_idade
        End Get
        Set(value As System.Nullable(Of Integer))
            m_nr_idade = value
        End Set
    End Property
    Private m_nr_idade As System.Nullable(Of Integer)


    <DisplayName("Email")> _
    <RegularExpression("\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage:="O email informado não é valido")> _
    Public Property nm_email() As String
        Get
            Return m_nm_email
        End Get
        Set(value As String)
            m_nm_email = Value
        End Set
    End Property
    Private m_nm_email As String


    <DisplayName("Dinheiro")> _
    Public Property nr_dinheiro() As System.Nullable(Of Decimal)
        Get
            Return m_nr_dinheiro
        End Get
        Set(value As System.Nullable(Of Decimal))
            m_nr_dinheiro = Value
        End Set
    End Property
    Private m_nr_dinheiro As System.Nullable(Of Decimal)

    <DisplayName("Observação")> _
    <StringLength(50, MinimumLength:=5, ErrorMessage:="A observação deve ter entre 5 e 50 caracteres")> _
    Public Property dc_obs() As String
        Get
            Return m_dc_obs
        End Get
        Set(value As String)
            m_dc_obs = value
        End Set
    End Property
    Private m_dc_obs As String



    <DisplayName("CPF")> _
    <Remote("ValidarCpf", "Home", AdditionalFields:="Id", ErrorMessage:="Este CPF não é valido")> _
    Public Property nr_cpf() As String
        Get
            Return m_nr_cpf
        End Get
        Set(value As String)
            m_nr_cpf = value
        End Set
    End Property
    Private m_nr_cpf As String


    <DisplayName("Usuario")> _
    <Required(ErrorMessage:="O Login deve ser preenchido")> _
    <Remote("LoginUnico", "Home", ErrorMessage:="Este nome de login já existe")> _
    <RegularExpression("[a-zA-Z]{5,15}", ErrorMessage:="Login deve possuir somente letras e deve ter de 5 a 15 caracteres")> _
    Public Property nm_usuario() As String
        Get
            Return m_nm_usuario
        End Get
        Set(value As String)
            m_nm_usuario = value
        End Set
    End Property
    Private m_nm_usuario As String

    <DisplayName("Senha")> _
    <Required(ErrorMessage:="A senha deve ser informada")> _
    Public Property nm_senha() As String
        Get
            Return m_nm_senha
        End Get
        Set(value As String)
            m_nm_senha = Value
        End Set
    End Property
    Private m_nm_senha As String


    <DisplayName("Confirmar Senha")> _
    <System.ComponentModel.DataAnnotations.Compare("nm_senha", ErrorMessage:="As senhas não conferem")> _
    Public Property ConfirmarSenha() As String
        Get
            Return m_ConfirmarSenha
        End Get
        Set(value As String)
            m_ConfirmarSenha = Value
        End Set
    End Property
    Private m_ConfirmarSenha As String



End Class