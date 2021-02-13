using System;

namespace Praktika_1
{
    class Program
    {
        static void Main(string[] args)
        {
        double f;
        m1: Console.WriteLine(" Введите значение X");
        double x = float.Parse((Console.ReadLine()));
        Console.WriteLine(" Введите значение Y");
        double y = float.Parse((Console.ReadLine()));
        Console.WriteLine(" Введите значение Z");
        double z = float.Parse((Console.ReadLine()));
        double t = Convert.ToDouble(x*Math.Max((x+z),(z*y)));
        double s = Convert.ToDouble(Math.Min(x,y) + Math.Sqrt(x));


        if ((x != 0) && (z != 0) && (y != 0))
        {
            if (s!=0)
            {

                f = t/s;
                Console.WriteLine('\n' + " Дано: X= " + x + " y= " + y + " z= " + z + '\n'+ " Результат: F= " + f);
                goto m2;
                
            }
            else
            {
                Console.WriteLine("Уравнение не имеет решений при заданный параметрах");
                goto m2;
            }
        }
        else
        { 
            f = 0;
            Console.WriteLine('\n' + " Дано: X= " + x + " y= " + y + " z= " + z + '\n'+ " Результат: F= " + f);
            goto m2;
        } 

        m2: Console.WriteLine('\n' + "Для повторного ввода" + "набрать любую клавишу." +
        '\n'+ "Для завершения программы нажмите Enter.");
        string p = Console.ReadLine();
        if (p != "") goto m1;
        }
    }
}
