using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v2
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public string Author
        {
            set
            {
                this.author.AuthorName = value;
            }
        }

        public string Content
        {
            set
            {
                this.content.ContentBook = value;
            }
        }



        private void InitializeDocument()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }


        public Book(string title)
        {
            InitializeDocument();
            this.title.NameBook = title;
        }

        public void AllInfoBook()
        {
            Console.WriteLine(new String('=', 100));
            this.title.Show();
            this.author.Show();
            this.content.Show();
            Console.WriteLine(new String('=', 100));
        }

    }
}
