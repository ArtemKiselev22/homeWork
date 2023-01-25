Imports System
Imports System.Data
Imports System.Runtime.InteropServices


Module Program
    Sub Main(args As String())
        Dim S As String


        Console.WriteLine("Введите строку")
        S = Console.ReadLine()
        For i As Integer = 0 To S.Length - 1
            Console.Write(S.Chars(i))
            Console.WriteLine(Asc(S.Chars(i)))
            Select Case S
                Case 32
                    Console.WriteLine("Пробелы ")
                    Console.WriteLine(Asc(S.Chars(i)))
                Case 65 To 98
                    Console.Write(" Английский язык ")
            End Select

        Next
    End Sub
End Module