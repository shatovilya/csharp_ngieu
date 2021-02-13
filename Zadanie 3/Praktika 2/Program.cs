using System;

namespace Praktika_2
{
    class Program
    {
        static void Main(string[] args)
        {
        int N;
        m2: Console.WriteLine("Введите для точки M"+
        " координату по X ");
        float x = float.Parse((Console.ReadLine()));
        Console.WriteLine("Введите для точки M" + " координату по Y ");
        float y = float.Parse((Console.ReadLine()));
        if (x >= 12 || y >= 12 || x <= -12 || y <= -12 )

            { 
                N = 4; 
            }
            
        else
            if (((x > -12 && x <= 0) && (y < 12 && y >= 0)) || ((x < 12 && x >= 0) && (y <= 0 && y >- 12)))
                N = 3; 
            else
            {
                if ( y > x )
                    N = 1;
                else 
                {
                    N = 2;
                }
            }
        Console.WriteLine('\t' + " Результат:");
        Console.WriteLine(" Точка М("+ x + ";" + y + ")"
        + " лежит в обалсти N=" + N);
        Console.WriteLine('\n' +"Для повторного ввода" + " нажать любую клавишу."+'\n'+ "Для завершения программы нажмите Enter.");
        string p = Console.ReadLine();
        if (p != "") goto m2;
        }
    }
}
