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
    public class OrderPresentationTests
    {
        const string TEST_NAME = "Null";
        const int TEST_PRICE = 0;
        const string ANOTHER_TEST_NAME = "Another";
        const int ANOTHER_TEST_PRICE = 1;

        [TestMethod()]
        public void ClickDrinkDataGridViewTest()
        {
            DrinkModel drinkModel = new DrinkModel();
            PrivateObject privateDrinkModel = new PrivateObject(drinkModel);
            OrderPresentation orderPresentation = new OrderPresentation();
            PrivateObject privateOrderPresentation = new PrivateObject(orderPresentation);
            drinkModel.AddDrink(TEST_NAME, TEST_PRICE);

            orderPresentation.ClickDrinkDataGridView(drinkModel, 0);
            OrderList orderList = (OrderList)privateDrinkModel.GetFieldOrProperty("_orderList");
            Assert.AreEqual(TEST_NAME, orderList.GetOrderName(0));

            string targetTotalPriceLabelText = (string)privateOrderPresentation.GetFieldOrProperty("_totalPriceLabelText");
            Assert.AreEqual("總價: " + TEST_PRICE, targetTotalPriceLabelText);
        }

        [TestMethod()]
        public void ClickAdditionDataGridViewTest()
        {
            DrinkModel drinkModel = new DrinkModel();
            PrivateObject privateDrinkModel = new PrivateObject(drinkModel);
            OrderPresentation orderPresentation = new OrderPresentation();
            drinkModel.AddDrink(TEST_NAME, TEST_PRICE);
            drinkModel.AddOrder(0);
            drinkModel.AddAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);

            orderPresentation.ClickAdditionDataGridView(drinkModel, 0, 0);
            OrderList orderList = (OrderList)privateDrinkModel.GetFieldOrProperty("_orderList");
            Assert.AreEqual(ANOTHER_TEST_NAME, orderList.GetOrderAdditionName(0, 0));
        }

        [TestMethod()]
        public void ClickOrderDataGridViewTest()
        {
            DrinkModel drinkModel = new DrinkModel();
            PrivateObject privateDrinkModel = new PrivateObject(drinkModel);
            OrderPresentation orderPresentation = new OrderPresentation();
            drinkModel.AddDrink(TEST_NAME, TEST_PRICE);
            drinkModel.AddOrder(0);

            OrderList orderList = (OrderList)privateDrinkModel.GetFieldOrProperty("_orderList");
            Assert.AreEqual(1, orderList.GetOrderListSize());

            orderPresentation.ClickOrderDataGridView(drinkModel, 0);
            orderList = (OrderList)privateDrinkModel.GetFieldOrProperty("_orderList");
            Assert.AreEqual(0, orderList.GetOrderListSize());
        }

        [TestMethod()]
        public void ClickSugarButtonTest()
        {
            DrinkModel drinkModel = new DrinkModel();
            PrivateObject privateDrinkModel = new PrivateObject(drinkModel);
            OrderPresentation orderPresentation = new OrderPresentation();
            drinkModel.AddDrink(TEST_NAME, TEST_PRICE);
            drinkModel.AddOrder(0);

            orderPresentation.ClickSugarButton(drinkModel, 0, Sugar.NormalSugar);
            OrderList orderList = (OrderList)privateDrinkModel.GetFieldOrProperty("_orderList");
            Assert.AreEqual(Sugar.NormalSugar, orderList.GetOrderSugar(0));
        }

        [TestMethod()]
        public void ClickTemperatureButtonTest()
        {
            DrinkModel drinkModel = new DrinkModel();
            PrivateObject privateDrinkModel = new PrivateObject(drinkModel);
            OrderPresentation orderPresentation = new OrderPresentation();
            drinkModel.AddDrink(TEST_NAME, TEST_PRICE);
            drinkModel.AddOrder(0);

            orderPresentation.ClickTemperatureButton(drinkModel, 0, Temperature.NormalIce);
            OrderList orderList = (OrderList)privateDrinkModel.GetFieldOrProperty("_orderList");
            Assert.AreEqual(Temperature.NormalIce, orderList.GetOrderTemperature(0));
        }

        [TestMethod()]
        public void ClickPayTest()
        {
            DrinkModel drinkModel = new DrinkModel();
            PrivateObject privateDrinkModel = new PrivateObject(drinkModel);
            OrderPresentation orderPresentation = new OrderPresentation();
            drinkModel.AddDrink(TEST_NAME, TEST_PRICE);
            drinkModel.AddOrder(0);

            OrderList orderList = (OrderList)privateDrinkModel.GetFieldOrProperty("_orderList");
            Assert.AreEqual(1, orderList.GetOrderListSize());
            orderPresentation.ClickPay(drinkModel);
            orderList = (OrderList)privateDrinkModel.GetFieldOrProperty("_orderList");
            Assert.AreEqual(0, orderList.GetOrderListSize());       
        }

        [TestMethod()]
        public void IsSugarTemperatureEnabledTest()
        {
            OrderPresentation orderPresentation = new OrderPresentation();
            PrivateObject privateOrderPresentation = new PrivateObject(orderPresentation);

            privateOrderPresentation.SetFieldOrProperty("_isSugarTemperatureEnabled", true);
            Assert.IsTrue(orderPresentation.IsSugarTemperatureEnabled());

            privateOrderPresentation.SetFieldOrProperty("_isSugarTemperatureEnabled", false);
            Assert.IsFalse(orderPresentation.IsSugarTemperatureEnabled());
        }

        [TestMethod()]
        public void IsAdditionDataGridViewEnabledTest()
        {
            OrderPresentation orderPresentation = new OrderPresentation();
            PrivateObject privateOrderPresentation = new PrivateObject(orderPresentation);

            privateOrderPresentation.SetFieldOrProperty("_isAdditionDataGridViewEnabled", true);
            Assert.IsTrue(orderPresentation.IsAdditionDataGridViewEnabled());

            privateOrderPresentation.SetFieldOrProperty("_isAdditionDataGridViewEnabled", false); 
            Assert.IsFalse(orderPresentation.IsAdditionDataGridViewEnabled());
        }

        [TestMethod()]
        public void IsPayEnabledTest()
        {
            OrderPresentation orderPresentation = new OrderPresentation();
            PrivateObject privateOrderPresentation = new PrivateObject(orderPresentation);

            privateOrderPresentation.SetFieldOrProperty("_isPayEnabled", true);
            Assert.IsTrue(orderPresentation.IsPayEnabled());

            privateOrderPresentation.SetFieldOrProperty("_isPayEnabled", false);
            Assert.IsFalse(orderPresentation.IsPayEnabled());
        }

        [TestMethod()]
        public void GetTotalPriceLabelTextTest()
        {
            OrderPresentation orderPresentation = new OrderPresentation();
            PrivateObject privateOrderPresentation = new PrivateObject(orderPresentation);

            privateOrderPresentation.SetFieldOrProperty("_totalPriceLabelText", "");
            Assert.AreEqual("", orderPresentation.GetTotalPriceLabelText());

            privateOrderPresentation.SetFieldOrProperty("_totalPriceLabelText", null);
            Assert.AreEqual(null, orderPresentation.GetTotalPriceLabelText());
        }

        [TestMethod()]
        public void GetAdditionItemsTest()
        { 
            Drink drink = new Drink(TEST_NAME, TEST_PRICE);
            DrinkAddition drinkAddition = new DrinkAddition(TEST_NAME, TEST_PRICE);
            DrinkAddition anotherDrinkAddition = new DrinkAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);
            Order order = new Order(drink);
            OrderList orderList = new OrderList();
            OrderPresentation orderPresentation = new OrderPresentation();

            orderList.AddOrder(order);
            orderList.AddOrderAddition(0, drinkAddition);
            Assert.AreEqual(TEST_NAME, orderPresentation.GetAdditionItems(orderList, 0));

            orderList.AddOrderAddition(0, anotherDrinkAddition);
            Assert.AreEqual(TEST_NAME + "、" + ANOTHER_TEST_NAME, orderPresentation.GetAdditionItems(orderList, 0));
        }
    }
}