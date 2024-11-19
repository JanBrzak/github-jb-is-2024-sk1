using System;
class Program
{
    static void Main(string[] args)
    {
        int a = 0; int b = 0;
        Console.WriteLine("Zadejte velikost pole: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadejte horní mez: ");
        int hm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadejte dolní mez: ");
        int dm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");

        Random randomNum = new Random();
        int[] pole = new int[size];
        Console.WriteLine("NonReversedArray: ");
        for (int i = 0; i < size; i++)
        {
            pole[i] = randomNum.Next(dm, hm);
            Console.Write(pole[i]+", ");
        }
        Console.WriteLine(" ");
        for(int j = 0; j < pole.Length; j++)
        {
           a = pole[j];
            for (int k = pole.Length/2; k < 0; k--) 
            {
                b = pole[k];
                pole[j] = b;
                pole[k] = a;
            }

           
        }
        Console.WriteLine("ReversedArray: ");

        for (int c = 0; c < pole.Length; c++) 
        {
            Console.Write(pole[c]+" ,");
         }
    }
}