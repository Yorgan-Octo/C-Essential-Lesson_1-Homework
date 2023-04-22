using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point a = new Point(0, 1, "A");
            Point b = new Point(0, 3, "B");
            Point c = new Point(3, 1, "C");

            Point d = new Point(7, 2, "D");

            Point i = new Point(1, 5, "I");


            Figure figure = new Figure(a, b, c);
            figure.PerimeterCalculator();

            Figure figure2 = new Figure(a, b, c, d);
            figure2.PerimeterCalculator();

            Figure figure3 = new Figure(a, b, c, d, i);
            figure3.PerimeterCalculator();


            Console.ReadKey();
        }
    }
}
