using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    public class Content
    {

        public string TextContent { get; set; }

        public Content(string textContent)
        {
            TextContent = textContent;
        }

        public void Show()
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Синопсис: \n{TextContent}");
            Console.ForegroundColor = color;  
        }


    }
}
