using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadejte přesnost algoritmu: ");
        double presnost;
        while (!double.TryParse(Console.ReadLine(), out presnost))
        {
            Console.WriteLine("Nezdadali jste správné číslo, zadejte přesnost znovu: ");

        }
        double i = 1;
        double pictvrt=1;
        double znamenko=1;
        while ((1 / i) >= presnost)
        {
            i = i + 2;
            znamenko = znamenko * (-1);
            pictvrt = pictvrt + znamenko * (1 / i);
            if (znamenko == 1)
            {

                Console.WriteLine("Zlomek: +1/{0}; aktualni hodnota PI = {1}", i,4*pictvrt);
            }
        }
        double pi = 4 * pictvrt;
        Console.WriteLine(pi);  

    }
}