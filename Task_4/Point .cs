using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Point
    {
        //Клас Point повинен містити два цілих поля і одне рядкове поле.
        //Створити три властивості одним методом доступу get.
        //Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів.

        private int x;
        private int y;
        private string name;

        public int X{
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

    }
}
