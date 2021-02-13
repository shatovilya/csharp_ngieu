using System;
using System.IO;

namespace Praktika_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter p = new StreamWriter("rez.txt");
            double a,x,y;
            p.WriteLine(" Результаты расчета");
            for (a = 1; a <= 2; a += 0.5f) // заголовок внешнего
            // цикал по а
            {
            // Начало внешнего цикла по а
            p.WriteLine(" a=" + a);
            for (x = -3; x <= 3; x += 0.2f) //Заголовок
            // внутреннего
            // цикла по х
            {
            // Началов внутреннего цикла по x
            y = (a*x)/(a + Math.Pow((1+ Math.Sqrt(x)),-3));
            p.WriteLine(" x= " + x + '\t' + " y= " + y);
            /* Конец внутреннего цикла по  x */
            }
            /* Конец внешнего цикла по a */
            }
            p.Close();
            Console.ReadLine();
        }
    }
}
