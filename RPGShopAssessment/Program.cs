﻿using System;
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

            //storeInventory class instance
            storeInventory Menu = new storeInventory();
            playerInventory Player = new playerInventory();

            string _Choice = "";

            //Ask the player if they wish to enter the shop
            Console.WriteLine("You stand before the shop, will you enter? (Y/N)");
            _Choice = Console.ReadLine();

            //Check for players choice
            _Choice = _Choice.ToUpper();
            if (_Choice == "N")
            {
                Console.WriteLine("You decided to go home.");
            }

            //Display shop menu
            else if (_Choice == "Y")
            {
                Menu.EnterStore(Player);
                Menu.ShopMenu();
            }

            Console.ReadLine();
        }
    }
}
