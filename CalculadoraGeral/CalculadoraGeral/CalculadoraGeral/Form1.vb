Public Class Form1
    Dim op As String
    Dim num1 As Double
    Dim num2 As Double
    Dim res As Double


    Private Sub colocarNum(numero As Integer)
        If (Resultado.Text = "0") Then
            Resultado.Text = numero
        Else
            Resultado.Text = Resultado.Text & numero
        End If
    End Sub

    Private Sub Bot0_Click(sender As Object, e As EventArgs) Handles Bot0.Click
        colocarNum(0)
    End Sub

    Private Sub Bot1_Click(sender As Object, e As EventArgs) Handles Bot1.Click
        colocarNum(1)
    End Sub

    Private Sub Bot2_Click(sender As Object, e As EventArgs) Handles Bot2.Click
        colocarNum(2)
    End Sub

    Private Sub Bot3_Click(sender As Object, e As EventArgs) Handles Bot3.Click
        colocarNum(3)
    End Sub

    Private Sub Bot4_Click(sender As Object, e As EventArgs) Handles Bot4.Click
        colocarNum(4)
    End Sub

    Private Sub Bot5_Click(sender As Object, e As EventArgs) Handles Bot5.Click
        colocarNum(5)
    End Sub

    Private Sub Bot6_Click(sender As Object, e As EventArgs) Handles Bot6.Click
        colocarNum(6)
    End Sub

    Private Sub Bot7_Click(sender As Object, e As EventArgs) Handles Bot7.Click
        colocarNum(7)
    End Sub

    Private Sub Bot8_Click(sender As Object, e As EventArgs) Handles Bot8.Click
        colocarNum(8)
    End Sub

    Private Sub Bot9_Click(sender As Object, e As EventArgs) Handles Bot9.Click
        colocarNum(9)
    End Sub

    Private Sub Somar_Click(sender As Object, e As EventArgs) Handles Somar.Click
        Txtop.Text = "+"
        op = "+"
        TxtNumero1.Text = Resultado.Text
        Resultado.Text = "0"
    End Sub

    Private Sub BotCalcular_Click(sender As Object, e As EventArgs) Handles BotCalcular.Click
        num1 = TxtNumero1.Text
        num2 = Resultado.Text

        If op = "+" Then
            res = num1 + num2
        End If

        If op = "-" Then
            res = num1 - num2
        End If

        If op = "x" Then
            res = num1 * num2
        End If

        If op = "/" Then
            res = num1 / num2
        End If

        Resultado.Text = res
        TxtNumero1.Text = ""
        op = ""
        Txtop.Text = op
    End Sub

    Private Sub BotBackspace_Click(sender As Object, e As EventArgs) Handles BotBackspace.Click
        Resultado.Text = Resultado.Text.Remove(Resultado.Text.Length - 1)
        If (Resultado.Text = "") Then
            Resultado.Text = "0"
        End If
    End Sub

    Private Sub BotSubtrair_Click(sender As Object, e As EventArgs) Handles BotSubtrair.Click
        Txtop.Text = "-"
        op = "-"
        TxtNumero1.Text = Resultado.Text
        Resultado.Text = "0"
    End Sub

    Private Sub BotMultiplicar_Click(sender As Object, e As EventArgs) Handles BotMultiplicar.Click
        Txtop.Text = "x"
        op = "x"
        TxtNumero1.Text = Resultado.Text
        Resultado.Text = "0"
    End Sub

    Private Sub BotDividir_Click(sender As Object, e As EventArgs) Handles BotDividir.Click
        Txtop.Text = "/"
        op = "/"
        TxtNumero1.Text = Resultado.Text
        Resultado.Text = "0"
    End Sub

    Private Sub BotClean_Click(sender As Object, e As EventArgs) Handles BotClean.Click
        Resultado.Text = Resultado.Text.Remove(Resultado.Text.Length - 1)
        If (Resultado.Text = "") Then
            Resultado.Text = "0"
        End If

        If (Resultado.Text = "") Then
            Resultado.Text = "1"
        End If

        If (Resultado.Text = "") Then
            Resultado.Text = "2"
        End If
    End Sub

    Private Sub BotInverter_Click(sender As Object, e As EventArgs) Handles BotInverter.Click

        Resultado.Text = Resultado.Text.Remove(Resultado.Text.Length - 1)

        If (Resultado.Text = "") Then
            Resultado.Text = "-"
        End If

    End Sub
End Class
