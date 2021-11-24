using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS7._1._1
{
    class Program
    {
        //Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон). 
        static void Main(string[] args)
        {
            //пользователь вводит стороны треугольника верно
            Console.WriteLine("Введите сторону первого треугольника, длиной а");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону первого треугольника, длиной в ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону первого треугольника, длиной с ");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону втогоро треугольника, длиной а ");
            double a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону втогоро треугольника, длиной в ");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону втогоро треугольника, длиной с ");
            double c1 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Площадь первого треугольника S1 равна {0:f2} \nПлощадь второго треугольника S2 равна {1:f2} ", CalcArea(a, b, c), CalcArea(a1, b1, c1));                       
            double s1 = (CalcArea(a, b, c) > CalcArea(a1, b1, c1)) ? CalcArea(a, b, c) : CalcArea(a1, b1, c1);
            Console.WriteLine("Площадь наибольшего треугольника = {0:0.00} ", s1);
            Console.ReadKey();

        }
        static double CalcArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2; //полупериметр            
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;


        }

    }
    
}
