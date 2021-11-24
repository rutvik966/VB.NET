Imports System.Console

Module Program
    Sub Main()

        Dim c As Integer


        Write("Enter celcius Value : ")
        c = ReadLine()

        WriteLine("Farenheit Is " & (c * 9 / 5) + 32)

    End Sub
End Module
