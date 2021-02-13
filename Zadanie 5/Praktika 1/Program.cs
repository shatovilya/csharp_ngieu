using System;

namespace Praktika_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, k, g, temp;
            int jBB =0;
            // начальное значение
            string strValue;
            Console.WriteLine("Введите размер одномерного массива B \n");
            g = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[g];
            for (j = 0; j < g; j++)
            {
                Console.WriteLine("Введите значение элемента " + j + " в массиве B");
                strValue = Console.ReadLine();
                // ввод и присваивание
                B[j]= Convert.ToInt32(strValue);
                jBB += 1;
            }
            Console.WriteLine("\n массив B[] \n\n");
            foreach (int jj in B)
            { 
                Console.Write(" " + jj); 
            } 
            jBB -= 1;
            for (k = 0; k < jBB; k++)
            {
                for (j = 0; j < jBB; j++)
                {
                    if (B[j + 1] > B[j])
                    {
                        temp = B[j];
                        B[j] = B[j + 1];
                        B[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n Отсортированный массив B[] \n\n");
            foreach (int jj in B)
            { 
                Console.Write(" " + jj); 
            }
            Console.WriteLine("\n\n");
            Console.ReadLine();

        }
    }
}
