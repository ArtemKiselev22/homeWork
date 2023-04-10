Imports System
Imports System.ComponentModel

Module Program
    Sub Main(args As String())
        Dim x, y, a, b, z As Double
        x = 2.6
        y = -3.1
        Console.WriteLine(Math.Pow(2, 3))
        Math.Cos(a)
        a = Math.Pow(Math.Cos(Math.Pow(x, 2) - Math.Pow(Math.E, x)), 3)
        'Console.WriteLine(a)
        b = Math.Sqrt(x + 4 - Math.Abs(y))
        z = a * Math.Sin(b) - Math.Pow(x, 1 / 3)
        Console.WriteLine(z)
    End Sub
End Module
