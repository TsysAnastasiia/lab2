using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Employee
    {
        private string first;
        private string last;
        private string pos = "middle";
        private int exp = 10;
        private int salary;
        private int tax = 20;


        public Employee(string firstName, string lastName)
        {
            first = firstName;
            last = lastName;
        }

        public void Calculate()
        {

            if (pos == "junior" || pos == "Junior")
            {
                salary = (int)((int)500 * (exp * 0.2) * 0.80);
            }
            else if (pos == "middle" || pos == "Middle")
            {
                salary = (int)((int)1000 * (exp * 0.4) * 0.80);
            }
            else if (pos == "senior" || pos == "Senior")
            {
                salary = (int)((int)2000 * (exp * 0.6) * 0.80);
            }
            else
            {
                pos = "trainee";
                exp = 0;
                salary = 500;
            }
        }


        public void Write()
        {
            Console.WriteLine($"Name: {first} \nLast Name: {last} \nPosition: {pos} \nExpirience: {exp} years" +
                $" \nSalary: {salary}$ in nanosek \nTax collection: {tax}%");
        }
    }
}
