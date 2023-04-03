Imports System
Imports System.Text.Json

Module Program
    Sub Main(args As String())
        Dim Naim As String
        Dim num, u As Integer
        Dim Mas As Double
        Dim key As ConsoleKeyInfo
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Нажмите 1")
        u = Console.ReadLine

        Do
            Console.WriteLine("Добавте товар")
            Select Case u
                Case 1
                    Console.Write("Наименование  ")
                    Naim = Console.ReadLine()
                    Console.Write("Масса  ")
                    Mas = Console.ReadLine()
                    For i = 1 To u
                        num = num + 1
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Ваш отчет")
                        Console.Write("Наименование  ")
                        Console.WriteLine(Naim)
                        Console.Write("Масса  ")
                        Console.WriteLine(Mas)
                        Console.Write("Номер ячейки ")
                        Console.WriteLine(num)
                    Next
            End Select
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("add a product ?")
            Console.WriteLine("Yes = y , Not = n")
            Do
                key = Console.ReadKey(True)
            Loop Until key.KeyChar = "y"c Or key.KeyChar = "n"c
            Console.WriteLine(key.KeyChar)
            Console.Clear()
        Loop Until key.KeyChar = "n"c


    End Sub
End Module