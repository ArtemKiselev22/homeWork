Imports System

Module Masiv
    Sub Main(args As String())
        Dim num(6), Mas As Integer
        'Dim Slovo() As String
        Console.WriteLine("have 5 numbers")
        Dim nas As String

        'For i = 0 To 4
        '    num(i) = Console.ReadLine()
        'Next

        'printRevers(Slovo)

        'Console.WriteLine("index = {0}", find(num, 21))

        Dim strings(4) As String

        For i = 1 To Strings.Length - 1
            Strings(i) = Console.ReadLine()
        Next
        Console.WriteLine("index = {0}", findStr(strings, 21))
    End Sub
    Sub printRevers(list As Integer())

        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next

    End Sub
    Sub printRevers(list As String())

        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next

    End Sub
    Sub print(list As Integer())

        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next

    End Sub
    Function find(list As Integer(), e As Integer) As Integer

        For f = 0 To 4
            If list(f) = e Then
                find = f
                Exit Function
            End If
        Next
        find = -1

    End Function

    Function findStr(list As String(), e As String) As Integer

        For f = 0 To 4
            If list(f) = e Then
                findStr = f
                Exit Function
            End If
        Next
        findStr = -1

    End Function
End Module
