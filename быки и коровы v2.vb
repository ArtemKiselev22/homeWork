Imports System


Module Program
    Sub Main(args As String())
        Dim N, ver As String
        Dim start, ent As Integer
        'TODO:   Генерируем число
        Console.WriteLine("Введи диапозон")
        Console.WriteLine("Начало")
        start = Console.ReadLine
        Console.WriteLine("Конец")
        ent = Console.ReadLine
        N = Int((ent * Rnd()) + start)
        Console.WriteLine("Угадай число")
        Console.Clear()
        Do
            ver = Console.ReadLine()
            Console.WriteLine("Еще попытка")
            For i = 0 To 3
                If (N.Chars(i) = ver.Chars(0)) Then
                    If i = 0 Then

                        Console.WriteLine("Первая цифра вашей версии - БЫК")
                    Else

                        Console.WriteLine("Первая цифра вашей версии - Корова")
                    End If
                End If
            Next
        Loop Until N = ver

    End Sub
End Module

