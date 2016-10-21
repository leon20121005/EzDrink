using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Order
    {
        public Order(Drink drink)
        {
            _drink = drink;
            _totalPrice = _drink.GetPrice();
        }

        //Set the sweetness of the drink
        public void SetSugar(Sugar sugar)
        {
            _sugar = sugar;
        }

        //Set the ice level of the drink
        public void SetTemperature(Temperature temperature)
        {
            _temperature = temperature;
        }

        //Add the drink addition into the order
        public void AddAddition(DrinkAddition drinkAddition)
        {
            _drinkAdditionList.Add(drinkAddition);
            _totalPrice += drinkAddition.GetPrice();
        }

        //Return the name of the drink
        public string GetName()
        {
            return _drink.GetName();
        }

        //Return the price of the drink
        public int GetPrice()
        {
            return _drink.GetPrice();
        }

        //Return the total price of the order
        public int GetTotalPrice()
        {
            return _totalPrice;
        }

        //Return the sweetness of the drink
        public Sugar GetSugar()
        {
            return _sugar;
        }

        //Return the ice level of the drink
        public Temperature GetTemperature()
        {
            return _temperature;
        }

        //Return the drink addition of the drink
        public string GetAdditionName(int additionListIndex)
        {
            return _drinkAdditionList[additionListIndex].GetName();
        }

        //Return the size of the drink addition list
        public int GetAdditionListSize()
        {
            return _drinkAdditionList.Count;
        }

        private Drink _drink;
        private int _totalPrice;
        private Sugar _sugar = Sugar.Null;
        private Temperature _temperature = Temperature.Null;
        private List<DrinkAddition> _drinkAdditionList = new List<DrinkAddition>();
    }
}