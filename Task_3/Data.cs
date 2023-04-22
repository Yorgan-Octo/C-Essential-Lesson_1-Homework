using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Data
    {

        Random rand = new Random();

        public Author Writer()
        {

            Author[] writers = new Author[20] {
                new Author("William Shakespeare"),
                new Author("Jane Austen"),
                new Author("Fyodor Dostoevsky"),
                new Author("Leo Tolstoy"),
                new Author("Virginia Woolf"),
                new Author("Ernest Hemingway"),
                new Author("Mark Twain"),
                new Author("Charles Dickens"),
                new Author("J.R.R. Tolkien"),
                new Author("George Orwell"),
                new Author("Gabriel Garcia Marquez"),
                new Author("Harper Lee"),
                new Author("Emily Bronte"),
                new Author("Herman Melville"),
                new Author("Kurt Vonnegut"),
                new Author("J.D. Salinger"),
                new Author("Aldous Huxley"),
                new Author("Franz Kafka"),
                new Author("Albert Camus"),
                new Author("Ray Bradbury")
                };

            Author writer = writers[rand.Next(0, 20)];

            return writer;
        }
        public Title BooksName()
        {

            Title[] booksName = new Title[20] {
                new Title("Hamlet"),
                new Title("Pride and Prejudice"),
                new Title("Crime and Punishment"),
                new Title("War and Peace"),
                new Title("To the Lighthouse"),
                new Title("The Old Man and the Sea"),
                new Title("The Adventures of Huckleberry Finn"),
                new Title("Great Expectations"),
                new Title("The Lord of the Rings"),
                new Title("1984"),
                new Title("One Hundred Years of Solitude"),
                new Title("To Kill a Mockingbird"),
                new Title("Wuthering Heights"),
                new Title("Moby-Dick"),
                new Title("Slaughterhouse-Five"),
                new Title("The Catcher in the Rye"),
                new Title("Brave New World"),
                new Title("The Metamorphosis"),
                new Title("The Stranger"),
                new Title("Fahrenheit 451") };
            Title name = booksName[rand.Next(0, 20)];

            return name;
        }
        public Content Descriptions()
        {
            Content[] descriptions = new Content[5]
            {
                new Content("A thrilling tale of espionage and deceit, set against the backdrop of World War II."),
                new Content("A heartwarming story of friendship and love, set in the picturesque countryside of England."),
                new Content("An epic adventure through a fantastical world, where magic and danger lurk around every corner."),
                new Content("A gripping mystery novel, filled with unexpected twists and turns that will keep you guessing until the very end."),
                new Content("A haunting tale of loss and redemption, set against the stark beauty of the Scottish highlands."),
            };

            Content descrip = descriptions[rand.Next(0, 5)];

            return descrip;
        }

        public void OutText(string text = " Це ваш заголовок!")
        {
            Console.WriteLine(new String('=', 100));
            Console.WriteLine(text);
            Console.WriteLine(new String('=', 100));
        }

        public string InUsstring(string textInfo = "Введіть текст: ")
        {
            string nam;
            while (true)
            {
                Console.Write(textInfo);
                nam = Console.ReadLine();

                if (nam != null) return nam;
                else ErrorText("Невірно введені данні. Перевірте та повторіть знову");
            }
        }

        public void ErrorText(string textError = "Помилка вхідних данних!", ConsoleColor erroeColor = ConsoleColor.Red)
        {
            ConsoleColor defoltColor = Console.ForegroundColor;

            Console.ForegroundColor = erroeColor;
            Console.WriteLine(textError);
            Console.ForegroundColor = defoltColor;
        }
    }
}
