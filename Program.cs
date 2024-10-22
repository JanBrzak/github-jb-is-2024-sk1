
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("vlozte vysku trojuhelniku:");
        int vyska = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("vlozte sirku trojuhelniku:");
        int sirka = Convert.ToInt32(Console.ReadLine());
        //if( sirka > 105){   
        //  Console.WriteLine("Tento trojuhelnik se nevejde do command line!");
        //}
        if ( vyska < 1) 
        {
            Console.WriteLine("vyska nemuze byt zaporna ani destinna");
        }
        else if(sirka < 1)
        {
            Console.WriteLine("sirka nemuze byt zaporna ani desetinna");
        }
        else {
            for (int j = 0; j < vyska; j++)
            {
                // pocet prvku "* " pro danou řádku
                int kalkulace_hvezdicek = (j + 1) * sirka / vyska;


                for (int i = 0; i < kalkulace_hvezdicek; i++)
                {
                    Console.Write("* ");
                }


                Console.WriteLine();
            }
        }
    }
}