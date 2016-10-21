using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class DrinkAddition
    {
        public DrinkAddition(string name, int price)
        {
            _name = name;
            _price = price;
        }

        //Return the name of the drink addition
        public string GetName()
        {
            return _name;
        }

        //Return the price of the drink addition
        public int GetPrice()
        {
            return _price;
        }

        private string _name;
        private int _price;
    }
}