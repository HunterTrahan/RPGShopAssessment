using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class storeInventory : Inventory
    {
        Item item = new Item();
        playerInventory _Player;

        int _gold = 200;

        //Weapon List
        private Item dagger = new Weapon("Iron Dagger", 5, 10, "One of the more nortious of weapons often favored by rouges and thieves for being easily conceable.");
        private Item bow = new Weapon("Cheap Bow", 10, 10, "The weapon of choice for archers in training, cheap and affordable.");
        private Item sword = new Weapon("Iron Sword", 10, 15, "The Iron Sword is a equally effective in offense and defense and is a mian stay for adventures throughout the realm.");
        private Item mace = new Weapon("Steel Mace", 15, 20, "One of the more popular choice of weapons throughout the realm often favored by town guards and other peacekeepers.");

        //Potion List
        private Item health = new Potion("Health Potion", 20, 30, "A adventures best friend, restores 20 health.");
        private Item mana = new Potion("Mana Potion", 25, 35, "A adventures second best friend, restores 20 mana.");
        private Item revive = new Potion("Resurrection Phial", 100, 50, "A rare and valuable potion that can be used to revive those fallen in combat.");

        public storeInventory()
        {
            Item[] itemBag = { dagger, bow, sword, mace, health, mana, revive };
            _items = itemBag;
        }

        //Store Inventory speaks to the players inventory
        public void EnterStore(playerInventory Player)
        {
            _Player = Player;
        }

        public void ShopMenu()
        {
            string choice = "";
            string choice2 = "";
            string choice3 = "";

            //Displays the shop menu for user to navigate
            Console.WriteLine("\nGot something that might intrest you");
            Console.WriteLine("0: Leave");
            Console.WriteLine("1: Buy");
            Console.WriteLine("2: Sell");

            while (choice != "0")
            {
                //gets players input
                choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "0")
                {
                    Console.WriteLine("You decided to go home.");
                }

                //Display list of items to purchase
                else if (choice == "1")
                {
                    Console.WriteLine("\nWhat are you buying?");
                    Console.WriteLine("0: Back");
                    Console.WriteLine("1: Iron Dagger");
                    Console.WriteLine("2: Cheap Bow");
                    Console.WriteLine("3: Iron Sword");
                    Console.WriteLine("4: Steel Mace");
                    Console.WriteLine("5: Health Potion");
                    Console.WriteLine("6: Mana Potion");
                    Console.WriteLine("7: Resurrection Phial");

                    choice2 = Console.ReadLine();

                    //Display info for dagger
                    if (choice2 == "1")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[0].GetName());
                        Console.WriteLine("\nPrice: " + _items[0].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice3 = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice3 == "1")
                        {

                        }

                        //display descriptions of the item
                        else if (choice3 == "2")
                        {
                            Console.WriteLine(_items[0].GetDescription());
                            Console.ReadLine();
                        }

                        //Display error if other than required selection
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }

                    //Display info for bow
                    else if (choice2 == "2")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[1].GetName());
                        Console.WriteLine("\nPrice: " + _items[1].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice3 = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice3 == "1")
                        {

                        }

                        //display descriptions of the item
                        else if (choice3 == "2")
                        {
                            Console.WriteLine(_items[1].GetDescription());
                            Console.ReadLine();
                        }

                        //Display error if other than required selection
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }

                    //Display info for sword
                    else if (choice2 == "3")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[2].GetName());
                        Console.WriteLine("\nPrice: " + _items[2].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice3 = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice3 == "1")
                        {

                        }

                        //display descriptions of the item
                        else if (choice3 == "2")
                        {
                            Console.WriteLine(_items[2].GetDescription());
                            Console.ReadLine();
                        }

                        //Display error if other than required selection
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }

                    //Display info for mace
                    else if (choice2 == "4")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[3].GetName());
                        Console.WriteLine("\nPrice: " + _items[3].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice3 = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice3 == "1")
                        {

                        }

                        //display descriptions of the item
                        else if (choice3 == "2")
                        {
                            Console.WriteLine(_items[3].GetDescription());
                            Console.ReadLine();
                        }

                        //Display error if other than required selection
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }

                    //Display info for health potion
                    else if (choice2 == "5")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[4].GetName());
                        Console.WriteLine("\nPrice: " + _items[4].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice3 = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice3 == "1")
                        {

                        }

                        //display descriptions of the item
                        else if (choice3 == "2")
                        {
                            Console.WriteLine(_items[4].GetDescription());
                            Console.ReadLine();
                        }

                        //Display error if other than required selection
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }

                    //Display info for mana potion
                    else if (choice2 == "6")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[5].GetName());
                        Console.WriteLine("\nPrice: " + _items[5].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice3 = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice3 == "1")
                        {

                        }

                        //display descriptions of the item
                        else if (choice3 == "2")
                        {
                            Console.WriteLine(_items[5].GetDescription());
                            Console.ReadLine();
                        }

                        //Display error if other than required selection
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }

                    //Display info for revive potion
                    else if (choice2 == "7")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[6].GetName());
                        Console.WriteLine("\nPrice: " + _items[6].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice3 = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice3 == "1")
                        {

                        }

                        //display descriptions of the item
                        else if (choice3 == "2")
                        {
                            Console.WriteLine(_items[6].GetDescription());
                            Console.ReadLine();
                        }

                        //Display error if other than required selection
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }

                //Display the list of items to sell 
                else if (choice == "2")
                {
                    Console.WriteLine("\nWhat are you selling?");
                }

                //Display error if other than required selection
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
