using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lab2
{
    class Address
    {
        public string country, city, street;
        public byte house, apartment;
        public int index;
        public void writeInConsoleInfo(string country, string city, string street, int index, byte house, byte apartment)

        {
            Console.WriteLine("Країна: {0}\nМісто: {1}\nВулиця: {2}\nІндекс: {3}\nДім: {4}\nКвартира: {5}\n", country, city, street, index, house, apartment);
        }
    }
}
    class Address1
    {
        static void Main(string[] args)
        {
            Address myaddress = new Address();

            myaddress.country = "Ukraine";
            myaddress.city = "Lokhvitsa";
            myaddress.street = "Heroiv Ukrainy";
            myaddress.index = 37200;
            myaddress.house = 37;
            myaddress.apartment = 2;

            Address youraddress = new Address();

            youraddress.country = "Ukraine";
            youraddress.city = "Kyiv";
            youraddress.street = "Kubanskoi Ukrainy";
            youraddress.index = 02156;
            youraddress.house = 15;
            youraddress.apartment = 3;

            myaddress.writeInConsoleInfo(myaddress.country, myaddress.city, myaddress.street, myaddress.index, myaddress.house, myaddress.apartment);
            youraddress.writeInConsoleInfo(youraddress.country, youraddress.city, youraddress.street, youraddress.index, youraddress.house, youraddress.apartment);

            Console.ReadLine();

        }
    }


    
   

    

