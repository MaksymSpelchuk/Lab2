using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть річний дохід користувача:");
        uint annualRevenue = uint.Parse(Console.ReadLine());

        double incomeTax = 0;

        if (annualRevenue <= 11000)
        {
            incomeTax = (annualRevenue * 8) / 100;
        }
        else if (annualRevenue > 11000 && annualRevenue <= 15000)
        {
            incomeTax = (annualRevenue * 11) / 100;
        }
        else if ( annualRevenue > 15000 && annualRevenue <= 19000)
        {
            incomeTax = (annualRevenue * 13) / 100;
        }
        else if ( annualRevenue > 19000)
        {
            incomeTax = (annualRevenue * 17) / 100;
        }
        Console.WriteLine($"Податок на дохід становить: {incomeTax}$");
    }

}
