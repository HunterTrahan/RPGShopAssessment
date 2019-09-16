using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopAssessment
{
    class Item
    {
        protected int _value = 0;
        protected string _description = "";
        protected string _name = "";

        public string GetName()
        {
            return _name;
        }

        public int GetValue()
        {
            return _value;
        }

        public string GetDescription()
        {
            return _description;
        }

    }
}
