using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{

    class _Address
        
    {
        private string country = "Ukraine";
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        private string city  = "Kyiv";
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private string street = "Kioto";
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        private byte house = 9;
        public byte House
        {
            get
            {
                return house;
            }
            set
            {
              
                house = value;
            }
        }
        private byte apartment  = 23;
        public byte Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
        private int index  = 02166;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        static void Main(string[] args)
        {
            _Address address = new _Address();

            Console.WriteLine(address.country);
            Console.WriteLine(address.city);
            Console.WriteLine(address.street);
            Console.WriteLine(address.house);
            Console.WriteLine(address.apartment);
            Console.WriteLine(address.index);

            Console.ReadLine();
        }
    }
}

