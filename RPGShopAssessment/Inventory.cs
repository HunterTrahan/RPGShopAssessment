using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShopAssessment
{
    class Inventory
    {
        protected Item[] _items = new Item[0];

        public int _Gold;

        //Add Item to Store or Player
        public void Add(Item item)
        {
            Item[] _newItem = new Item[_items.Length + 1];

            for (int i = 0; i < _items.Length; i++)
            {
                _newItem[i] = _items[i];
            }
            _newItem[_newItem.Length - 1] = item;
            _items = _newItem;
        }

        //Remove Item from Store or Player
        public Item Remove(int index)
        {
            Item[] _newItem = new Item[_items.Length - 1];

            int newPosition = 0;
            for (int i = 0; i < _items.Length; i++)
            {
                if (i != index)
                {
                    _newItem[newPosition] = _items[i];
                    newPosition++;
                }
            }

            Item itemSave;
            itemSave = _items[index];

            _items = _newItem;

            return itemSave;
        }

        //prints items
        public void PrintItems()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                Console.WriteLine(i +1 + ": " +_items[i].GetName());
            }
        }

        //returns gold and sets value
        public int Gold
        {
            get
            {
                return _Gold;
            }

            set
            {
                _Gold = value;

                if(_Gold < 0)
                {
                    _Gold = 0;
                }

            }
        }

        //returns item
        public Item[] Items
        {
            get
            {
                return _items;
            }
        }

        //Save file
        public void Save(string path)
        {
            //Create a writer for the file at our path
            StreamWriter writer = File.CreateText(path);
            //Write Gold
            writer.WriteLine(Gold);

            //Itterate through players items and write them
            writer.WriteLine(Items.Length);
            foreach (Item itm in Items)
            {
                if (itm is Weapon)
                {
                    Weapon temp = itm as Weapon;
                    itm.GetName();
                    writer.WriteLine("weapon");
                    writer.WriteLine(itm.GetName());
                    writer.WriteLine(temp.GetDamage());
                    writer.WriteLine(itm.GetValue());
                    writer.WriteLine(itm.GetDescription());
                }

                else
                {
                    Potion temp = itm as Potion;
                    writer.WriteLine("potion");
                    writer.WriteLine(itm.GetName());
                    writer.WriteLine(temp.GetHeal());
                    writer.WriteLine(itm.GetValue());
                    writer.WriteLine(itm.GetDescription());
                }
            }
            //Close it
            writer.Close();
        }

        //Load save file
        public void Load(string path)
        {
            if (File.Exists(path))
            {
                StreamReader reader = File.OpenText(path);
                //load gold
                Gold = Convert.ToInt32(reader.ReadLine());
                int temp = Convert.ToInt32(reader.ReadLine());

                //clear inventory
                for (int i = 0; i < Items.Length; i++)
                {
                    Remove(i);
                    i--;
                }

                //Add items to inventory
                for (int i = 0; i < temp; i++)
                {
                    string type = "";
                    string name = "";
                    string desc = "";
                    int value = 0;
                    int dam = 0;
                    int heal = 0;

                    //check item type
                    type = reader.ReadLine();
                    if (type == "weapon")
                    {
                        name = reader.ReadLine();
                        dam = Convert.ToInt32(reader.ReadLine());
                        value = Convert.ToInt32(reader.ReadLine());
                        desc = reader.ReadLine();

                        Add(new Weapon(name, dam, value, desc));
                    }
                    
                    else if (type == "potion")
                    {
                        name = reader.ReadLine();
                        heal = Convert.ToInt32(reader.ReadLine());
                        value = Convert.ToInt32(reader.ReadLine());
                        desc = reader.ReadLine();

                        Add(new Potion(name, heal, value, desc));
                    }
                }
                reader.Close();
                Console.WriteLine("Game Loaded");
            }

            else
            {
                Console.WriteLine("Save file not found.");
            }
        }
    }
}
