using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class Potion : Item
    {
        private int _heal;

        public Potion(string newName, int newHeal, int newValue, string description)
        {
            _name = newName;
            _heal = newHeal;
            _value = newValue;
            _description = description;
        }

        public int GetHeal()
        {
            return _heal;
        }
    }
}
