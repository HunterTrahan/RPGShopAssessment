using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class Item
    {
        //holds item value
        protected int _value = 0;

        //holds item description
        protected string _description = "";

        //holds item name
        protected string _name = "";

        //returns item name
        public string GetName()
        {
            return _name;
        }

        //returns item value
        public int GetValue()
        {
            return _value;
        }

        //returns item description
        public string GetDescription()
        {
            return _description;
        }

    }
}
