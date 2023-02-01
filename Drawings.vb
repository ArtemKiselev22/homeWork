Imports System

Module Drawings
    Private brush As Char = "0"c
    Sub Main(args As String())
        Dim u As Integer


        For u = 0 To 4
            Console.WriteLine("Что ты хочешь, чтоб я нарисовал ")
            Console.WriteLine("1 = вертикальную линию,2 = горизонтальную,3 =  квадрат,4 =  цветной квадрат ?, 5 = самому нарисовать ")
            u = Console.ReadLine

            If u = 1 Then
                Console.SetWindowSize(100, 50)

                Vline(10, 5, 70)

                Console.WriteLine()
            End If

            If u = 3 Then
                Console.SetWindowSize(100, 50)

                FilRect(10, 5, 70, 35)

                Console.WriteLine()

            End If

            If u = 2 Then
                Console.SetWindowSize(100, 50)

                Hline(10, 5, 70)

                Console.WriteLine()

            End If

            If u = 4 Then
                Console.SetWindowSize(100, 50)

                Nova(10, 5, 70, 35)

                Console.WriteLine()

            End If

            If u = 6 Then
                Console.SetWindowSize(100, 50)

                line(10, 5, 70)

                Console.WriteLine()

            End If

            If u = 5 Then
                Console.SetWindowSize(100, 50)

                VIL()

                Console.WriteLine()

            End If
            Console.WriteLine("спасибо за просмотр!!! ")

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
        For j = 0 To heigh - 1
            Hline(leftX, topY + j, width)
        Next
    End Sub
    Sub line(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 0 To length - 1
            Console.Write(brush)
            Console.SetCursorPosition(leftX, topY + i)
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
