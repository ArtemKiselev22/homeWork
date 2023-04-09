Imports System
Imports System.Text.Json

Module Program
    Sub Main(args As String())
        Dim Naim As String
        Dim num As Integer
        Dim Mas As Double
        Dim key As ConsoleKeyInfo
        Console.ForegroundColor = ConsoleColor.Red
        Do
            Console.WriteLine("Добавте товар")
            Console.Write("Наименование  ")
            Naim = Console.ReadLine()
            Console.Write("Масса  ")
            Mas = Console.ReadLine()
            num = num + 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Ваш отчет")
            Console.WriteLine("Наименование = {0} ", Naim)
            Console.WriteLine("Масса = {0} ", Mas)
            Console.WriteLine("Номер ячейки = {0}", num)
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