Imports System

Module Program
    Sub Main(args As String())
        Dim x As Double
        x = 2.2
        MathX(x)
        x = -5.3
        MathX(x)

    End Sub

    Function MathX(x As Double)
        Dim y, z As Double
        If x > 2 Then
            y = x * Math.Log(Math.Abs(x))
        Else
            y = Math.Pow(x, 2)
        End If
        Console.WriteLine("y1 = {0}", y)
        z = 2 * Math.Pow(Math.Cos(Math.Pow(y, 3)), 2) - Math.Log(Math.Abs(y))
        Console.WriteLine("z1 = {0}", z)
    End Function
End Module
