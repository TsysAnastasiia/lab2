using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{

    class Address
    {
        public string country { get; set; } = "Ukraine";
        public string city { get; set; } = "Kyiv";
        public string street { get; set; } = "Kioto";
        public byte house { get; set; } = 9;
        public byte apartment { get; set; } = 23;
        public int index { get; set; } = 02166;

        public void writeInConsoleInfo(string country, string city, string street, int index, byte house, byte apartment)

        {
            Console.WriteLine("Країна: {0}\nМісто: {1}\nВулиця: {2}\nІндекс: {3}\nДім: {4}\nКвартира: {5}\n", country, city, street, index, house, apartment);
        }

        static void Main(string[] args)
        {
            Address myaddress = new Address();

            Console.WriteLine(myaddress.country);
            Console.WriteLine(myaddress.city);
            Console.WriteLine(myaddress.street);
            Console.WriteLine(myaddress.house);
            Console.WriteLine(myaddress.apartment);
            Console.WriteLine(myaddress.index);

            myaddress.writeInConsoleInfo(myaddress.country, myaddress.city, myaddress.street, myaddress.index, myaddress.house, myaddress.apartment);

            Console.ReadLine();

        }
    }
}
