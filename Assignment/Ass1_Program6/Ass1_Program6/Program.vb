Imports System.Console

Module Program
    Sub Main()

        Dim a, b, c As Integer


        Write("Enter A Value : ")
        a = ReadLine()

        Write("Enter B Value : ")
        b = ReadLine()

        c = a
        a = b
        b = c

        WriteLine("After Swap A Value Is " & a)
        WriteLine("After Swap B Value Is " & b)

    End Sub
End Module
