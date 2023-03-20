Imports System
Imports System.Drawing
Imports System.Linq.Expressions
Imports System.Runtime.Intrinsics.Arm

Module Drawings
    Private brush As Char = "0"c
    Sub Main(args As String())
        Dim u As Integer
        Dim key As ConsoleKeyInfo
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Do
            Console.WriteLine(" Что ты хочешь, чтоб я нарисовал ")
            Console.WriteLine(" 1 = вертикальную линию,2 = горизонтальную,3 =  квадрат,4 =  цветной квадрат ?, 5 = самому нарисовать, 6 = сетка из квадратов, 7 = цветная сетка из квадратов,8 = орнамент из квадратиков, 9 = сделать пустой квадрат, 0 = линии, 10 = лестница, 11 = chess")
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
                    line(10, 5, 30)

                Case 5
                    VIL()

                Case 7
                    Jline(10, 5, 30)

                Case 8
                    fura(10, 5, 30)

                Case 9
                    square(10, 5, 30)

                Case 0
                    London(10, 5, 30)

                Case 10
                    stairs(10, 5, 30)
                Case 11
                    Chess(10, 5, 30)

            End Select
            Console.WriteLine()
            Console.WriteLine(" хотите еще что-нибудь нарисовать ? y или n ")

            Do
                key = Console.ReadKey(True)
            Loop Until key.KeyChar = "y"c Or key.KeyChar = "n"c
            Console.WriteLine(key.KeyChar)
            Console.Clear()
            Console.SetCursorPosition(1, 1)
        Loop Until key.KeyChar = "n"c

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

        For j = 1 To 8
            For i = 1 To 8
                FilRect(4 * i * 2, j * 7, 7, 7)
            Next
        Next

    End Sub
    Sub square(leftX As Byte, topY As Byte, length As Byte)
        Console.ForegroundColor = ConsoleColor.Yellow
        For j = 1 To 2
            Hline(10, 5 * j, 10)
            Vline(10 * j, 5, 7)
        Next
    End Sub
    Sub ons(leftX As Byte, topY As Byte, length As Byte)
        Console.ForegroundColor = ConsoleColor.Yellow
        Hline(7, 63, 65)
        Vline(7, 6, 59)
        Hline(7, 6, 65)
        Vline(71, 6, 59)
    End Sub
    Sub London(leftX As Byte, topY As Byte, length As Byte)
        For i = 1 To 6
            Hline(10, 5 * i, 40)
        Next

    End Sub
    Sub stairs(leftX As Byte, topY As Byte, length As Byte)

        For i = 1 To 46
            Hline(4, i, 2 * i)
        Next
    End Sub

    Sub VIL()
        Dim leftx, topY, Length, heit As Byte
        Const brux As Char = "0"c
        Dim f As Char
        Console.ForegroundColor = ConsoleColor.Red
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
                Console.BackgroundColor = ConsoleColor.Gray
                Console.Write(f)
                Console.SetWindowSize(100, 50)
            Next
            Console.SetCursorPosition(10, 3 + j)
        Next
    End Sub
    Sub Chess(leftX As Byte, topY As Byte, length As Byte)
        Console.ForegroundColor = ConsoleColor.White
        fura(10, 5, 30)
        For j = 1 To 8
            For i = 1 To 8
                If (i + j) Mod 2 = 1 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    FilRect(4 * i * 2, j * 7, 7, 7)
                End If
            Next
        Next
        ons(10, 5, 30)
    End Sub
End Module
