using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введіть назву книги: ");
            string name = Console.ReadLine();

            Console.Write("Введіть Автора: ");
            string autor = Console.ReadLine();

            Console.Write("Введіть Синопсис: ");
            string dis = Console.ReadLine();



            Book book = new Book(name);

            book.Author = autor;
            book.Content = dis;

            Console.Clear();
            book.AllInfoBook();

            Console.ReadKey();
        }
    }
}
