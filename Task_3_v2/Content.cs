using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v2
{
    internal class Content
    {

        private string contentBook;

        public string ContentBook
        {
            get
            {
                if (contentBook != null)
                    return contentBook;
                else
                    return "Синопсис відсутній.";
            }
            set
            {
                contentBook = value;

            }

        }

        public void Show()
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Синопсис {ContentBook}");
            Console.ForegroundColor = color;
        }


    }
}
