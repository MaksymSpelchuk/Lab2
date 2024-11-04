using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть букву англійського алфавіту");
        char input = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();


        if (!char.IsLetter(input))
        {
            Console.WriteLine("Введений символ не є літерою");
            return;
        }
        switch (input)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("Введенна літера є голосною");
                break;
            default:
                Console.WriteLine("Введенна літера є приголосною");
                break;

        }

    }

}
