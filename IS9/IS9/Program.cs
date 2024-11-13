using System;
using System.Diagnostics;
class Program{



    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int dm = Convert.ToInt32(Console.ReadLine());
        int  hm =  Convert.ToInt32(Console.ReadLine());
        int[] myArray = new int[n]; 
        int cislo;
        Random randomnumber = new Random();
        for (int i = 0; i < myArray.Length; i++)
        {

            myArray[i] = randomnumber.Next(dm,hm+1);
            Console.Write(myArray[i]);




        }
        Stopwatch myStopwatch = new Stopwatch();  
        myStopwatch.Start();
        int myCompare = 0;
        int myChange = 0;
        myCompare++;
        myChange++;
        for(int i = 0; i < n-1; i++)
        {
            for(int j = 0; j < myArray.Length; j++)
            {
                if (myArray[j] < myArray[j+1])
                {
                    myCompare++;
                    int pom = myArray[j + 1];
                    myArray[j+1] = myArray[j];
                    myArray[j] = pom;
                    myChange++;
                }
            }
            myStopwatch.Stop();
            for (int k = 0; k<n; k++ )
            {
                Console.Write(myArray[i]);  
            }




        }
    }


}



