
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("vlozte vysku tobdelniku:");
        int vyska = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("vlozte sirku obdelniku:");
        int sirka = Convert.ToInt32(Console.ReadLine());
       
        if (vyska < 1)
        {
            Console.WriteLine("vyska nemuze byt zaporna ani destinna");
        }
        else if (sirka < 1)
        {
            Console.WriteLine("sirka nemuze byt zaporna ani desetinna");
        }
        else
        {
            for (int j = 0; j < vyska; j++)
            {
               

                for (int i = 0; i < sirka; i++)
                {
                    Console.Write("* ");
                }


                Console.WriteLine();
            }
        }
    }
}