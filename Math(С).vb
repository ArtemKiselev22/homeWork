Imports System

Module Program
    Sub Main(args As String())
        Dim x As Double
        x = -7
        Mat(x)
        x = 2
        Mat(x)
    End Sub

    Function Mat(x As Double)
        Dim y, c, b As Double
        b = Math.Pow(Math.E, x + 2) + 0.6
        c = Math.Pow(x, 2) - 1
        If x < 0 Then
            y = Math.Pow(Math.Cos(x), 2) + Math.Pow(Math.E, 2 - x)
        Else
            If x = 0 Then
                y = (2 - b) * c
            Else
                If x > 0 Then
                    y = b + Math.Pow((2 - x), 2)
                End If
            End If
        End If
        Console.WriteLine(y)
    End Function

End Module
