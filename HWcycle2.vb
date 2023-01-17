Imports System

Module HWcycle
    Sub Main(args As String())
        Dim a, p, n, i As Long
        Const max As Integer = 2147483647

        i = 1
        p = 1
        Console.WriteLine(" Введите количество вводимых чисел ")
        n = (Console.ReadLine())
        For i = 1 To n Step 1
            Console.WriteLine(" введите число ")
            a = (Console.ReadLine())
            p = p * a


        Next
        If (p > max / i) Then
            Console.Write(" Память перегружина !!!")
            Console.WriteLine(i - 1)

        End If
        Console.WriteLine(" Произведение N введенных Вами чисел равно ")
        Console.WriteLine(p)




    End Sub
End Module
