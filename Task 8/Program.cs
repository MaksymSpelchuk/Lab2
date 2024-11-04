using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть довжину сторони a");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину сторони b");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину сторони c");
        double sideC = Convert.ToDouble(Console.ReadLine());


        if (sideA > sideB && sideA > sideC)
        {
            Console.WriteLine("Сторона a є найдовшою");
        }
        else if (sideB > sideA && sideB > sideC)
        {
            Console.WriteLine("Сторона b є найдовшою");
        }
        else if (sideC > sideA && sideC > sideB)
        {
            Console.WriteLine("Сторона c є найдовшою");
        }
    }
}