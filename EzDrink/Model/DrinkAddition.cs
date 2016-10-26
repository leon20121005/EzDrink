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

        //Change the name of the addition
        public void SetName(string name)
        {
            _name = name;
        }

        //Change the price of the addition
        public void SetPrice(int price)
        {
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