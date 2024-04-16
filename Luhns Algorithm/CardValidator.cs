using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhns_Algorithm
{
    public class CardValidator
    {
        public static void Validate()
        {
            Console.WriteLine("Enter a credit card number, no dashes, and I will compute the validity of the format: ");
            String ccNumber;
            ccNumber = Console.ReadLine();
            if (Program.ValidateCard(ccNumber))
            {
                Console.WriteLine(ccNumber + " appears to be a valid format.");
            }
            else
            {
                Console.WriteLine("That number does not appear to be a valid format.");
            }
        }
    }
}
