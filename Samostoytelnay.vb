Imports System
Imports System.Text.Json

Module Program
    Sub Main(args As String())
        Dim Naim As String
        Dim num, u As Integer
        Dim Mas As Double
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
                        Console.WriteLine("Ваш отчет")
                        Console.Write("Наименование  ")
                        Console.WriteLine(Naim)
                        Console.Write("Масса  ")
                        Console.WriteLine(Mas)
                        Console.Write("Номер ячейки ")
                        Console.WriteLine("= {0}", num)
                    Next
            End Select
        Loop Until False

    End Sub
End Module