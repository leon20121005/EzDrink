using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public partial class DrinkModel
    {
        OrderList _orderList = new OrderList();

        List<Drink> _drinkList = new List<Drink>();
        List<DrinkAddition> _additionList = new List<DrinkAddition>();
        List<OrderList> _allList = new List<OrderList>();

        //Add the drink into the drink list
        public void AddDrink(string drinkName, int drinkPrice)
        {
            _drinkList.Add(new Drink(drinkName, drinkPrice));
        }

        //Delete the drink from the drink list
        public void DeleteDrink(int drinkListIndex)
        {
            _drinkList.RemoveAt(drinkListIndex);
        }

        //Return the drink name in the drink list
        public string GetDrinkName(int drinkListIndex)
        {
            return _drinkList[drinkListIndex].GetName();
        }

        //Return the drink price in the drink list
        public int GetDrinkPrice(int drinkListIndex)
        {
            return _drinkList[drinkListIndex].GetPrice();
        }

        //Return the size of the drink list
        public int GetDrinkListSize()
        {
            return _drinkList.Count;
        }

        //Add the addition into the addition list
        public void AddAddition(string additionName, int additionPrice)
        {
            _additionList.Add(new DrinkAddition(additionName, additionPrice));
        }

        //Delete the addition from the addition list
        public void DeleteAddition(int additionListIndex)
        {
            _additionList.RemoveAt(additionListIndex);
        }

        //Return the drink addition name in the drink addition list
        public string GetAdditionName(int additionListIndex)
        {
            return _additionList[additionListIndex].GetName();
        }

        //Return the drink addition price in the drink addition list
        public int GetAdditionPrice(int additionListIndex)
        {
            return _additionList[additionListIndex].GetPrice();
        }

        //Return the size of the addition list
        public int GetAdditionListSize()
        {
            return _additionList.Count;
        }

        //Add the order into the order list
        public void AddOrder(int drinkListIndex)
        {
            _orderList.AddOrder(new Order(_drinkList[drinkListIndex]));
        } 

        //Delete the order from the order list
        public void DeleteOrder(int orderListIndex)
        {
            _orderList.DeleteOrder(orderListIndex);
        }

        //Set the sweetness of the order
        public void SetOrderSugar(int orderListIndex, Sugar sugar)
        {
            _orderList.SetOrderSugar(orderListIndex, sugar);
        }

        //Set the ice level of the order
        public void SetOrderTemperature(int orderListIndex, Temperature temperature)
        {
            _orderList.SetOrderTemperature(orderListIndex, temperature);
        }

        //Return the order sweetness in the order list
        public Sugar GetOrderSugar(int orderListIndex)
        {
            return _orderList.GetOrderSugar(orderListIndex);
        }

        //Return the order ice level in the order list
        public Temperature GetOrderTemperature(int orderListIndex)
        {
            return _orderList.GetOrderTemperature(orderListIndex);
        }

        //Add the drink addition into the order list
        public void AddOrderAddition(int additionListIndex, int orderListIndex)
        {
            _orderList.AddOrderAddition(orderListIndex, _additionList[additionListIndex]);
        }

        //Return the order addition name in the order list
        public string GetOrderAdditionName(int orderListIndex, int additionListIndex)
        {
            return _orderList.GetOrderAdditionName(orderListIndex, additionListIndex);
        }

        //Return the size of the order drink addition list 
        public int GetOrderAdditionListSize(int orderListIndex)
        {
            return _orderList.GetOrderAdditionListSize(orderListIndex);
        }

        //Return the size of the order list
        public int GetOrderListSize()
        {
            return _orderList.GetOrderListSize();
        }

        //Return the order total price in the order list
        public int GetOrderTotalPrice(int orderListIndex)
        {
            return _orderList.GetOrderTotalPrice(orderListIndex);
        }

        //Return the order list total price from the order list
        public int GetOrderListTotalPrice()
        {
            return _orderList.GetOrderListTotalPrice();
        }

        //Transform the sugar type into the string type
        public string ConvertSugarToString(Sugar sugar)
        {
            switch (sugar)
            {
                case Sugar.NormalSugar:
                    return NORMAL_SUGAR_TEXT;
                case Sugar.HalfSugar:
                    return HALF_SUGAR_TEXT;
                case Sugar.LessSugar:
                    return LESS_SUGAR_TEXT;
                case Sugar.NoSugar:
                    return NO_SUGAR_TEXT;
                default:
                    return ERROR_TEXT;
            }
        }

        //Transform the temperature type into the string type
        public string ConvertTemperatureToString(Temperature temperature)
        {
            switch (temperature)
            {
                case Temperature.NormalIce:
                    return NORMAL_ICE_TEXT;
                case Temperature.LessIce:
                    return LESS_ICE_TEXT;
                case Temperature.NoIce:
                    return NO_ICE_TEXT;
                case Temperature.Hot:
                    return HOT_TEXT;
                default:
                    return ERROR_TEXT;
            }
        }

        //Store the current order list into the list of the order list
        public void StoreOrderList()
        {
            _allList.Add(_orderList);
            _orderList.ClearOrderList();
        }

        //Return whether the drink is already existing or not
        public bool IsDrinkExist(string drinkName)
        {
            for (int index = 0; index < _drinkList.Count; index++)
            {
                if (drinkName == _drinkList[index].GetName())
                {
                    return true;
                }
            }
            return false;
        }

        //Return whether the addition is already existing or not
        public bool IsAdditionExist(string additionName)
        {
            for (int index = 0; index < _drinkList.Count; index++)
            {
                if (additionName == _additionList[index].GetName())
                {
                    return true;
                }
            }
            return false;
        }

        //Update the name or the price of the drink in the drink list
        public void UpdateDrink(int drinkListIndex, string drinkName, int drinkPrice)
        {
            _drinkList[drinkListIndex].SetName(drinkName);
            _drinkList[drinkListIndex].SetPrice(drinkPrice);
        }

        //Update the name or the price of the addition in the addition list
        public void UpdateAddition(int additionListIndex, string additionName, int additionPrice)
        {
            _additionList[additionListIndex].SetName(additionName);
            _additionList[additionListIndex].SetPrice(additionPrice);
        }
    }
}