Imports System.Console

Module Program
    Sub Main()

        Dim a, j, k, l As Integer

        Write("Enter 1st Value : ")
        a = ReadLine()

        Write("Enter 2nd Value : ")
        j = ReadLine()


        WriteLine("Addition Is " & a + j)
        WriteLine("Multiplication Is " & a * j)
        WriteLine("Subtraction Is " & a - j)
        WriteLine("Modulation Is " & a Mod j)
        WriteLine("Division Is " & a / j)
        WriteLine("Integer Division Is " & a \ j)


    End Sub
End Module
