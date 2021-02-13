//Задан массив размером N x N. Определить максимальный и минимальный элементы  
//главной диагонали и переставить местами столбцы в которых лежат эти элементы

using System;

namespace Praktika_1
{
    class Program
    {
        static void FindMax(int[,] arr, out int max)
        {
            int maxEl = arr[0, 0];
            max = 0;
            for (int i = 1; i < arr.GetLength(0); i++)
                if (arr[i, i] > maxEl)
                {
                    maxEl = arr[i, i];
                    max = i;
                }
            Console.WriteLine("Максимальный элемент главной диагонали: a[{0},{0}]={1}", max, maxEl);
        }
        static void FindMin(int[,] arr, out int min)
        {
            int minEl = arr[0, 0];
            min = 0;
            for (int i = 1; i < arr.GetLength(0); i++)
                if (arr[i, i] < minEl)
                {
                    minEl = arr[i, i];
                    min = i;
                }
            Console.WriteLine("Минимальный элемент главной диагонали: a[{0},{0}]={1}", min, minEl);
        }

        static void ChangeColumn(int[,] arr, int max, int min,int N)
        {
        int i;
        int j;
        int[,] temparray = new int[N, N];
        for (i = 0; i < N; ++i)
            {
                for (j = 0; j < N; ++j)
                {
                    temparray[i, j] = arr[i, max];
                    arr[i, max] = arr[i, min];
                    arr[i, min] = temparray[i, j];
                }
            }
        }

        static void writemassiv(int[,] arr, int N)
        {
        string strValue;
        int i;
        int j;
        for (i = 0; i < N; ++i)
            {
                for (j = 0; j < N; ++j)
                {
                    // ввод и присвоение значений
                    Console.WriteLine("\n Введите элемент" + i + ":" + j + "массива  iArray1 ");
                    strValue = Console.ReadLine();
                    arr[i, j] = Convert.ToInt32(strValue);
                }
            }
        }

        static void readmassiv(int[,] arr, int N)
        {
        int i;
        int j;
        for (i = 0; i < N; ++i)
                {    
                    for (j = 0; j < N; j++) 
                    {
                        Console.Write("{0, 5}", arr[i, j] );
                        
                    }
                    Console.Write("\n");
                }    
        }

        static void Main(string[] args)
        {
        int N;
        Console.WriteLine("\n Введите параметр N:");
        N = Convert.ToInt32(Console.ReadLine());
        int[,] iArray1 = new int[N, N];


       

        // вывод значений массива iArray на экран
        


        int indMax, indMin;
        writemassiv(iArray1, N);
        Console.WriteLine("\n Массив до перестановки столбцов");
        readmassiv(iArray1, N);
        FindMax(iArray1, out indMax);            //метод поиска индекса максимального элемента
        FindMin(iArray1, out indMin);           //метод поиска индекса минимального элемента
        ChangeColumn(iArray1, indMax, indMin, N); //метод замены местами колонок с максимальным и минимальным элементами
        Console.WriteLine("\n Массив после перестановки столбцов");
        readmassiv(iArray1, N);                   //чтение массива после замены столбцов
        Console.ReadKey();
    }
    }
}