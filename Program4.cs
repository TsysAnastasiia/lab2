using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
     class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User solution\n");

            User ezUser = new User("QWERTY", "Denches", "Danilenko", 18);

            Console.WriteLine(ezUser.login);
            Console.WriteLine(ezUser.name);
            Console.WriteLine(ezUser.surname);
            Console.WriteLine(ezUser.age);
            Console.WriteLine(ezUser.date);

            Console.ReadKey();
        }
    }
}
