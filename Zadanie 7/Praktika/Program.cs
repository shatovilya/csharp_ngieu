//Заданы вектора А(5), В(10), D(15).
//Для каждого из них определить максимальный и минимальный элементы
//и их индексы.


using System;
namespace Praktika
{
    class Program
    {
        class vect 
        {
        double[] a;
        int n;
        public vect(int n)
        {
            this.a = new double[n];
            this.n = n;
        }

        public int vv(string name)
        {
            Console.WriteLine("Начнем заполнение данных вектора" + " " + name +  " " + ":");
            for (int i = 0; i < a.GetLength(0); i++)
            {
            Console.WriteLine("Введите данные элемента" + " " + " " + i + " " + "вектора" + " " + name + ":");
            string buf;

            buf = Console.ReadLine();

            a[i] = Convert.ToDouble(buf);

            }
            return (0);
        }

        public int vyv(string name)

        {
            Console.WriteLine("Вывод данных вектора" + " " + name + ":");
            for (int i = 0; i < a.GetLength(0); i++)
            Console.WriteLine(name +"["+i+"]=" +a[i]);
            return (0);
        }

        public int FindMax(string name)
        {
            double[] maxEl = new double[n];
            int max;
            max = 0;
            for (int i = 1; i < a.GetLength(0); i++)
                if (a[i] > maxEl[i])
                {
                    maxEl[i] = a[i];
                    max = i;
                }
            Console.WriteLine("Максимальный элемент вектора" + " " + name + "[{0}]={1}", max, maxEl[max]);
            return (0);
        }

        public int FindMin(string name)
        {
            double[] minEl = new double[n];
            int min;
            min = 0;
            for (int i = 1; i < a.GetLength(0); i++)
                if (a[i] < minEl[i])
                {
                    minEl[i] = a[i];
                    min = i;
                }
            Console.WriteLine("Минимальный элемент вектора" + " " + name + "[{0}]={1}", min, minEl[min]);
            return (0);
        }

        }

        static void Main(string[] args)
        {
            // создание членов класса
            vect A = new vect(5);
            vect B = new vect(10);
            vect D = new vect(15);
            // ввод данных векторов в массивы
            A.vv("A");
            B.vv("B");
            D.vv("D");
            // ввод данных векторов из массива
            A.vyv("A");
            B.vyv("B");
            D.vyv("D");
            // Поиск и вывод минимальных элементов в векторах
            A.FindMax("A");
            A.FindMin("A");

            B.FindMax("B");
            B.FindMin("B");

            B.FindMax("D");
            B.FindMin("D");
            Console.ReadKey();
        }
    }
}
