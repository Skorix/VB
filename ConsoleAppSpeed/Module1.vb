Module Module1

    Sub Main()
        Dim x, y, z As Single


        Console.Write("Введите скорость в км/ч: ")
        x = Console.ReadLine()

        Console.Write("Введите скорость в м/с: ")
        y = Console.ReadLine()


        z = x * 1000 / 3600


        If z > y Then
            Console.WriteLine("Большая скорость = {0} км/ч", x)
            Console.Read()
        Else Console.WriteLine("Большая скорость = {0} м/с", y)
            Console.Read()
        End If
    End Sub

End Module
