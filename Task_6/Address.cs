using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Address
    {
        //я вирішив зробите це так що не роботи мавпячої роботи;
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        
        //номер будинку оже буди з буквами тому и string
        public string House { get; set; }
        public string Apartment { get; set; }


        public Address()
        {

        }

        public Address(int index, string country, string city, string street, string house, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public void ShowInfo()
        {
            Console.WriteLine(new String('-', 50));
            Console.WriteLine(
                $"Индекс: {Index}\n" +
                $"Країна: {Country}\n" +
                $"Місто: {City}\n" +
                $"вул. {Street}, дім. {House}, кв. {Apartment}");
            Console.WriteLine(new String('-', 50));
        }
    }
}
