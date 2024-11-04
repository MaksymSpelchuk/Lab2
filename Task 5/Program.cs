using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть третє число");
        double number3 = double.Parse(Console.ReadLine());


        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine("Найбільше число з введених є " + number1);
        }
        else if(number2 > number1 && number2 > number3)
        {
            Console.WriteLine("Найбільше число з введених є " + number2);
        }
        else if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine("Найбільше число з введених є " + number3);
        }
        
    }
}