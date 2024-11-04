using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Введіть рік");
        int year = Convert.ToInt32(Console.ReadLine());


        if (year % 4 == 0 & year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine("Даний рік " + year + " є високосним");
        }
        else if (year == 2000)
        {
            Console.WriteLine("Даний рік " + year + " є високосним");
        }
        else
        {
            Console.WriteLine("Даний рік " + year + " не є високосним");
        }
    }
}
