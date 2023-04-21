using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Rectangle
    {
        //можно и так
        //public double Side3 { get; set; }
        //public double Side4 { get; set; }

        private double side1;
        private double side2;

        public double Side1
        {
            get { return side1; }
        }

        public double Side2
        {
            get { return side2; }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double sum = side1 * side2;
            return sum;
        }

        public double PerimeterCalculator()
        {
            double sum = (side1 + side2) * 2;
            return sum;
        }


    }
}
