Module Module1

    '*****************************************************************************
    '***    BY MISTAKE I DID THE QUEUE CODE HERE AND THE STACK IN THE QUEUE    ***
    '*****************************************************************************




    Const null As Integer = -1
    Public Structure Node
        Dim data As String
        Dim ptr As Integer
    End Structure

    Public Structure Queue
        Dim flp, start, finish As Integer
        Dim list() As Node

        Sub init(ByVal size As Integer)

            size = size - 1
            ReDim list(size)

            start = null
            finish = null


            For x = 0 To size - 1
                list(x).ptr = x + 1
                list(x).data = ""
            Next
            flp = 0
            list(size).ptr = null

        End Sub

        Sub insert(ByVal dat As String)
            Dim tmp As Integer = flp
            If start = null Then
                list(flp).data = dat
                flp = list(flp).ptr
                list(tmp).ptr = null
                start = tmp
                finish = tmp
                Return
            End If

            list(flp).data = dat
            flp = list(flp).ptr
            list(finish).ptr = tmp
            finish = tmp

            Return
        End Sub



        Sub print()
            If start = null Then
                Console.WriteLine("Nothing")
                Return
            End If
            Dim c As Integer = start
            Do While c <> null
                Console.WriteLine(list(c).data)
                c = list(c).ptr
            Loop
        End Sub

        Sub delete()
            Dim tmp As Integer = start
            start = list(start).ptr
            list(tmp).ptr = flp
            flp = tmp
        End Sub
    End Structure



    Sub Main()
        Dim bank As Queue
        Dim dat As String
        bank.init(5)

        bank.print()

        For x = 1 To 5
            Console.WriteLine("enter val")
            dat = Console.ReadLine
            bank.insert(dat)
            Console.Clear()
        Next
        bank.print()

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        bank.delete()
        bank.print()

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        bank.insert("6")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        bank.print()
    End Sub

End Module
