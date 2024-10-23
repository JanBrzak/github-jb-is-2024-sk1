using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("zadejte pocet generovanych cisel");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n)) ;
        Console.WriteLine("zadejte dolni mez");
        int dm;
        while (!int.TryParse(Console.ReadLine(), out dm)) ;
        Console.WriteLine("zadejte horni mez");
        int hm;
        while (!int.TryParse(Console.ReadLine(), out hm)) ;
        Console.WriteLine();
        Console.WriteLine("Zadane hodnoty: ");
        Console.WriteLine("Pocčet čísel:{0}; dolní mez: {1}; horní mez: {2};", n, dm, hm);

        //deklarace pole
        int[] pole = new int[n];
        Random randomNumber = new Random();
        for (int i = 0; i < n; i++)
        {
            pole[i] = randomNumber.Next(dm, hm);
            Console.WriteLine("{0};", pole[i]);
        }
        int kladna = 0;
        int zaporna = 0;
        int nula = 0;
        int sude = 0;
        int liche = 0;
        int amogus;
        for (int j = 0; j < pole.Length; j++)
        { 
            amogus = pole[j] % 2;
            if (pole[j] > 0)
            {
                kladna++;
            }
            else if (pole[j] < 0)
            {
                zaporna++;
            }
            else 
            {
                nula++;
            }
            if (amogus == 0)
            {
                sude++;
            }
        else 
            { 
                liche++;
            }
            }
                
            
        
        Console.WriteLine("kladna: {0};,zaporna {1};, nula {2} suda {3} licha {4}; ",kladna,zaporna,nula,sude,liche);



        
        



    }

}
