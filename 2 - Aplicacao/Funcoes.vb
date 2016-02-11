Module Funcoes


    <System.Runtime.CompilerServices.Extension> _
    Public Function ToBool(s As String) As Boolean
        If s = "1" Then
            Return True
        Else
            Return False
        End If
    End Function


    <System.Runtime.CompilerServices.Extension> _
    Public Function BoolToInt(b As [Boolean]) As Integer
        If b = True Then
            Return 1
        Else
            Return 2
        End If
    End Function



    <System.Runtime.CompilerServices.Extension> _
 Public Function ToInt(s As String) As Integer

        Dim total = 0
        Dim y = 0
        For i As Integer = 0 To s.Length - 1
            y = y * 10 + (Asc(s(i)) - Asc("0"c))
        Next
        total = total + y
        Return total

    End Function


    <System.Runtime.CompilerServices.Extension> _
    Public Function ToDec(s As String) As Decimal
        If [String].IsNullOrEmpty(s) Then
            Return 0
        Else
            Return Decimal.Parse(s.Replace(".", ","))
        End If

    End Function

    <System.Runtime.CompilerServices.Extension> _
    Public Function ToDecDb(s As String) As String
        If [String].IsNullOrEmpty(s) Then
            Return "0"
        Else
            Return s.Replace(",", ".")
        End If

    End Function

    <System.Runtime.CompilerServices.Extension> _
    Public Function ToDate(s As String) As DateTime
        Return DateTime.Parse(s)
    End Function



    <System.Runtime.CompilerServices.Extension> _
    Public Function CpfCpnjMask(numCpfCnpj As String) As String
        If numCpfCnpj IsNot Nothing AndAlso numCpfCnpj <> [String].Empty Then

            If numCpfCnpj.Length = 14 Then
                Return numCpfCnpj.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-")
            ElseIf numCpfCnpj.Length = 11 Then
                Return numCpfCnpj.Insert(3, ".").Insert(7, ".").Insert(11, "-")
            Else
                Return numCpfCnpj
            End If
        End If

        Return [String].Empty

    End Function


    <System.Runtime.CompilerServices.Extension> _
    Public Function PhoneMask(numberPhone As String) As String
        If numberPhone IsNot Nothing AndAlso numberPhone <> [String].Empty Then
            If numberPhone.IndexOf("0", 0) = 0 Then
                numberPhone = numberPhone.Remove(0, 1)
            End If

            Return numberPhone.Insert(0, "(").Insert(3, ")").Insert(8, "-")
        End If

        Return [String].Empty
    End Function

    <System.Runtime.CompilerServices.Extension> _
    Public Function CnpjRemoveMask(cnpj As String) As String
        If cnpj IsNot Nothing AndAlso cnpj <> [String].Empty Then
            Return cnpj.Replace(".", "").Replace(".", "").Replace("/", "").Replace("-", "")
        End If

        Return [String].Empty
    End Function


End Module
