Imports System
Imports System.Net

Module Masiv
    Sub Main(args As String())
        Dim num(4), Mas As String
        'Dim Slovo() As String
        Console.WriteLine("have 5 numbers")
        Dim m, n As Integer

        For i = 0 To 4
            num(i) = Console.ReadLine()
        Next

        'printRevers(Slovo)

        'Console.WriteLine("index = {0}", find(num, 21))

        Dim strings(4) As String

        'For i = 0 To strings.Length - 1
        '    strings(i) = Console.ReadLine()
        'Next
        'n = min(strings)
        'm = max(strings)
        'Console.WriteLine("index = {0}, Min = {1}", n, strings(n))
        'Console.WriteLine("index = {0}, Max = {1}", m, strings(m))
        add(num, "add", 2)


        'Console.WriteLine("index = {0}", minInt(num))
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

        For f = 0 To list.Length - 1
            If list(f) = e Then
                find = f
                Exit Function
            End If
        Next
        find = -1

    End Function

    Function findStr(list As String(), e As String) As Integer

        For f = 0 To list.Length - 1
            If list(f) = e Then
                findStr = f
                Exit Function
            End If
        Next
        findStr = -1

    End Function
    Function max(list As String()) As Integer
        max = 0
        For i = 1 To list.Length - 1
            If list(max) < list(i) Then
                max = i
            End If
        Next

    End Function

    Function min(list As String()) As Integer
        min = 0
        For i = 1 To list.Length - 1
            If list(min) > list(i) Then
                min = i
            End If
        Next

    End Function

    'Function minInt(list As Integer()) As Integer
    '    minInt = 0
    '    For i = 1 To list.Length - 1
    '        If list(minInt) > list(i) Then
    '            minInt = i
    '        End If
    '    Next

    'End Function

    Sub add(ByRef list As String(), val As String, index As Integer)
        If index < 0 Or index > list.Length Then Exit Sub
        ReDim Preserve list(list.Length)
        For i = list.Length - 1 To index + 1 Step -1
            list(i) = list(i - 1)
        Next
        list(index) = val
    End Sub
End Module
