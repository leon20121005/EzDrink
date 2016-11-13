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
    public class DrinkTests
    {
        const string TEST_NAME = "Null";
        const int TEST_PRICE = 0;
        const string ANOTHER_TEST_NAME = "Another";
        const int ANOTHER_TEST_PRICE = 1;

        [TestMethod()]
        public void DrinkTest()
        {
            Drink drink = new Drink(TEST_NAME, TEST_PRICE);
            PrivateObject privateDrink = new PrivateObject(drink);

            string targetName = (string)privateDrink.GetFieldOrProperty("_name");
            int targetPrice = (int)privateDrink.GetFieldOrProperty("_price");

            Assert.AreEqual(TEST_NAME, targetName);
            Assert.AreEqual(TEST_PRICE, targetPrice);
        }

        [TestMethod()]
        public void SetDrinkTest()
        {
            Drink drink = new Drink(TEST_NAME, TEST_PRICE);
            PrivateObject privateDrink = new PrivateObject(drink);

            drink.SetDrink(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);
            string targetName = (string)privateDrink.GetFieldOrProperty("_name");
            int targetPrice = (int)privateDrink.GetFieldOrProperty("_price");

            Assert.AreEqual(ANOTHER_TEST_NAME, targetName);
            Assert.AreEqual(ANOTHER_TEST_PRICE, targetPrice);
        }

        [TestMethod()]
        public void GetNameTest()
        {
            Drink drink = new Drink(TEST_NAME, TEST_PRICE);

            Assert.AreEqual(TEST_NAME, drink.GetName());
        }

        [TestMethod()]
        public void GetPriceTest()
        {
            Drink drink = new Drink(TEST_NAME, TEST_PRICE);

            Assert.AreEqual(TEST_PRICE, drink.GetPrice());
        }
    }
}