Imports System

Module Program
    Sub Main(args As String())
        Dim x As Double
        x = 3
        MathX(x)
        x = 5.2
        MathX(x)
    End Sub

    Function MathX(x As Double)
        Dim y, z As Double
        If x > 0 Then
            z = 1
        Else
            If x <= 0 Then
                z = Math.Pow(x, 2)
            End If
        End If
        y = Math.Pow(Math.E, z) + 3.5 - Math.Pow(Math.Cos(x * z), 3)
        Console.WriteLine("y = {0}", y)
        Console.WriteLine("z = {0}", z)
    End Function

End Module
