Imports System
Imports System.Drawing
Imports System.Runtime.Intrinsics.Arm

Module Drawings
    Private brush As Char = "0"c
    Sub Main(args As String())
        Dim u As Integer

        For u = 0 To 8
            Console.WriteLine(" Что ты хочешь, чтоб я нарисовал ")
            Console.WriteLine(" 1 = вертикальную линию,2 = горизонтальную,3 =  квадрат,4 =  цветной квадрат ?, 5 = самому нарисовать, 6 = сетка из квадратов, 7 = цветная сетка из квадратов  ")
            u = Console.ReadLine
            Console.SetWindowSize(100, 50)
            Select Case u
                Case 1

                    Vline(10, 5, 30)
                Case 3

                    FilRect(10, 5, 70, 35)

                Case 2

                    Hline(10, 5, 30)

                Case 4

                    Nova(10, 5, 70, 35)
                Case 6

                    line(10, 5, 60)

                Case 5

                    VIL()
                Case 7
                    Jline(10, 5, 60)
                Case 8

                    fura(10, 5, 60)
            End Select
            Console.WriteLine()
            Console.WriteLine(" спасибо за просмотр!!! ")

        Next

    End Sub

    Sub Hline(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 1 To length
            Console.Write(brush)
        Next

    End Sub
    Sub Vline(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 0 To length - 1
            Console.Write(brush)
            Console.SetCursorPosition(leftX, topY + i)
        Next

    End Sub

    Sub FilRect(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        Console.SetCursorPosition(leftX, topY)
        For j = 0 To heigh - 1
            Hline(leftX, topY + j, width)
        Next

    End Sub
    Sub Nova(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        Console.SetCursorPosition(leftX, topY)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.BackgroundColor = ConsoleColor.Magenta
        For j = 0 To heigh - 1
            Hline(leftX, topY + j, width)
        Next

    End Sub

    Sub line(leftX As Byte, topY As Byte, length As Byte)

        For i = 1 To 8
            Hline(2 + 10, 2 + i * 5, 70)
            Vline(2 + 10 * i, 2 + 5, 37)
        Next

    End Sub
    Sub Jline(leftX As Byte, topY As Byte, length As Byte)
        Console.ForegroundColor = ConsoleColor.Green
        Console.BackgroundColor = ConsoleColor.Gray
        For i = 1 To 8
            Hline(2 + 10, 2 + i * 5, 70)
            Vline(2 + 10 * i, 2 + 5, 37)
        Next

    End Sub
    Sub fura(leftX As Byte, topY As Byte, length As Byte)

        For i = 1 To 5
            FilRect(5 + 5 * i, 4, 3, 3)

        Next

    End Sub
    Sub VIL()
        Dim leftx, topY, Length, heit As Byte
        Const brux As Char = "0"c
        Dim f As Char
        Console.Write("heit=")
        heit = Console.ReadLine
        Console.Write("left=")
        leftx = Console.ReadLine
        Console.Write("top=")
        topY = Console.ReadLine
        Console.Write("length=")
        Length = Console.ReadLine
        Console.Write("Какой буквой будем писать ?")
        f = Console.ReadLine

        Console.SetCursorPosition(10, 60)
        Console.SetWindowSize(100, 50)
        For j = 1 To 10

            For i = 1 To 50
                Console.Write(f)
                Console.SetWindowSize(100, 50)
            Next
            Console.SetCursorPosition(10, 3 + j)
        Next

    End Sub

End Module
