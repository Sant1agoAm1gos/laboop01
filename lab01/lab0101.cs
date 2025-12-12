using System;

class lab01
{
    static void Main()
    {

        Console.Write("введіть суму у гривнях: ");
        double uah = Convert.ToDouble(Console.ReadLine());

        Console.Write("введіть курс долара: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        double usd = uah / rate;
        Console.WriteLine("в доларах: " + Math.Round(usd, 2));
    }
}