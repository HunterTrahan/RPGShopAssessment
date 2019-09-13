using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class Weapon : Item
    {
        private int _damage = 0;
        

        public void weaponConst(string newName, int newDamage, int newValue)
        {
            _name = newName;
            _damage = newDamage;
            _value = newValue;
        }

        private weaponConst Dagger = new attackItem("Iron Dagger", 10, 5);
    }
}
