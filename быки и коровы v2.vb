Imports System


Module Program
    Sub Main(args As String())
        Dim N, ver As String
        Dim bulls, cows As Integer
        Dim key As ConsoleKeyInfo
        Dim moves As Integer
        Console.WriteLine("key space")

        Do
            key = Console.ReadKey(True)
            Console.ForegroundColor = ConsoleColor.Green
            Randomize()
            Do
                N = Int((9000 * Rnd()) + 1000)
                Console.WriteLine(N)
            Loop Until CheckDublicates(N) = False

            Do
                ver = Console.ReadLine()
                moves += 1
                If CheckDublicates(ver) Then
                    Continue Do
                End If


                cows = 0
                bulls = 0
                For j As Byte = 0 To 3
                    For i As Byte = 0 To 3
                        If (N.Chars(i) = ver.Chars(j)) Then
                            If i = j Then

                                bulls += 1
                            Else

                                cows += 1
                            End If
                        End If

                    Next
                Next

                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("have you found the cows = {0}", cows)
                Console.WriteLine("have you found the bulls = {0}", bulls)

            Loop Until N = ver
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Victory")
            Console.WriteLine("Play again ? If yes = y if no = n ")
            Console.WriteLine("moves were made  = {0}", moves)
            Do
                key = Console.ReadKey(True)
            Loop Until key.KeyChar = "y"c Or key.KeyChar = "n"c
            Console.WriteLine(key.KeyChar)
            Console.Clear()
        Loop Until key.KeyChar = "n"c

    End Sub
    Function CheckDublicates(Num As String) As Boolean
        CheckDublicates = False
        For j = 0 To 2
            For i = j + 1 To 3
                If Num.Chars(j) = Num.Chars(i) Then
                    CheckDublicates = True
                End If
            Next
        Next

    End Function
End Module

