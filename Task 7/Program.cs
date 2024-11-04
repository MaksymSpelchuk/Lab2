using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть число");
        int number = int.Parse(Console.ReadLine());


        if (number % 2 == 0 && number % 3 == 0)
        {
            Console.WriteLine("Введене число є парним і ділиться на 3");
        }
        else if (number % 2 == 0 && number % 3 != 0)
        {
            Console.WriteLine("Введене число є парним але не ділиться на 3");
        }
        else if (number % 2 != 0 &&  number % 3 == 0)
        {
            Console.WriteLine("Введене число є непарним і ділиться на 3");
        }
        else if (number % 2 != 0 && number % 3 != 0)
        {
            Console.WriteLine("Введене число є непарним і не ділиться на 3");
        }
    }
}
