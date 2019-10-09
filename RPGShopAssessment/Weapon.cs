using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class Weapon : Item
    {
        //holds weapon damage
        private int _damage;
        
        //Defines what a weapon consist of
        public Weapon(string newName, int newDamage, int newValue, string description)
        {
            _name = newName;
            _damage = newDamage;
            _value = newValue;
            _description = description;
        }

        //returns weapon damage
        public int GetDamage()
        {
            return _damage;
        }

      
    }
}
