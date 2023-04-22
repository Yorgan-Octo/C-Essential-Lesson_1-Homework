using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Figure
    {

        //Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point.
        //Створити два методи: double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника; 
        //void PerimeterCalculator(), що розраховує периметр багатокутника.

        private Point[] points;
        private string nameFigyre;

        public Figure(Point a, Point b, Point c)
        {
            points = new Point[] { a, b, c };
            nameFigyre = "Треугольник";
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            points = new Point[] { a, b, c, d };
            nameFigyre = "Квадрат";
        }

        public Figure(Point a, Point b, Point c, Point d, Point i)
        {
            points = new Point[] { a, b, c, d, i };
            nameFigyre = "Пятиугольник";
        }

        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }

            perimeter += LengthSide(points[points.Length - 1], points[0]);

            string tempName = default;
            foreach (var item in points)
            {
                tempName += item.Name + ",";
            }


            Console.WriteLine(new String('-',70));
            Console.WriteLine("Тип фігури: " + nameFigyre);
            Console.WriteLine($"Точки {tempName}: периметр {perimeter}");
            Console.WriteLine(new String('-', 70));

        }
    }
}
