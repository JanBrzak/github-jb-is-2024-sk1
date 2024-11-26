using System;
class Program
{
    static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int diference = Convert.ToInt32(Console.ReadLine());
        int prvni_prvek = Convert.ToInt32(Console.ReadLine());
        int c_prvek = prvni_prvek;
        int[] pole = new int[size];
        int soucet = 0;
        pole[0] = prvni_prvek;
       
        for (int i = 0; i < size; i++) 
        {
            if (i == 0) 
            {
                Console.WriteLine(pole[i] + ";");
            }
            else {
                c_prvek += diference;
                pole[i] = c_prvek;
                
                Console.Write(pole[i] + ";");
            }
            soucet +=  pole[i];

        }
        Console.WriteLine("Soucet zobrazench hodnot je: " + soucet);  

    } 

}