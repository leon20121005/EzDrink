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
    public class DrinkModelTests
    {
        const string TEST_NAME = "Null";
        const int TEST_PRICE = 0;
        const string ANOTHER_TEST_NAME = "Another";
        const int ANOTHER_TEXT_PRICE = 1;
        DrinkModel _drinkModel;
        PrivateObject _privateDrinkModel;

        [TestInitialize()]
        public void Initialize()
        {
             _drinkModel = new DrinkModel();
            _privateDrinkModel = new PrivateObject(_drinkModel);
        }

        [TestMethod()]
        public void InitializeListTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");

            _drinkModel.InitializeList();
            Assert.AreEqual(5, drinkList.Count);
            Assert.AreEqual(4, additionList.Count);
        }

        [TestMethod()]
        public void AddDrinkTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");

            _drinkModel.AddDrink(TEST_NAME, TEST_PRICE);

            PrivateObject privateDrink = new PrivateObject(drinkList[0]);
            string targetDrinkName = (string)privateDrink.GetFieldOrProperty("_name");
            int targetDrinkPrice = (int)privateDrink.GetFieldOrProperty("_price");

            Assert.AreEqual(TEST_NAME, targetDrinkName);
            Assert.AreEqual(TEST_PRICE, targetDrinkPrice);
        }

        [TestMethod()]
        public void DeleteDrinkTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");

            drinkList.Add(new Drink(TEST_NAME, TEST_PRICE));
            Assert.AreEqual(1, drinkList.Count);
            _drinkModel.DeleteDrink(0);
            Assert.AreEqual(0, drinkList.Count);
        }

        [TestMethod()]
        public void GetDrinkNameTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");

            drinkList.Add(new Drink(TEST_NAME, TEST_PRICE));
            Assert.AreEqual(TEST_NAME, _drinkModel.GetDrinkName(0));
        }

        [TestMethod()]
        public void GetDrinkPriceTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");

            drinkList.Add(new Drink(TEST_NAME, TEST_PRICE));
            Assert.AreEqual(TEST_PRICE, _drinkModel.GetDrinkPrice(0));
        }

        [TestMethod()]
        public void GetDrinkListSizeTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");

            Assert.AreEqual(drinkList.Count(), _drinkModel.GetDrinkListSize());
        }

        [TestMethod()]
        public void AddAdditionTest()
        {
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");

            _drinkModel.AddAddition(TEST_NAME, TEST_PRICE);

            PrivateObject privateAddition = new PrivateObject(additionList[0]);
            string targetAdditionName = (string)privateAddition.GetFieldOrProperty("_name");
            int targetAdditionPrice = (int)privateAddition.GetFieldOrProperty("_price");

            Assert.AreEqual(TEST_NAME, targetAdditionName);
            Assert.AreEqual(TEST_PRICE, targetAdditionPrice);
        }

        [TestMethod()]
        public void DeleteAdditionTest()
        {
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");

            additionList.Add(new DrinkAddition(TEST_NAME, TEST_PRICE));
            _drinkModel.DeleteAddition(0);
            Assert.AreEqual(0, additionList.Count);
        }

        [TestMethod()]
        public void GetAdditionNameTest()
        {
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");

            additionList.Add(new DrinkAddition(TEST_NAME, TEST_PRICE));
            Assert.AreEqual(TEST_NAME, _drinkModel.GetAdditionName(0));
        }

        [TestMethod()]
        public void GetAdditionPriceTest()
        {
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");

            additionList.Add(new DrinkAddition(TEST_NAME, TEST_PRICE));
            Assert.AreEqual(TEST_PRICE, _drinkModel.GetAdditionPrice(0));
        }

        [TestMethod()]
        public void GetAdditionListSizeTest()
        {
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");

            Assert.AreEqual(additionList.Count(), _drinkModel.GetAdditionListSize());
        }

        [TestMethod()]
        public void IsDrinkExistTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");

            drinkList.Add(new Drink(TEST_NAME, TEST_PRICE));
            Assert.IsTrue(_drinkModel.IsDrinkExist(TEST_NAME));
        }

        [TestMethod()]
        public void IsAdditionExistTest()
        {
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");

            additionList.Add(new DrinkAddition(TEST_NAME, TEST_PRICE));
            Assert.IsTrue(_drinkModel.IsAdditionExist(TEST_NAME));
        }

        [TestMethod()]
        public void UpdateDrinkTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");

            drinkList.Add(new Drink(TEST_NAME, TEST_PRICE));
            _drinkModel.UpdateDrink(0, ANOTHER_TEST_NAME, ANOTHER_TEXT_PRICE);

            PrivateObject privateDrink = new PrivateObject(drinkList[0]);
            string targetDrinkName = (string)privateDrink.GetFieldOrProperty("_name");
            int targetDrinkPrice = (int)privateDrink.GetFieldOrProperty("_price");

            Assert.AreEqual(ANOTHER_TEST_NAME, targetDrinkName);
            Assert.AreEqual(ANOTHER_TEXT_PRICE, targetDrinkPrice);
        }

        [TestMethod()]
        public void UpdateAdditionTest()
        {
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");

            additionList.Add(new DrinkAddition(TEST_NAME, TEST_PRICE));
            _drinkModel.UpdateAddition(0, ANOTHER_TEST_NAME, ANOTHER_TEXT_PRICE);

            PrivateObject privateAddition = new PrivateObject(additionList[0]);
            string targetAdditionName = (string)privateAddition.GetFieldOrProperty("_name");
            int targetAdditionPrice = (int)privateAddition.GetFieldOrProperty("_price");

            Assert.AreEqual(ANOTHER_TEST_NAME, targetAdditionName);
            Assert.AreEqual(ANOTHER_TEXT_PRICE, targetAdditionPrice);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");

            drinkList.Add(new Drink(TEST_NAME, TEST_PRICE));
            _drinkModel.AddOrder(0);

            Assert.AreEqual(TEST_NAME, _drinkModel.OrderList.GetOrderName(0));
        }

        [TestMethod()]
        public void AddOrderAdditionTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");

            drinkList.Add(new Drink(TEST_NAME, TEST_PRICE));
            additionList.Add(new DrinkAddition(TEST_NAME, TEST_PRICE));
            _drinkModel.AddOrder(0);
            _drinkModel.AddOrderAddition(0, 0);

            Assert.AreEqual(TEST_NAME, _drinkModel.OrderList.GetOrderAdditionName(0, 0));
        }

        [TestMethod()]
        public void ConvertSugarToStringTest()
        {
            const string NORMAL_SUGAR_TEXT = "正常";
            const string HALF_SUGAR_TEXT = "半糖";
            const string LESS_SUGAR_TEXT = "少糖";
            const string NO_SUGAR_TEXT = "無糖";
            const string ERROR_TEXT = "Error";
            DrinkModel drinkModel = new DrinkModel();

            Assert.AreEqual(NORMAL_SUGAR_TEXT, drinkModel.ConvertSugarToString(Sugar.NormalSugar));
            Assert.AreEqual(HALF_SUGAR_TEXT, drinkModel.ConvertSugarToString(Sugar.HalfSugar));
            Assert.AreEqual(LESS_SUGAR_TEXT, drinkModel.ConvertSugarToString(Sugar.LessSugar));
            Assert.AreEqual(NO_SUGAR_TEXT, drinkModel.ConvertSugarToString(Sugar.NoSugar));
            Assert.AreEqual(ERROR_TEXT, drinkModel.ConvertSugarToString(Sugar.Null));
        }

        [TestMethod()]
        public void ConvertTemperatureToStringTest()
        {
            const string NORMAL_ICE_TEXT = "正常";
            const string LESS_ICE_TEXT = "少冰";
            const string NO_ICE_TEXT = "去冰";
            const string HOT_TEXT = "溫熱";
            const string ERROR_TEXT = "Error";
            DrinkModel drinkModel = new DrinkModel();

            Assert.AreEqual(NORMAL_ICE_TEXT, drinkModel.ConvertTemperatureToString(Temperature.NormalIce));
            Assert.AreEqual(LESS_ICE_TEXT, drinkModel.ConvertTemperatureToString(Temperature.LessIce));
            Assert.AreEqual(NO_ICE_TEXT, drinkModel.ConvertTemperatureToString(Temperature.NoIce));
            Assert.AreEqual(HOT_TEXT, drinkModel.ConvertTemperatureToString(Temperature.Hot));
            Assert.AreEqual(ERROR_TEXT, drinkModel.ConvertTemperatureToString(Temperature.Null));
        }

        [TestMethod()]
        public void StoreOrderListTest()
        {
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");

            drinkList.Add(new Drink(TEST_NAME, TEST_PRICE));
            _drinkModel.AddOrder(0);
            _drinkModel.StoreOrderList();

            Assert.AreEqual(TEST_NAME, _drinkModel.HistoryOrderList[0].GetOrderName(0));
            Assert.AreEqual(TEST_PRICE, _drinkModel.HistoryOrderList[0].GetOrderTotalPrice(0));
        }
    }
}