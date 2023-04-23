using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3_v2
{
    internal class Title
    {

        private string nameBook;

        public string NameBook
        {
            get
            {
                if (nameBook != null)
                    return nameBook;
                else
                    return "Назва відсутня.";
            }
            set
            {
                nameBook = value;

            }

        }

        public void Show()
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Назва: {NameBook}");
            Console.ForegroundColor = color;
        }


    }
}
