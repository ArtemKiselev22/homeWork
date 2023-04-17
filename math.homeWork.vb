Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, z, x, c, y As Double
        a = 1.5
        b = 0.7
        c = 2
        x = (MathF.Pow(MathF.E, a) - MathF.Cos(b)) / MathF.Sqrt(MathF.Abs(a * b * c))
        Console.WriteLine(x)
        y = (MathF.Log(a)) - b * c
        Console.WriteLine(y)
        z = MathF.Sin(x * y) + 2
        Console.WriteLine(z)
    End Sub
End Module
