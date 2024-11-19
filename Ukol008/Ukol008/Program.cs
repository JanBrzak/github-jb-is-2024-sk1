using System;
class Program
{
    static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int hm = Convert.ToInt32(Console.ReadLine());
        int dm = Convert.ToInt32(Console.ReadLine());
        
        Random rand = new Random();
        int[] pole = new int[size];

        for (int i = 0; i < size; i++)
        {
            pole[i] = rand.Next(dm, hm);
            
        }
        void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
               
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
        void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int klic = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > klic)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = klic; 
            }
        }
        void ShakerSort(int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length - 1;

            while (swapped)
            {
                swapped = false;

                
                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;

                swapped = false;
                end--; 

                
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                start++; 
            }
        }
        void CombSort(int[] array)
        {
            int gap = array.Length;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                
                gap = (gap * 10) / 13;
                if (gap < 1) gap = 1;

                swapped = false;

                
                for (int i = 0; i + gap < array.Length; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        swapped = true;
                    }
                }
            }
        }
        void ShellSort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;

                    
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
                gap /= 2; 
            }
        }
        int[] pole1 = pole;
        int[] pole2 = pole;
        int[] pole3 = pole;
        int[] pole4 = pole;
        int[] pole5 = pole;
        SelectionSort(pole5);
        InsertionSort(pole4);
        SelectionSort(pole3);
        CombSort(pole2);
        ShellSort(pole1);
        void ShowArr(int[] array)
        {
            for(int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i]+", ");

            }
            Console.WriteLine(" ");
        }
        ShowArr(pole5);
        ShowArr(pole4);
        ShowArr(pole3);
        ShowArr(pole2);
        ShowArr(pole1);






    }

}