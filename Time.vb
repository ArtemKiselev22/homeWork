Imports System

Module Program
    Sub Main(args As String())
        Dim ver, min, sekynd, min2, hour, ostatokmin, minut As Integer
        'Dim vrem As DateTime
        'Console.WriteLine("VREMY")
        'vrem = Console.ReadLine()
        Console.WriteLine("Enter the time in seconds")
        ver = Console.ReadLine()
        min = ver \ 60
        min2 = min * 60
        sekynd = ver Mod 60
        hour = min \ 60
        ostatokmin = hour * 60
        minut = min Mod 60
        Console.WriteLine("sekynd = {0}", sekynd)
        Console.WriteLine("Minut = {0}", minut)
        Console.WriteLine("chas = {0}", hour)
    End Sub
End Module
