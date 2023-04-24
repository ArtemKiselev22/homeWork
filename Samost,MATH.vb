Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(MathX(3))
        Console.WriteLine(MathX(5.2))
    End Sub
    Function MathX(x As Double) As Double
        Dim z As Double
        If x > 0 Then
            z = 1
        Else
            z = Math.Pow(x, 2)
        End If
        MathX = Math.Pow(Math.E, z) + 3.5 - Math.Pow(Math.Cos(x * z), 3)
    End Function
End Module
