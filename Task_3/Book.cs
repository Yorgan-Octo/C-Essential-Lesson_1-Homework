using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Book
    {
        Data data = new Data();
        public Title Title { set; get; }
        public Author Author { set; get; }
        public Content Content { set; get; }

        public Book()
        {

        }

        public Book(Title title, Author author, Content content)
        {
            Title = title;
            Author = author;
            Content = content;
        }


        public void AllInfoBook()
        {
            Console.WriteLine(new String('-', 100));
            Title.Show();
            Author.Show();
            Content.Show();
            Console.WriteLine(new String('-', 100));
        }


        public (Title, Author, Content) AddNewBook()
        {
            data.OutText(" Додавання нової книги: вкажить назву, імя автора, та синопсис!");

            Title nameBook = new Title(data.InUsstring("Введіть назву книги: "));
            Author nameAuthor = new Author(data.InUsstring("Введіть Автора: "));
            Content nameContent = new Content(data.InUsstring("Напишіть синопсис: "));


            return (nameBook, nameAuthor, nameContent);
        }

    }
}
