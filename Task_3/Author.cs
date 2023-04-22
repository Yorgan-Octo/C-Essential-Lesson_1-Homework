using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Author
    {
        public string Name{ get; set; }

        public Author(string name)
        {
            Name = name;
        }

        public void Show()
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Автор: {Name}");
            Console.ForegroundColor = color;
        }

    }
}
