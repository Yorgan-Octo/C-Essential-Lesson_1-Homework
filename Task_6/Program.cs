using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //це як один із варіантів
            List<Address> addresses = new List<Address>()
            {
                new Address(0234, "United Kingdom", "London", "Baker Street", "14", "65"),
                new Address(4566, "United Kingdom", "London", "Piccadilly", "3", "89"),
                new Address(2345, "United Kingdom", "London", "Bond Street", "78", "11"), 
                new Address(2346, "United Kingdom", "London", "Abbey Road", "12", "43"),
            };

            foreach (var item in addresses)
            {
                item.ShowInfo();
            }


            Console.WriteLine(new String('=', 80));


            //також можно і просто ввести и вивести вручну
            Address user1 = new Address();


            Console.WriteLine("Заповнення вручну");
            user1.Index = 2333;
            user1.Country = "United Kingdom";
            user1.City = "London";
            user1.Street = "Regent Street";
            user1.House = "37";
            user1.Apartment = "4";

            //можна вивести так
            user1.ShowInfo();


            //а можна і так (по суті теж саме але не через виклик функції)
            Console.WriteLine(new String('-', 50));
            Console.WriteLine(
                $"Индекс: {user1.Index}\n" +
                $"Країна: {user1.Country}\n" +
                $"Місто: {user1.City}\n" +
                $"вул. {user1.Street}, дім. {user1.House}, кв. {user1.Apartment}");
            Console.WriteLine(new String('-', 50));




            Console.ReadKey();
        }
    }
}
