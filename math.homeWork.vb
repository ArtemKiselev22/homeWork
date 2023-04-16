Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, z, x, c, abc, y As Double
        a = 1.5
        b = 0.7
        c = 2
        abc = 1.5 * 0.7 * 2
        x = MathF.Pow(MathF.E, a - MathF.Cos(b)) / MathF.Sqrt(MathF.Abs(abc))
        Console.WriteLine(x)
        y = MathF.Log(a) - b * c
        Console.WriteLine(y)
        z = MathF.Sin(x * MathF.Sin(y) + 2)
        Console.WriteLine(z)
    End Sub
End Module
