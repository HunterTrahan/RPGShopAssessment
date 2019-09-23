﻿using System;
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
        private Weapon[] _weapons;

        //Weapon List
        private Weapon dagger = new Weapon("Iron Dagger", 5, 10, "test1");
        private Weapon bow = new Weapon("Cheap Bow", 10, 10, "test2");
        private Weapon sword = new Weapon("Iron Sword", 10, 15, "test3");
        private Weapon mace = new Weapon("Steel Mace", 15, 20, "test4");

        public storeInventory()
        {
            Weapon[] weaponBag = { dagger, bow, sword, mace };
            _weapons = weaponBag;
        }

        public void ShopMenu()
       {
            string choice = "";
            string choice2 = "";
            string choice3 = "";
            
            while (choice != "0")
            {
                //Displays the shop menu for user to navigate
                Console.WriteLine("\nGot something that might intrest you");
                Console.WriteLine("0: Leave");
                Console.WriteLine("1: Buy");
                Console.WriteLine("2: Sell");
                

                //gets players input
                choice = Console.ReadLine();
                Console.WriteLine();

                //Display list of items to purchase
                if (choice == "1")
                {
                    Console.WriteLine("\nWhat are you buying?");
                    Console.WriteLine("0: Back");
                    Console.WriteLine("1: Iron Dagger");
                    Console.WriteLine("2: Cheap Bow");
                    Console.WriteLine("3: Iron Sword");
                    Console.WriteLine("4: Steel Mace");

                    choice2 = Console.ReadLine();

                    //Display info for dagger
                    if (choice2 == "1")
                    {
                        Console.WriteLine("");
                        Console.Write(_weapons[0].GetName());
                        Console.WriteLine("\nPrice: " + _weapons[0].GetValue() + " gold");
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
                            Console.WriteLine(_weapons[0].GetDescription());
                            Console.ReadLine();
                        }
                    }

                    //Display info for bow
                    else if (choice2 == "2")
                    {
                        Console.WriteLine("");
                        Console.Write(_weapons[1].GetName());
                        Console.WriteLine("\nPrice: " + _weapons[1].GetValue() + " gold");
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
                            Console.WriteLine(_weapons[1].GetDescription());
                            Console.ReadLine();
                        }
                    }

                    //Display info for sword
                    else if (choice2 == "3")
                    {
                        Console.WriteLine("");
                        Console.Write(_weapons[2].GetName());
                        Console.WriteLine("\nPrice: " + _weapons[2].GetValue() + " gold");
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
                            Console.WriteLine(_weapons[2].GetDescription());
                            Console.ReadLine();
                        }
                    }

                    //Display info for mace
                    else if (choice2 == "4")
                    {
                        Console.WriteLine("");
                        Console.Write(_weapons[3].GetName());
                        Console.WriteLine("\nPrice: " + _weapons[3].GetValue() + " gold");
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
                            Console.WriteLine(_weapons[3].GetDescription());
                            Console.ReadLine();
                        }
                    }
                }

                else if (choice == "2")
                {
                    Console.WriteLine("\nWhat are you selling?");
                }
            }
       }
    }
}
