using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRatesApi
{
    public class CurrencyService
    {
        public double PlnsToPounds()
        {
            double pln = 5.12D;
            Console.WriteLine("Pound to PLN exchange rate is: 1£ = 5.14 PLN");
            Console.WriteLine("Enter the amount of pounds to exchange: ");
            double pound = Convert.ToDouble(Console.ReadLine());
            double plnAmount = pound * pln;
            Console.WriteLine("Exchange amount: " + plnAmount);
            return plnAmount;
        }

        public double PoundsToPlns()
        {
            double pound = 0.19D;
            Console.WriteLine("PLN to Pound exchange rate is: 1 PLN = 0.19£ ");
            Console.WriteLine("Enter the amount of zloty to exchange: ");
            double pln = Convert.ToDouble(Console.ReadLine());
            double poundAmount = pound * pln;
            Console.WriteLine("Exchange amount: " + poundAmount);
            return poundAmount;
        }
    }
}
