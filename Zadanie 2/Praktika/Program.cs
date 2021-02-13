using System;
using System.IO;

namespace Praktika
{
    class Program
    {
        private const double V = 3.14;

        static void Main(string[] args)
        {
            double a;
            double c; 
            double i; 
            bool l; 
            string name; 
            Console.WriteLine("Input Имя");
            name = Console.ReadLine();
            Console.WriteLine("Input a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input i");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input l");
            l = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(" Результаты форматирования \n name = {0, 6}, l = {1, 4}", name,l);
            Console.WriteLine("a ={0}, c = {1}, i = {2}", a,c,i); 
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("LAB2.RES");
            StreamReader f1 = new StreamReader("LAB2.TXT");
            f.WriteLine(" Таблица значений\n");
            f.WriteLine("I--------------------------------------------I\n");
            f.WriteLine("I          X           I       Функция       \n");
            metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            x = Convert.ToDouble(s);
            double pi = V;
            double v = x * (1 + Math.Cos(pi * x));
            y = v;
            f.WriteLine("I      X = {0:f3}     I       Y= {1:f3}       I\n", x, y);
            goto metka;
            f.WriteLine("I--------------------------------------------I\n");
            metka1: f.WriteLine(" Составил Шатов Илья \n");
            f.Close();
            f1.Close();
            Console.ReadLine(); 
        }
    }
}
