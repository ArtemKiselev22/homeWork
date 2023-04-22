Imports System

Module Program
    Sub Main(args As String())
        Dim x, y, z As Double
        x = (2.2) And (-5.3)
        If x > 2 Then
            y = x * Math.Log(Math.Abs(x))
        Else
            y = Math.Pow(x, 2)
        End If
        Console.WriteLine(y)

        z = 2 * Math.Pow(Math.Cos(Math.Pow(y, 3)), 2) - Math.Log(Math.Abs(y))
        Console.WriteLine(z)
    End Sub
End Module
