using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class storeInventory
    {
        Item item = new Item();

        int _gold = 0;

        //Weapon List
        private Weapon dagger = new Weapon("Iron Dagger", 5, 10, "test");
        private Weapon dagger2 = new Weapon("Iron Bow", 10, 10, "test");
        private Weapon sword = new Weapon("Iron Sword", 10, 15, "test");
        private Weapon sword2 = new Weapon("Steel Sword", 15, 20, "test");

       public void ShopMenu()
       {
            string choice = "";

            while (choice != "0")
            {
                //Displays the shop menu for user to navigate
                Console.WriteLine("\nGot something that might intrest you");
                Console.WriteLine("0: Leave");
                Console.WriteLine("1: Buy");
                Console.WriteLine("2: Sell");
            }
       }
    }
}
