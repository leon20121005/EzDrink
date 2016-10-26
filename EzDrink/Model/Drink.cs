using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Drink
    {
        public Drink(string name, int price)
        {
            _name = name;
            _price = price;
        }

        //Change the name of the drink
        public void SetName(string name)
        {
            _name = name;
        }

        //Change the price of the drink
        public void SetPrice(int price)
        {
            _price = price;
        }

        //Return the name of the drink
        public string GetName()
        {
            return _name;
        }

        //Return the price of the drink
        public int GetPrice()
        {
            return _price;
        }

        private string _name;
        private int _price;     
    }
}