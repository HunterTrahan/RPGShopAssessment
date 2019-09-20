using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class Weapon : Item
    {
        private int _damage;
        

        public Weapon(string newName, int newDamage, int newValue, string description)
        {
            _name = newName;
            _damage = newDamage;
            _value = newValue;
            _description = description;
        }

        public int GetDamage()
        {
            return _damage;
        }

      
    }
}
