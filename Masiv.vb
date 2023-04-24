Imports System
Imports System.Net

Module Masiv
    Enum sortDirection
        increasing
        decrease
    End Enum
    Sub Main(args As String())
        Dim num(4), Mas As Integer
        'Dim Slovo() As String
        Console.WriteLine("have 5 Name")
        Dim m, n As Integer

        For i = 0 To 4
            num(i) = Console.ReadLine()
        Next

        'printRevers(Slovo)

        'Console.WriteLine("index = {0}", find(num, 21))

        'Dim strings(4) As String

        'For i = 0 To strings.Length - 1
        '    strings(i) = Console.ReadLine()
        'Next
        ''printRevers(strings)

        'Console.WriteLine("Write 5 values (Килограммы)")

        'For i = 0 To 4
        '    num(i) = Console.ReadLine()
        'Next
        'Console.WriteLine("Numbers")
        'For i = 0 To 4
        '    num(i) = Console.ReadLine()
        'Next
        ''n = min(strings)
        ''m = max(strings)
        ''Console.WriteLine("index = {0}, Min = {1}", n, strings(n))
        ''Console.WriteLine("index = {0}, Max = {1}", m, strings(m))
        ''add(num, "add", 2)


        'printRevers(strings)
        'printRevers(num)
        'Console.WriteLine("index = {0}", minInt(num))
        'delete(num, 2)
        'print(num)
        'Dim minIndex As Integer = min(num)
        'If minIndex > 0 Then
        '    Dim Boofer As String = num(0)
        '    num(0) = num(minIndex)
        '    num(minIndex) = Boofer
        'End If
        Sort(num, sortDirection.increasing)
        print(num)
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
    Function max(list As Integer(), Optional start As Integer = 0) As Integer
        max = 0
        For i = 1 To list.Length - 1
            If list(max) < list(i) Then
                max = i
            End If
        Next

    End Function

    Function min(list As Integer(), Optional start As Integer = 0) As Integer
        min = start
        For i = start To list.Length - 1
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

    Sub delete(ByRef list As String(), index As Integer)
        If index < 0 Or index >= list.Length Then Exit Sub
        For i As Integer = index To list.Length - 2

        Next
        ReDim Preserve list(list.Length - 2)
    End Sub

    Sub Sort(list As Integer(), derection As Boolean)
        Dim index As Integer
        Dim boofer As Integer
        For i = 0 To list.Length - 1
            If derection = sortDirection.increasing Then
                index = min(list, i)
            ElseIf derection = sortDirection.decrease Then
                index = max(list, i)
            End If
            If index > i Then
                boofer = list(index)
                list(index) = list(i)
                list(i) = boofer
            End If
        Next
    End Sub
End Module
