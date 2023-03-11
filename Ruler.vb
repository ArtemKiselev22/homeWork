Imports System
Imports System.Runtime.ConstrainedExecution

Module Program
    Sub Main(args As String())
        Dim ver, u, decimetr, santimetr, ost, metr, ostM, san As Integer
        Dim key As ConsoleKeyInfo
        Do
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("1 - Desimetr, 2 - Ruler , 3 - metr")
            u = Console.ReadLine()
            Console.WriteLine("Enter the time in seconds")
            ver = Console.ReadLine()
            Select Case u
                Case 1
                    decimetr = ver \ 10
                    Console.WriteLine("Desimetr = {0}", decimetr)
                Case 2
                    metr = ver \ 100
                    ostM = metr * 100
                    santimetr = ver Mod 100
                    decimetr = santimetr \ 10
                    san = santimetr Mod 10
                    Console.WriteLine("Metr = {0}", metr)
                    Console.WriteLine("Desimetr = {0}", decimetr)
                    Console.WriteLine("Santimetr = {0}", san)
                Case 3
                    metr = ver \ 100
                    Console.WriteLine("Metr = {0}", metr)
            End Select
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("Do you want to repeat it ? if yes - y if no - n")
            Do
                key = Console.ReadKey(True)
            Loop Until key.KeyChar = "y"c Or key.KeyChar = "n"c
            Console.WriteLine(key.KeyChar)
            Console.Clear()
        Loop Until key.KeyChar = "n"c
    End Sub

End Module
