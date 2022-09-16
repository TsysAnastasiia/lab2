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
        private string country, city, street;
        public byte house, apartment;
        private byte house, apartment;
        public int index;
        private int index;
        public void writeInConsoleInfo(string country, string city, string street, int index, byte house, byte apartment)
        {
            Console.WriteLine("Країна: {0}\nМісто: {1}\nВулиця: {2}\nІндекс: {3}\nДім: {4}\nКвартира: {5}\n", country, city, street, index, house, apartment);
        }


    }


   

    class Address1
    {
        static void Main(string[] args)
        {
            Address myaddress = new Address();

            myaddress.country = "Ukraine";
            myaddress.city = "Kiyv";
            myaddress.street = "Kubanskoi Ukrainy";
            myaddress.index = "02166";
            myaddress.house = "3";
            myaddress.apartment = "34";

            myaddress.writeInConsoleInfo(myaddress.country, myaddress.city, myaddress.street, myaddress.index, myaddress.house, myaddress.apartment);

            Console.ReadLine();
        }
    }
}

    

   

    

