Module Module1

    Sub Main()
        Dim x, y, z As Single


        Console.WriteLine("Введите первое слагаемое:")
        x = Console.ReadLine()

        Console.WriteLine("Введите второе слагаемое:")
        y = Console.ReadLine()

        z = x + y

        Console.WriteLine("{0} + {1} = {2}", x, y, z)
        Console.Read()
    End Sub

End Module
