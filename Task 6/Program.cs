using System;
using System.ComponentModel.Design;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть кількість років");
        int age = Convert.ToInt32(Console.ReadLine());
        

        if(age < 0)
        {
            Console.WriteLine("Неправильно введена кількість років");
        }
        else if (age >= 12 && age <= 18)
        {
            Console.WriteLine("Задана кількість років є підлітковим");
        }
        else
        {
            Console.WriteLine("Задана кількість років не є підлітковим");
        }
    }   
}
