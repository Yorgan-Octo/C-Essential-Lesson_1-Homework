using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterfece userInterfece = new UserInterfece();

            userInterfece.HeadShow("Програма що обчислює площу прямокутника та периметр прямокутника!");

            double namber1 = userInterfece.InDoubleNam("Введите первое значение: ");
            double namber2 = userInterfece.InDoubleNam("Введите второе значение: ");

            Rectangle rectangle = new Rectangle(namber1, namber2);

            double areaSum = rectangle.AreaCalculator();
            double perimeterSum = rectangle.PerimeterCalculator();

            //тут не обовясково потрыбно було звертатися до полів rectangle.Side1 мржна булоп росто вказати змінні namber1 та namber2
            //це так для прикладу
            userInterfece.HeadShow($"Площа Прямокутника зи стороною {rectangle.Side1} и стороною {rectangle.Side2} буде {areaSum}");
            userInterfece.HeadShow($"Периметр Прямокутника зи стороною {rectangle.Side1} и стороною {rectangle.Side2} буде {perimeterSum}");

            Console.ReadKey();
        }
    }
}
