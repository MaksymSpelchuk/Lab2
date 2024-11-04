using System;


class Program
{
    static void Main()
    {
        double number;
        Console.WriteLine("Введіть число");
        number = Convert.ToDouble(Console.ReadLine());

        if (number < 0)
            Console.WriteLine("Дане число " + number + " є від'ємним");

        if (number > 0)
            Console.WriteLine("Дане число " + number + " є додатним");

        if (number == 0)
            Console.WriteLine("Дане число " + number + " дорівнює нулю");
    }
}
