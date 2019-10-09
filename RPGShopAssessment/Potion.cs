using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class Potion : Item
    {
        //holds heal value for potions
        private int _heal;

        //defines what a potion consist of
        public Potion(string newName, int newHeal, int newValue, string description)
        {
            _name = newName;
            _heal = newHeal;
            _value = newValue;
            _description = description;
        }

        //return heal
        public int GetHeal()
        {
            return _heal;
        }
    }
}
