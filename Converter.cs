using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_1_
{
     class Converter
    {
        public double grn = 700;
        public double usd = 200;
        public double eur = 500;
        public double rub = 1400;

        public Converter(double usdx, double eurx, double rubx)
        {
            usdx = usd;
            eurx = eur;
            rubx = rub;
        }

        public void Conver()
        {
            double grn_in_dol = Math.Round(grn / 28.5, 2);

            double grn_in_eur = Math.Round(grn / 35.3, 2);

            double grn_in_rub = Math.Round(grn * 3.32, 2);

            double dol_in_grn = Math.Round(usd * 28.5, 2);

            double eur_in_grn = Math.Round(eur * 35.3, 2);

            double rub_in_grn = Math.Round(rub / 3.32, 2);

            Console.WriteLine($"You have: {grn} grn");

            Console.WriteLine($"This is: {grn_in_dol} in usd");

            Console.WriteLine($"This is: {grn_in_eur} in eur");

            Console.WriteLine($"This is: {grn_in_rub} in rub");

            Console.WriteLine($"You have:{usd} this is {dol_in_grn} in  grn");

            Console.WriteLine($"You have:{eur} this is {eur_in_grn} in grn");

            Console.WriteLine($"You have:{rub} this is {rub_in_grn} in grn");
        }
    }
}
