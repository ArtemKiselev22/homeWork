Imports System
Imports System.Drawing
Imports System.Linq.Expressions
Imports System.Runtime.Intrinsics.Arm

Module Drawings
    Private brush As Char = "0"c
    Sub Main()
        Dim u As Integer
        Dim key As ConsoleKeyInfo
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Do
            Console.WriteLine("Write a number and I'll draw it  ")
            Console.WriteLine(" 1 = vertical line,2 = horizontal line,3 = square,4 =  colored square ?, 5 = draw it yourself, 6 = lots of squares, 7 = lots of colored squares,8 = ornament, 9 = empty square, 0 = lines in a row, 10 = Ladder, 11 = chess, 12 = Striped squares, 13 = TV")
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
                    Line(10, 5, 70)

                Case 5
                    VIL()

                Case 7
                    Jline(10, 5, 70)

                Case 8
                    Fura(10, 5, 5, 5)

                Case 9
                    Square(10, 5, 10)

                Case 0
                    London(10, 5, 40)

                Case 10
                    Stairs(4, 1, 2)
                Case 11
                    Chess(4, 7, 7, 7)
                Case 12
                    'Kvadro(10, 5, 10)
                Case 13
                    LineTV(10, 5, 70, 10)
                Case 14
                    NEWLineTV(4, 5, 70, 3)

            End Select
            Console.WriteLine()
            Console.WriteLine(" Do you want something else? If yes - y if no - n")

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

    Sub Line(leftX As Byte, topY As Byte, length As Byte)

        For i = 1 To 8
            Hline(leftX, topY + i * 5, length)
            Vline(leftX * i, topY + 5, length - 33)
        Next

    End Sub
    Sub Jline(leftX As Byte, topY As Byte, length As Byte)
        Console.ForegroundColor = ConsoleColor.Green
        Console.BackgroundColor = ConsoleColor.Gray
        For i = 1 To 8
            Hline(leftX, topY + i * 5, length)
            Vline(leftX * i, topY + 5, length - 33)
        Next
    End Sub
    Sub Fura(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)

        For j = 1 To heigh
            For i = 1 To heigh
                FilRect(leftX + 10 * i, topY + j * 6, width, heigh)
            Next
        Next
    End Sub
    Sub Fur(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)

        'For j = 1 To 8
        '    For i = 1 To 8
        '        FilRect(4 * i * 2, j * 7, 7, 7)
        '    Next
        'Next

        For j = 1 To 8
            For i = 1 To 8
                FilRect(leftX * i * 2, j * topY, width, heigh)
            Next
        Next
    End Sub
    Sub Square(leftX As Byte, topY As Byte, length As Byte)
        Console.ForegroundColor = ConsoleColor.Yellow
        For j = 1 To 2
            Hline(leftX, topY * j, 10)
            Vline(leftX * j, topY, length - 3)
        Next
    End Sub
    Sub Ons()
        Console.ForegroundColor = ConsoleColor.Yellow
        Hline(7, 63, 65)
        Vline(7, 6, 59)
        Hline(7, 6, 65)
        Vline(71, 6, 59)

    End Sub
    Sub London(leftX As Byte, topY As Byte, length As Byte)

        For i = 1 To 6
            Hline(leftX, topY * i, length)
        Next

    End Sub
    Sub Stairs(leftX As Byte, topY As Byte, length As Byte)

        For i = 1 To 46
            Hline(leftX, topY + i, length * i)
        Next

    End Sub

    Sub VIL()
        Dim leftx, topY, Length, heit As Byte
        'Const brux As Char = "0"c
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
        Console.Write("What symbol should I draw ?")
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
    Sub Chess(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        Console.ForegroundColor = ConsoleColor.White

        fur(4, 7, 7, 7)
        For j = 1 To 8
            For i = 1 To 8
                If (i + j) Mod 2 = 1 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    FilRect(leftX * i * 2, j * topY, width, heigh)
                End If
            Next
        Next
        ons()
    End Sub
    'Sub Kvadro(leftX As Byte, topY As Byte, length As Byte)
    '    For i = 1 To 4
    '        Square(10 * i, 5 * i, 10 * i)
    '    Next
    'End Sub

    Sub LineTV(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        For j = 1 To heigh
            For i = 1 To heigh - 5
                Console.BackgroundColor = ConsoleColor.White
                Console.ForegroundColor = ConsoleColor.White
                Hline(leftX, topY * i + j, width)
            Next
        Next
        For j = 1 To heigh - 6
            For i = 1 To heigh - 3
                Console.BackgroundColor = ConsoleColor.Red
                Console.ForegroundColor = ConsoleColor.Red
                Hline(leftX, topY * i + j, width)
            Next
        Next
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.DarkBlue
    End Sub

    Sub NEWLineTV(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        Console.BackgroundColor = ConsoleColor.Red
        Console.ForegroundColor = ConsoleColor.Red
        FilRect(4, 5, 70, 40)

        For j = 1 To 2
            For i = 1 To 8
                Console.BackgroundColor = ConsoleColor.White
                Console.ForegroundColor = ConsoleColor.White
                FilRect(leftX, topY * i + j, width, heigh)
            Next
        Next
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.DarkBlue
    End Sub
End Module
