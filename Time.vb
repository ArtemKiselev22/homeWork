Imports System

Module Program
    Sub Main(args As String())
        Dim sec, min, hour, min2, hor, min3, min4 As Integer
        Dim ver As String
        'Dim vrem As DateTime
        'Console.WriteLine("VREMY")
        'vrem = Console.ReadLine()

        Console.WriteLine("Enter the time in seconds")
        sec = Console.ReadLine()
        min = sec \ 60
        min2 = min * 60
        hour = sec Mod 60
        hor = min \ 60
        min3 = hor * 60
        min4 = min Mod 60
        Console.WriteLine("sekynd = {0}", hour)
        Console.WriteLine("Minut = {0}", min4)
        Console.WriteLine("chas = {0}", hor)
    End Sub
End Module
