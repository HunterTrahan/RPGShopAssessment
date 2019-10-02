using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShopAssessment
{
    class storeInventory : Inventory
    {
        Item item = new Item();
        playerInventory _Player;
        SuperUser _Super;
       
        int call = 0;


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

            SuperUser super = new SuperUser(this);
            _Super = super;

            _Gold = 300;
        }

        //Store Inventory speaks to the players inventory
        public void EnterStore(playerInventory Player)
        {
            _Player = Player;
        }

        public void Buy(int index)
        {
            if (_Player.Gold >= _items[index].GetValue())
            {
                Item purchase = Remove(index);
                _Player.Add(purchase);
            }
        }

        public void Sell(int index)
        {
            if (Gold >= _Player.Items[index].GetValue())
            {
                Item purchase = _Player.Remove(index);
                Add(purchase);
            }
        }

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
                Console.WriteLine("3: Inventory");
                Console.WriteLine("4: Save");
                Console.WriteLine("5: Load");

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

                    for (int i = 0; i < _items.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ": " + _items[i].GetName());
                    }

                    choice = Console.ReadLine();

                    if (choice == "0")
                    {
                        Console.ReadLine();
                    }

                    //Display info for dagger
                    else if (choice == "1")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[0].GetName());
                        Console.WriteLine("\nPrice: " + _items[0].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice == "1")
                        {
                            Buy(0);
                        }

                        //display descriptions of the item
                        else if (choice == "2")
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
                    else if (choice == "2")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[1].GetName());
                        Console.WriteLine("\nPrice: " + _items[1].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice == "1")
                        {
                            Buy(1);
                        }

                        //display descriptions of the item
                        else if (choice == "2")
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
                    else if (choice == "3")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[2].GetName());
                        Console.WriteLine("\nPrice: " + _items[2].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice == "1")
                        {
                            Buy(2);
                        }

                        //display descriptions of the item
                        else if (choice == "2")
                        {
                            Console.WriteLine(_items[2].GetDescription());
                        }

                        //Display error if other than required selection
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }

                    //Display info for mace
                    else if (choice == "4")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[3].GetName());
                        Console.WriteLine("\nPrice: " + _items[3].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice == "1")
                        {
                            Buy(3);
                            Console.ReadLine();
                        }

                        //display descriptions of the item
                        else if (choice == "2")
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
                    else if (choice == "5")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[4].GetName());
                        Console.WriteLine("\nPrice: " + _items[4].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice == "1")
                        {
                            Buy(4);
                            Console.ReadLine();
                        }

                        //display descriptions of the item
                        else if (choice == "2")
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
                    else if (choice == "6")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[5].GetName());
                        Console.WriteLine("\nPrice: " + _items[5].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice == "1")
                        {
                            Buy(5);
                            Console.ReadLine();
                        }

                        //display descriptions of the item
                        else if (choice == "2")
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
                    else if (choice == "7")
                    {
                        Console.WriteLine("");
                        Console.Write(_items[6].GetName());
                        Console.WriteLine("\nPrice: " + _items[6].GetValue() + " gold");
                        Console.WriteLine();

                        Console.WriteLine("0: Back");
                        Console.WriteLine("1: Buy");
                        Console.WriteLine("2: Inspect");

                        choice = Console.ReadLine();

                        //Move item from shops array into players array
                        if (choice == "1")
                        {
                            Buy(6);
                            Console.ReadLine();
                        }

                        //display descriptions of the item
                        else if (choice == "2")
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
                    _Player.PrintItems();

                    call = Convert.ToInt32(Console.ReadLine());

                    if (_items.Length >= call)
                    {
                        Sell(call - 1);
                        Console.WriteLine(Items[Items.Length - 1].GetName() + " Sold.");
                    }

                    Console.ReadLine();
                }

                //Display the players inventory
                else if (choice == "3")
                {
                    _Player.PrintItems();
                    Console.ReadLine();
                }

                else if (choice == "4")
                {
                    Save("save.txt");
                    _Player.Save("PlayerSave.txt");
                    Console.WriteLine("Game Saved.");
                }

                else if (choice == "5")
                {
                    Load("save.txt");
                }

                else if (choice == "password")
                {
                    _Super.AddItem();
                }

                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }

    }
}
