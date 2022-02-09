'Fallon Smith
'RCET0265
'Spring 2022
'Multiplication Table
'

Option Explicit On
Option Strict On

Module MultiplicationTable

    Sub Main()

        Dim tableDimensions As Integer
        Dim wholeNumber As Boolean

        Do While wholeNumber = False
            Try
                Console.WriteLine("Please type a number.")
                tableDimensions = CInt(Console.ReadLine())
                wholeNumber = True
            Catch
                wholeNumber = False
            End Try
        Loop
        'Keeps promting user until they type a number

        Console.WriteLine("Enjoy your " & tableDimensions & " X " & tableDimensions &
                                  " multiplication table")

        For row = 1 To tableDimensions
            For col = 1 To tableDimensions
                Console.Write(Str(col * row).PadLeft(5))

            Next
            Console.WriteLine()
        Next

        Console.Read()
    End Sub


End Module
