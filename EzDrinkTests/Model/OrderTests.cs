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
    public class OrderTests
    {
        const string TEST_NAME = "Null";
        const int TEST_PRICE = 0;
        const string ANOTHER_TEST_NAME = "Another";
        const int ANOTHER_TEST_PRICE = 1;
        Drink _drink;
        Order _order;

        [TestInitialize()]
        public void Initialize()
        {
            _drink = new Drink(TEST_NAME, TEST_PRICE);
            _order = new Order(_drink);
        }

        [TestMethod()]
        public void OrderTest()
        {
            PrivateObject privateOrder = new PrivateObject(_order);

            Drink targetDrink = (Drink)privateOrder.GetFieldOrProperty("_drink");
            Assert.AreEqual(_drink, targetDrink);
        }

        [TestMethod()]
        public void SetSugarTest()
        {
            PrivateObject privateOrder = new PrivateObject(_order);

            _order.SetSugar(Sugar.NormalSugar);
            Sugar targetSugar = (Sugar)privateOrder.GetFieldOrProperty("_sugar");
            Assert.AreEqual(Sugar.NormalSugar, targetSugar);
        }

        [TestMethod()]
        public void SetTemperatureTest()
        {
            PrivateObject privateOrder = new PrivateObject(_order);

            _order.SetTemperature(Temperature.NormalIce);
            Temperature targetTemperature = (Temperature)privateOrder.GetFieldOrProperty("_temperature");
            Assert.AreEqual(Temperature.NormalIce, targetTemperature);
        }

        [TestMethod()]
        public void AddAdditionTest()
        {
            PrivateObject privateOrder = new PrivateObject(_order);
            DrinkAddition drinkAddition = new DrinkAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);

            _order.AddAddition(drinkAddition);
            List<DrinkAddition> targetAdditionList = (List<DrinkAddition>)privateOrder.GetFieldOrProperty("_drinkAdditionList");
            Assert.AreEqual(drinkAddition, targetAdditionList[0]);
        }

        [TestMethod()]
        public void GetNameTest()
        {
            Assert.AreEqual(TEST_NAME, _order.GetName());
        }

        [TestMethod()]
        public void GetPriceTest()
        {
            Assert.AreEqual(TEST_PRICE, _order.GetPrice());
        }

        [TestMethod()]
        public void GetTotalPriceTest()
        {
            Assert.AreEqual(TEST_PRICE, _order.GetTotalPrice());

            DrinkAddition addition = new DrinkAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);

            _order.AddAddition(addition);
            Assert.AreEqual(TEST_PRICE + ANOTHER_TEST_PRICE, _order.GetTotalPrice());
        }

        [TestMethod()]
        public void GetSugarTest()
        {
            _order.SetSugar(Sugar.NormalSugar);
            Assert.AreEqual(Sugar.NormalSugar, _order.GetSugar());
            _order.SetSugar(Sugar.Null);
            Assert.AreEqual(Sugar.Null, _order.GetSugar());
        }

        [TestMethod()]
        public void GetTemperatureTest()
        {
            _order.SetTemperature(Temperature.NormalIce);
            Assert.AreEqual(Temperature.NormalIce, _order.GetTemperature());
            _order.SetTemperature(Temperature.Null);
            Assert.AreEqual(Temperature.Null, _order.GetTemperature());
        }

        [TestMethod()]
        public void GetAdditionNameTest()
        {
            DrinkAddition addition = new DrinkAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);

            _order.AddAddition(addition);
            Assert.AreEqual(ANOTHER_TEST_NAME, _order.GetAdditionName(0));
        }

        [TestMethod()]
        public void GetAdditionListSizeTest()
        {
            DrinkAddition addition = new DrinkAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);

            _order.AddAddition(addition);
            Assert.AreEqual(1, _order.GetAdditionListSize());

            _order.AddAddition(addition);
            Assert.AreEqual(2, _order.GetAdditionListSize());
        }
    }
}