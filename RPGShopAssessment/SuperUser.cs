using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class SuperUser
    {
        //holds refrence for new name
        protected static string newName;

        //holds refrence for new value
        protected static int newValue;

        //holds refrence for new desccription
        protected static string newDescription;

        //holds refrence for new damage value
        protected static int newDamage;

        //holds refrence for new heal value
        protected static int newHeal;

        //Players input
        protected static string _choice = "";

        //Initalizes a new array
        Item item = new Item();

        //used to refrence the storeInventory class
        storeInventory _Shop;

        //Super user speaks to the stores inventory
        public SuperUser(storeInventory Shop)
        {
            _Shop = Shop;
        }

        //create and add new item to shop
        public void AddItem()
        {

            Console.WriteLine("Super user activated");

            Console.WriteLine("Enter a name");
            newName = Console.ReadLine();

            Console.WriteLine("Enter a value");
            newValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a description");
            newDescription = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Item created successfuly");
            Console.WriteLine("");
            Console.WriteLine("Item Name: " + newName);
            Console.WriteLine("Item Value: " + newValue);
            Console.WriteLine("Item Description: " + newDescription);

            Console.WriteLine("");

            Console.WriteLine("What kind of item has been created?");
            Console.WriteLine("1: Weapon");
            Console.WriteLine("2: Potion");

            _choice = Console.ReadLine();

            //add new weapon item
            if (_choice == "1")
            {
                Console.WriteLine("Enter a damage value");
                newDamage = Convert.ToInt32(Console.ReadLine());

                Item newItem = new Weapon(newName, newDamage, newValue, newDescription);
                _Shop.Add(newItem);
                Console.WriteLine(newItem.GetName() + " has been added to the shop inventory");
            }

            //add new potion item
            else if (_choice == "2")
            {
                Console.WriteLine("Enter a heal value");
                newHeal = Convert.ToInt32(Console.ReadLine());

                Item newItem = new Potion(newName, newHeal, newValue, newDescription);
                _Shop.Add(newItem);
                Console.WriteLine(newItem.GetName() + " has been added to the shop inventory");
            }

            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
