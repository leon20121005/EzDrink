using Microsoft.VisualStudio.TestTools.UnitTesting;
using EzDrink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink.Tests
{
    [TestClass()]
    public class OrderListTests
    {
        const string TEST_NAME = "Null";
        const int TEST_PRICE = 0;
        const string ANOTHER_TEST_NAME = "Another";
        const int ANOTHER_TEST_PRICE = 1;
        Drink _drink;
        Order _order;
        OrderList _orderList;

        [TestInitialize()]
        public void Initialize()
        {
            _drink = new Drink(TEST_NAME, TEST_PRICE);
            _order = new Order(_drink);
            _orderList = new OrderList();
            _orderList.AddOrder(_order);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            PrivateObject privateOrderList = new PrivateObject(_orderList);
            List<Order> targetOrderList = (List<Order>)privateOrderList.GetFieldOrProperty("_orderList");
                       
            Assert.AreEqual(TEST_NAME, targetOrderList[0].GetName());
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            PrivateObject privateOrderList = new PrivateObject(_orderList);
            List<Order> targetOrderList = (List<Order>)privateOrderList.GetFieldOrProperty("_orderList");

            Assert.AreEqual(1, targetOrderList.Count);
            _orderList.DeleteOrder(0);
            Assert.AreEqual(0, targetOrderList.Count);
        }

        [TestMethod()]
        public void SetOrderSugarTest()
        {
            PrivateObject privateOrderList = new PrivateObject(_orderList);
            List<Order> targetOrderList = (List<Order>)privateOrderList.GetFieldOrProperty("_orderList");

            _orderList.SetOrderSugar(0, Sugar.NormalSugar);
            Assert.AreEqual(Sugar.NormalSugar, targetOrderList[0].GetSugar());
            _orderList.SetOrderSugar(0, Sugar.Null);
            Assert.AreEqual(Sugar.Null, targetOrderList[0].GetSugar());
        }

        [TestMethod()]
        public void SetOrderTemperatureTest()
        {
            PrivateObject privateOrderList = new PrivateObject(_orderList);
            List<Order> targetOrderList = (List<Order>)privateOrderList.GetFieldOrProperty("_orderList");

            _orderList.SetOrderTemperature(0, Temperature.NormalIce);
            Assert.AreEqual(Temperature.NormalIce, targetOrderList[0].GetTemperature());
            _orderList.SetOrderTemperature(0, Temperature.Null);
            Assert.AreEqual(Temperature.Null, targetOrderList[0].GetTemperature());
        }

        [TestMethod()]
        public void AddOrderAdditionTest()
        {
            DrinkAddition drinkAddition = new DrinkAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);         
            PrivateObject privateOrderList = new PrivateObject(_orderList);
            List<Order> targetOrderList = (List<Order>)privateOrderList.GetFieldOrProperty("_orderList");

            _orderList.AddOrderAddition(0, drinkAddition);
            Assert.AreEqual(ANOTHER_TEST_NAME, targetOrderList[0].GetAdditionName(0));
        }

        [TestMethod()]
        public void GetOrderNameTest()
        {
            Drink anotherDrink = new Drink(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);
            Order anotherOrder = new Order(anotherDrink);

            Assert.AreEqual(TEST_NAME, _orderList.GetOrderName(0));
            _orderList.AddOrder(anotherOrder);
            Assert.AreEqual(ANOTHER_TEST_NAME, _orderList.GetOrderName(1));
        }

        [TestMethod()]
        public void GetOrderTotalPriceTest()
        {
            Drink anotherDrink = new Drink(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);
            Order anotherOrder = new Order(anotherDrink);

            Assert.AreEqual(TEST_PRICE, _orderList.GetOrderTotalPrice(0));
        }

        [TestMethod()]
        public void GetOrderSugarTest()
        {
            _orderList.SetOrderSugar(0, Sugar.NormalSugar);
            Assert.AreEqual(Sugar.NormalSugar, _orderList.GetOrderSugar(0));
            _orderList.SetOrderSugar(0, Sugar.Null);
            Assert.AreEqual(Sugar.Null, _orderList.GetOrderSugar(0));
        }

        [TestMethod()]
        public void GetOrderTemperatureTest()
        {
            _orderList.SetOrderTemperature(0, Temperature.NormalIce);
            Assert.AreEqual(Temperature.NormalIce, _orderList.GetOrderTemperature(0));
            _orderList.SetOrderTemperature(0, Temperature.Null);
            Assert.AreEqual(Temperature.Null, _orderList.GetOrderTemperature(0));
        }

        [TestMethod()]
        public void GetOrderAdditionNameTest()
        {
            DrinkAddition drinkAddition = new DrinkAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);

            _orderList.AddOrderAddition(0, drinkAddition);
            Assert.AreEqual(ANOTHER_TEST_NAME, _orderList.GetOrderAdditionName(0, 0));
        }

        [TestMethod()]
        public void GetOrderAdditionListSizeTest()
        {
            DrinkAddition drinkAddition = new DrinkAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);

            Assert.AreEqual(0, _orderList.GetOrderAdditionListSize(0));
            _orderList.AddOrderAddition(0, drinkAddition);
            Assert.AreEqual(1, _orderList.GetOrderAdditionListSize(0));
        }

        [TestMethod()]
        public void GetOrderListSizeTest()
        {
            Assert.AreEqual(1, _orderList.GetOrderListSize());
            _orderList.AddOrder(_order);
            Assert.AreEqual(2, _orderList.GetOrderListSize());
        }

        [TestMethod()]
        public void GetOrderListTotalPriceTest()
        { 
            Drink anotherDrink = new Drink(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);
            Order anotherOrder = new Order(anotherDrink);

            Assert.AreEqual(TEST_PRICE, _orderList.GetOrderListTotalPrice());
            _orderList.AddOrder(anotherOrder);
            Assert.AreEqual(TEST_PRICE + ANOTHER_TEST_PRICE, _orderList.GetOrderListTotalPrice());
        }

        [TestMethod()]
        public void ClearOrderListTest()
        {
            Assert.AreEqual(1, _orderList.GetOrderListSize());
            _orderList.ClearOrderList();
            Assert.AreEqual(0, _orderList.GetOrderListSize());
        }
    }
}