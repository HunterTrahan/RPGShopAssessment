using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            string _Choice = "";

            Console.WriteLine("You stand before the shop, will you enter? (Y/N)");
            _Choice = Console.ReadLine();

            _Choice = _Choice.ToUpper();
            if (_Choice == "N")
            {
                Console.WriteLine("You decided to go home.");
            }

            else if (_Choice == "Y")
            {
                //Console.WriteLine("Test");
                
            }

            Console.ReadLine();
        }
    }
}
