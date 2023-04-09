Imports System
Imports System.Text.Json

Module Program
    Sub Main(args As String())
        Dim Naim As String
        Dim u As Integer
        Dim Mas As Double
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Сколько всего товаров вы добавите ?")
        u = Console.ReadLine()
        For i = 1 To u
            Console.WriteLine("Добавте товар")
            Console.Write("Наименование  ")
            Naim = Console.ReadLine()
            Console.Write("Масса  ")
            Mas = Console.ReadLine()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Ваш отчет")
            Console.WriteLine("Наименование = {0} ", Naim)
            Console.WriteLine("Масса = {0} ", Mas)
            Console.WriteLine("Номер ячейки = {0}", i)
            Console.ForegroundColor = ConsoleColor.Red
        Next

    End Sub
End Module