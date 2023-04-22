using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    public class Title
    {

        public string TextTitle { get; set; }

        public Title(string textTitle)
        {
            TextTitle = textTitle;
        }

        public void Show()
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(TextTitle.ToUpper());
            Console.ForegroundColor = color;
        }

    }
}
