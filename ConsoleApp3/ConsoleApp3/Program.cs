using System;

class Program
{
    static void Main()
    {
        Console.Write("vložte liche cislo: ");
        int height = int.Parse(Console.ReadLine());
        


        if (height % 2 == 0) height--;
        Console.WriteLine("Plny kosocvtverec:");
        DrawFullDiamond(height);

        Console.WriteLine("Prazdny kosoctverec:");
        DrawEmptyDiamond(height);
        Console.WriteLine("Presipaci hodiny:");
        DrawFullHourglass(height);


    }


    static void DrawFullHourglass(int height)
    {
        int mid = height / 2;


        for (int i = 0; i <= mid; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (j >= i && j < height - i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }


        for (int i = mid - 1; i >= 0; i--)
        {
            for (int j = 0; j < height; j++)
            {
                if (j >= i && j < height - i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    static void DrawEmptyDiamond(int height)
    {
        int mid = height / 2;

       
        for (int i = 0; i <= mid; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (j == mid - i || j == mid + i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        
        for (int i = mid - 1; i >= 0; i--)
        {
            for (int j = 0; j < height; j++)
            {
                if (j == mid - i || j == mid + i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }


    }
    static void DrawFullDiamond(int height)
    {
        int mid = height / 2;  

       
        for (int i = 0; i <= mid; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (j >= mid - i && j <= mid + i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        
        for (int i = mid - 1; i >= 0; i--)
        {
            for (int j = 0; j < height; j++)
            {
                if (j >= mid - i && j <= mid + i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

}