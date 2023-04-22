Imports System

Module Program
    Sub Main(args As String())
        Dim x, y, z As Double
        MathX()
        Math5()
    End Sub

    Function MathX()
        Dim x, y, z As Double
        x = 2.2
        If x > 2 Then
            y = x * Math.Log(Math.Abs(x))
        Else
            y = Math.Pow(x, 2)
        End If
        Console.WriteLine("y1 = {0}", y)
        z = 2 * Math.Pow(Math.Cos(Math.Pow(y, 3)), 2) - Math.Log(Math.Abs(y))
        Console.WriteLine("z1 = {0}", z)
    End Function

    Function Math5()
        Dim x, y, z As Double
        x = -5.3
        If x > 2 Then
            y = x * Math.Log(Math.Abs(x))
        Else
            y = Math.Pow(x, 2)
        End If
        Console.WriteLine("y2 = {0}", y)
        z = 2 * Math.Pow(Math.Cos(Math.Pow(y, 3)), 2) - Math.Log(Math.Abs(y))
        Console.WriteLine("z2 = {0}", z)
    End Function
End Module
