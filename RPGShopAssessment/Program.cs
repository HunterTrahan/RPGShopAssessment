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

            //storeInventory class instance
            storeInventory Menu = new storeInventory();
            //playerInventory class instance
            playerInventory Player = new playerInventory();

            //Players input
            string _Choice = "";

            //Ask the player if they wish to enter the shop
            Console.WriteLine("You stand before the shop, will you enter? (Y/N)");

            //Check for players choice
            _Choice = Console.ReadLine();

            //Checks that the players choice is valid
            _Choice = _Choice.ToUpper();
            while (_Choice != "Y" && _Choice != "N")
            {
                Console.WriteLine("Invalid");
                _Choice = Console.ReadLine();

                _Choice = _Choice.ToUpper();
            }

            
            //Display shop menu
            //Moves the player inside the store
            if (_Choice == "Y")
            {
                Menu.EnterStore(Player);
                Menu.ShopMenu();
            }

            //Exits the program
            else if (_Choice == "N")
            {
                Console.WriteLine("You decided to go home.");
                Console.ReadLine();
            }
        }
    }
}
