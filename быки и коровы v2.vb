Imports System


Module Program
    Sub Main(args As String())
        Dim N, ver As String
        Dim start, ent As Integer
        'TODO:   ���������� �����
        Console.WriteLine("����� ��������")
        Console.WriteLine("������")
        start = Console.ReadLine
        Console.WriteLine("�����")
        ent = Console.ReadLine
        N = Int((ent * Rnd()) + start)
        Console.WriteLine("������ �����")
        Console.Clear()
        Do
            ver = Console.ReadLine()
            Console.WriteLine("��� �������")
            For i = 0 To 3
                If (N.Chars(i) = ver.Chars(0)) Then
                    If i = 0 Then

                        Console.WriteLine("������ ����� ����� ������ - ���")
                    Else

                        Console.WriteLine("������ ����� ����� ������ - ������")
                    End If
                End If
            Next
        Loop Until N = ver

    End Sub
End Module

