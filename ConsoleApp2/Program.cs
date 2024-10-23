using System;
class Program
{
    static void Main(string[] args)
    {
        string cislo;
        cislo = Console.ReadLine();
        int input = 0;
        
        int imput = Int32.Parse(cislo);


        Console.WriteLine("Zadejte první číslo řady");
        //int first = int.Parse(Console.ReadLine());
        int first;
        while (!int.TryParse(Console.ReadLine(), out first))
        {
            Console.WriteLine("Nezadali jste cele cislo zadejte cislo znovu");
        }
        int last = 5;
        int current = first;
        while(current < last)
        {
            Console.WriteLine(current);
        }


        int[] carpark = new int[5];
        Console.WriteLine(first);

    }



}
