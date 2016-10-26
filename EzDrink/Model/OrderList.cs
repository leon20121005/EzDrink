using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class OrderList
    {
        //Add the order into the order list
        public void AddOrder(Order order)
        {
            _orderList.Add(order);
        }

        //Delete the order from the order list
        public void DeleteOrder(int orderListIndex)
        {
            _orderList.RemoveAt(orderListIndex);
        }

        //Set the sweetness of the order
        public void SetOrderSugar(int orderListIndex, Sugar sugar)
        {
            _orderList[orderListIndex].SetSugar(sugar);
        }

        //Set the ice level of the order
        public void SetOrderTemperature(int orderListIndex, Temperature temperature)
        {
            _orderList[orderListIndex].SetTemperature(temperature);
        }

        //Add the drink addition into the order list
        public void AddOrderAddition(int orderListIndex, DrinkAddition drinkAddition)
        {
            _orderList[orderListIndex].AddAddition(drinkAddition);
        }

        //Return the total price of the order
        public int GetOrderTotalPrice(int orderListIndex)
        {
            return _orderList[orderListIndex].GetTotalPrice();
        }

        //Return the sugar of the order
        public Sugar GetOrderSugar(int orderListIndex)
        {
            return _orderList[orderListIndex].GetSugar();
        }

        //Return the temperature of the order
        public Temperature GetOrderTemperature(int orderListIndex)
        {
            return _orderList[orderListIndex].GetTemperature();
        }

        //Return the name of the addition name of the order
        public string GetOrderAdditionName(int orderListIndex, int additionListIndex)
        {
            return _orderList[orderListIndex].GetAdditionName(additionListIndex);
        }

        //Return the size of the drink addition list of the order
        public int GetOrderAdditionListSize(int orderListIndex)
        {
            return _orderList[orderListIndex].GetAdditionListSize();
        }

        //Return the size of the order list
        public int GetOrderListSize()
        {
            return _orderList.Count;
        }

        //Return the order list total price from the order list
        public int GetOrderListTotalPrice()
        {
            _totalPrice = 0;

            for (int i = 0; i < _orderList.Count; i++)
            {
                _totalPrice += _orderList[i].GetTotalPrice();
            }
            return _totalPrice;
        }

        //Clear the order list
        public void ClearOrderList()
        {
            _orderList.Clear();
        }

        private List<Order> _orderList = new List<Order>();
        private int _totalPrice;
    }
}