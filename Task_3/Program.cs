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

            //Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            //Потрібно: Створити клас Book.Створити класи Title, Author та Content, 
            //кожен з яких повинен містити одне рядкове поле та метод void Show(). 
            //Реалізуйте можливість додавання до книги назви книги, імені автора та змісту. 
            //Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.


            Data data = new Data();

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
                Console.Write("Натисніть N - цоб додати нову книгу; Натисніть Y - цоб редагувати книгу; ");

                ConsoleKeyInfo button = Console.ReadKey();

                switch (button.Key)
                {
                    case ConsoleKey.N:
                        {

                            Book book = new Book();

                            Console.Clear();

                            //використав кортеж чисто для практики можно булоб і без неї
                            var infoBook = book.AddNewBook();

                            list.Add(new Book(infoBook.Item1, infoBook.Item2, infoBook.Item3));

                            break;
                        }
                    case ConsoleKey.Y:
                        {
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }



        }
    }
}
