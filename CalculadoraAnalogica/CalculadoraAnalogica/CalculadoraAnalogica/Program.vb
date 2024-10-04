Imports System

Module Program

    ' declaração de váriaveis a utilizar no /Program/
    Public resultadoEcra As Integer
    Public opx As String

    Sub Main(args As String())

        Console.WriteLine("Escolha uma das sequintes opções a executar:")
        Console.WriteLine("SOMA - para somar")
        Console.WriteLine("SUBTRAIR - para subtrair")
        Console.WriteLine("A sua operação: ")

        opx = Console.ReadLine()

        If opx = "SOMA" Then
            'vai somar
            funcaoSoma()
            Console.WriteLine(resultadoEcra)

        ElseIf opx = "SUBTRAIR" Then
            'vai subtrair
            funcaoSubtrair()
            Console.WriteLine(resultadoEcra)

        Else
            Console.WriteLine("Operação não reconhecida")

        End If

    End Sub



    Sub funcaoSoma()
        Dim num1 As Integer
        Dim num2 As Integer

        Console.WriteLine("Escreva o 1 numero")
        num1 = Console.ReadLine()
        Console.WriteLine("Escreva o 2 numero")
        num2 = Console.ReadLine()
        resultadoEcra = num1 + num2
    End Sub

    Sub funcaoSubtrair()
        Dim num1 As Integer
        Dim num2 As Integer

        Console.WriteLine("Escreva o 1 numero")
        num1 = Console.ReadLine()
        Console.WriteLine("Escreva o 2 numero")
        num2 = Console.ReadLine()
        resultadoEcra = num1 - num2
    End Sub


End Module




