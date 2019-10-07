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
        int transaction = 0;

        bool exit = false;


        //Weapon List
        private Item dagger = new Weapon("Iron Dagger", 5, 10, "One of the more nortious of weapons often favored by rouges and thieves for being easily conceable.");
        private Item bow = new Weapon("Cheap Bow", 10, 10, "The weapon of choice for archers in training, cheap and affordable.");
        private Item sword = new Weapon("Iron Sword", 10, 15, "The Iron Sword is a equally effective in offense and defense and is a mian stay for adventures throughout the realm.");
        private Item mace = new Weapon("Steel Mace", 15, 20, "One of the more popular choice of weapons throughout the realm often favored by town guards and other peacekeepers.");

        //Potion List
        private Item health = new Potion("Health Potion", 20, 30, "A adventures best friend, restores 20 health.");
        private Item mana = new Potion("Mana Potion", 25, 35, "A adventures second best friend, restores 20 mana.");
        private Item revive = new Potion("Resurrection Phial", 100, 50, "A rare and valuable potion that can be used to revive those fallen in combat.");

        //Holds the array of items
        //super user & gold
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

        //Sells items from
        //stores inventory into
        //players inventory
        public void Buy(int index)
        {
            if (_Player.Gold >= _items[index].GetValue())
            {
                _Player.Gold -= _items[index].GetValue();
                Item purchase = Remove(index);
                _Player.Add(purchase);
            }
        }

        //Sells items from
        //players inventory into
        //stores inventory
        public void Sell(int index)
        {
            if (Gold >= _Player.Items[index].GetValue())
            {
                Gold -= _Player.Items[index].GetValue();
                Item purchase = _Player.Remove(index);
                Add(purchase);
            }
        }

        public void ShopMenu()
        {
            string choice = "";

            while (!exit)
            {
                choice = "";
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

                //Exit the program
                if (choice == "0")
                {
                    Console.WriteLine("You decided to go home.");
                    Console.ReadLine();
                    exit = true;
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

                    int number = 0;
                    choice = Console.ReadLine();
                    Int32.TryParse(choice, out number);

                    if (number < 0)
                    {
                        Console.WriteLine("Invalid Input");
                        number = 1;
                    }
                    else
                    {

                    }

                    if (number <= _items.Length)
                    {
                        ItemMenu(Convert.ToInt32(choice) - 1);
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
                    Console.WriteLine("Gold: " + _Player.Gold);
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
                    _Player.Load("PlayerSave.txt");
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

        //Function used to display item buying menu
        public void ItemMenu(int index)
        {
            string choice = "";
            

            Console.WriteLine("");
            Console.Write(_items[index].GetName());
            Console.WriteLine("\nPrice: " + _items[index].GetValue() + " gold");
            Console.WriteLine();

            Console.WriteLine("0: Back");
            Console.WriteLine("1: Buy");
            Console.WriteLine("2: Inspect");

            choice = Console.ReadLine();

            //Go to the previous menu
            if (choice == "0")
            {
                choice = "";
            }

            //Move item from shops array into players array
            else if (choice == "1")
            {
                Buy(index);
                Console.WriteLine("Item purchased");
            }

            //display descriptions of the item
            else if (choice == "2")
            {
                Console.WriteLine(_items[index].GetDescription());
                Console.ReadLine();
            }

            //Display error if other than required selection
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
