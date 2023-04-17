Imports System

Module SamMath
    Sub Main(args As String())
        Dim a, x, s, y, z As Double
        a = 121.3
        x = 0.75
        s = 0.393
        z = x * s / 2 - Math.Pow(a, 2) / 2 * Math.Log(x + s)
        y = Math.Sqrt(Math.Abs(Math.Pow(x, 2) - Math.Pow(a, 2))) + Math.Tan(2 * a / x + 0.184)
        Console.WriteLine(y)
    End Sub
End Module
