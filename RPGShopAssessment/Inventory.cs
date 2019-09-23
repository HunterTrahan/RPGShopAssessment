using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class Inventory
    {
        protected Item[] _items;
        protected int _Gold;
        


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
    }
}
