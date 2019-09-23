using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class playerInventory : Inventory
    {
        public void playerGold()
        {
            _Gold = 250;
        }

        public void playerMenu()
        {
            Console.WriteLine("\nYou look inside your bag");
            Console.WriteLine("0: Back");
            
        }
    }
}
