Imports System

Module HWcycle
    Sub Main(args As String())
        Const MAX As Integer = 2147483647
        Dim N, B, F As Integer
        F = 1
        Console.WriteLine("������ ������  ����� ����� ")
        N = CInt(Console.ReadLine())
        Console.WriteLine("������ ������  ����� �����")
        B = CInt(Console.ReadLine())
        For i = 1 To N
            If (F < MAX / i) Then
                F = N * B
            Else
                Console.Write("������������ ������, ������ ���������� ��� N=")
                Console.WriteLine(i - 1)
                Exit For
            End If
        Next
        Console.Write("������������ ���� ����� =")
        Console.Write(F)












    End Sub
End Module
