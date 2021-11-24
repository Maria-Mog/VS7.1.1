using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS7._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ребро куба, длиной а");
            double a = Convert.ToInt32(Console.ReadLine());
            double volumeCube, squareCube;
            CalcCube(a, out volumeCube, out squareCube);
            Console.WriteLine("Объем куба равен {0:f2} куб.ед.", volumeCube);
            Console.WriteLine("Площадь поверхности куба равна {0:f2} кв.ед.", squareCube);
            Console.ReadKey();
        }


        static void CalcCube(double a, out double volumeCube, out double squareCube)
        {
            volumeCube = Math.Pow(a, 3);
            squareCube = 6 * Math.Pow(a, 2);

        }
    }
}
