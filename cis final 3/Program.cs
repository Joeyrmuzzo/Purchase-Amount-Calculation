using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_final_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchaseAmount, discount=0, total;

            Console.WriteLine("please enter the total amount of purchases: ");
            purchaseAmount = Convert.ToDouble(Console.ReadLine());

            if (purchaseAmount>400)
            {
                discount = .92;
            }
            else if (purchaseAmount<=400)
            {
                discount = .95;
            }
            

            Console.WriteLine("The total amount due is: " + CalcDiscount( purchaseAmount,discount));
            Console.ReadLine();

        }
        static double CalcDiscount(double purchaseAmount, double discount)
        {
            double total = 0;
            total = purchaseAmount * discount;
            return total;
        }
    }
}
