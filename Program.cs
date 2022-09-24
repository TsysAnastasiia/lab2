using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address solution\n");
            Address someAddress = new Address();

            someAddress.Index = 0266;
            someAddress.Country = "Ukraine";
            someAddress.City = "Kyiv";
            someAddress.Street = "Unnamed";
            someAddress.House = 27;
            someAddress.Apartment = 8;

            Console.WriteLine(someAddress.GetAddress());

            Console.ReadKey();
        }
    }
}
