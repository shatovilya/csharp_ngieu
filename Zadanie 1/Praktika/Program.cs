using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praktika
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatingSystem os =
            System.Environment.OSVersion;
            Console.WriteLine("Platform: {0}",os.Platform);
            System.Console.WriteLine("The current date and time is " + System.DateTime.Now); // дата и время
            Console.WriteLine("Input x =\r");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (Math.Exp(-(x/2))*(Math.Cos(2*x - 0.3))) + (Math.Sqrt(x)/(2.7 + x));
            Console.WriteLine(" x = {0} \t y = {1}",x,y); 
            Console.Read();
        }
    }
}
