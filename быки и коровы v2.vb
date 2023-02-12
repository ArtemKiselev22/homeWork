Imports System


Module Program
    Sub Main(args As String())
        Dim N, ver As String
        Dim start, ent As Integer
        Dim bulls, cows As Integer

        'TODO:   Генерируем число
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Введи диапозон")
        Console.WriteLine("Начало")
        start = Console.ReadLine
        Console.WriteLine("Конец")
        ent = Console.ReadLine
        N = Int((ent * Rnd()) + start)
        Console.WriteLine(N)
        Console.WriteLine("Угадай число")

        Do

            ver = Console.ReadLine()
            For j As Byte = 0 To 3
                For i As Byte = 0 To 3
                    If (N.Chars(i) = ver.Chars(j)) Then
                        If i = j Then
                            Console.WriteLine(j + 1)
                            bulls += 1
                        Else
                            Console.WriteLine(j + 1)
                            cows += 1
                        End If
                    End If
                Next
            Next
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("have you found the cows = {0}", cows)
            Console.WriteLine("have you found the bulls = {0}", bulls)
        Loop Until N = ver
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Victory")

    End Sub
End Module

