using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v2
{
    internal class Author
    {

        private string authorName;

        public string AuthorName
        {
            get
            {
                if (authorName != null)
                    return authorName;
                else
                    return "Автор відсутній.";
            }
            set
            {
                authorName = value;

            }

        }

        public void Show()
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Автор: {AuthorName}");
            Console.ForegroundColor = color;
        }


    }
}
