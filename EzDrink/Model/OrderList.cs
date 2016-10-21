using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class OrderList
    {
        public void AddOrder(Order order)
        {
            _orderList.Add(order);
        }

        public void DeleteOrder(int orderListIndex)
        {
            _orderList.RemoveAt(orderListIndex);
        }

        public void SetOrderSugar(int orderListIndex, Sugar sugar)
        {
            _orderList[orderListIndex].SetSugar(sugar);
        }

        public void SetOrderTemperature(int orderListIndex, Temperature temperature)
        {
            _orderList[orderListIndex].SetTemperature(temperature);
        }

        public void AddOrderAddition(int orderListIndex, DrinkAddition drinkAddition)
        {
            _orderList[orderListIndex].AddAddition(drinkAddition);
        }

        public int GetOrderTotalPrice(int orderListIndex)
        {
            return _orderList[orderListIndex].GetTotalPrice();
        }

        public Sugar GetOrderSugar(int orderListIndex)
        {
            return _orderList[orderListIndex].GetSugar();
        }

        public Temperature GetOrderTemperature(int orderListIndex)
        {
            return _orderList[orderListIndex].GetTemperature();
        }

        public string GetOrderAdditionName(int orderListIndex, int additionListIndex)
        {
            return _orderList[orderListIndex].GetAdditionName(additionListIndex);
        }

        public int GetOrderAdditionListSize(int orderListIndex)
        {
            return _orderList[orderListIndex].GetAdditionListSize();
        }

        public int GetOrderListSize()
        {
            return _orderList.Count;
        }

        public int GetOrderListTotalPrice()
        {
            _totalPrice = 0;

            for (int i = 0; i < _orderList.Count; i++)
            {
                _totalPrice += _orderList[i].GetTotalPrice();
            }
            return _totalPrice;
        }

        public void ClearOrderList()
        {
            _orderList.Clear();
        }

        private List<Order> _orderList = new List<Order>();
        private int _totalPrice;
    }
}