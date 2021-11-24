Imports System.Console

Module Program
    Sub Main()

        Dim a, b As Integer


        Write("Enter A Value : ")
        a = ReadLine()

        Write("Enter B Value : ")
        b = ReadLine()

        a = a + b
        b = a - b
        a = a - b

        WriteLine("After Swap A Value Is " & a)
        WriteLine("After Swap B Value Is " & b)

    End Sub
End Module
