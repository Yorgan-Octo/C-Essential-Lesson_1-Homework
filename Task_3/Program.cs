using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            Book book = new Book();

            List<Book> list = new List<Book>()
            {
                new Book(data.BooksName(), data.Writer(), data.Descriptions()),
                new Book(data.BooksName(), data.Writer(), data.Descriptions()),
                new Book(data.BooksName(), data.Writer(), data.Descriptions()),

            };

            while (true)
            {
                data.OutText("Збірник цікавих книг!");

                foreach (var item in list)
                {
                    item.AllInfoBook();
                }

                Console.WriteLine(new String('=', 100));
                Console.WriteLine("Виберіть дію:");
                Console.Write("Натисніть N - цоб додати нову книгу;");

                ConsoleKeyInfo button = Console.ReadKey();

                //Я хотів реалізувати ще редагування книги але часу взагалі немае(
                switch (button.Key)
                {
                    case ConsoleKey.N:
                        {
                            Console.Clear();
                            //використав кортеж чисто для практики можно булоб і без ньго
                            var infoBook = book.AddNewBook();

                            if (infoBook.Item1.TextTitle != "" && infoBook.Item2.Name != "" && infoBook.Item3.TextContent != "")
                            {
                                list.Add(new Book(infoBook.Item1, infoBook.Item2, infoBook.Item3));
                                data.ErrorText("Книга доданна", ConsoleColor.Green);
                            }
                            else
                            {
                                data.ErrorText("Нажаль ви не ввели якісь данні!");
                            }


                            Console.WriteLine("Натисніть на любу кнопку для вигоду в меню");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                Console.Clear();
            }



        }
    }
}
