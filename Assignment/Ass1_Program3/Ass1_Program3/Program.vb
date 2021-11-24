Imports System.Console

Module Program
    Sub Main()

        Dim sub1, sub2, sub3, sub4, sub5, sub6, sub7 As Integer


        Write("Enter 1st Subject Mark : ")
        sub1 = ReadLine()

        Write("Enter 2nd Subject Mark : ")
        sub2 = ReadLine()

        Write("Enter 3rd Subject Mark : ")
        sub3 = ReadLine()

        Write("Enter 4th Subject Mark : ")
        sub4 = ReadLine()

        Write("Enter 5th Subject Mark : ")
        sub5 = ReadLine()

        Write("Enter 6th Subject Mark : ")
        sub6 = ReadLine()

        Write("Enter 7th Subject Mark : ")
        sub7 = ReadLine()


        WriteLine("Total Mark Of All Subject Are " & sub1 + sub2 + sub3 + sub4 + sub5 + sub6 + sub7)
        WriteLine("Persentage Are " & (sub1 + sub2 + sub3 + sub4 + sub5 + sub6 + sub7) / 7)

    End Sub
End Module
