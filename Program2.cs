using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_1_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Converter solution\n");

            Converter ezConverter = new Converter(28.5, 35.3, 0.332);

            ezConverter.Conver();

            Console.ReadKey();
        }
    }
}
