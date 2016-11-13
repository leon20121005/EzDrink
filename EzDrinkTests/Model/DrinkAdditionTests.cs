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
    public class DrinkAdditionTests
    {
        const string TEST_NAME = "Null";
        const int TEST_PRICE = 0;
        const string ANOTHER_TEST_NAME = "Another";
        const int ANOTHER_TEST_PRICE = 1;

        [TestMethod()]
        public void DrinkAdditionTest()
        {
            DrinkAddition drinkAddition = new DrinkAddition(TEST_NAME, TEST_PRICE);
            PrivateObject privateDrinkAddition = new PrivateObject(drinkAddition);

            string targetName = (string)privateDrinkAddition.GetFieldOrProperty("_name");
            int targetPrice = (int)privateDrinkAddition.GetFieldOrProperty("_price");

            Assert.AreEqual(TEST_NAME, targetName);
            Assert.AreEqual(TEST_PRICE, targetPrice);
        }

        [TestMethod()]
        public void SetAdditionTest()
        {
            DrinkAddition drinkAddition = new DrinkAddition(TEST_NAME, TEST_PRICE);
            PrivateObject privateDrinkAddition = new PrivateObject(drinkAddition);

            drinkAddition.SetAddition(ANOTHER_TEST_NAME, ANOTHER_TEST_PRICE);
            string targetName = (string)privateDrinkAddition.GetFieldOrProperty("_name");
            int targetPrice = (int)privateDrinkAddition.GetFieldOrProperty("_price");

            Assert.AreEqual(ANOTHER_TEST_NAME, targetName);
            Assert.AreEqual(ANOTHER_TEST_PRICE, targetPrice);
        }

        [TestMethod()]
        public void GetNameTest()
        {
            DrinkAddition drinkAddition = new DrinkAddition(TEST_NAME, TEST_PRICE);

            Assert.AreEqual(TEST_NAME, drinkAddition.GetName());
        }

        [TestMethod()]
        public void GetPriceTest()
        {
            DrinkAddition drinkAddition = new DrinkAddition(TEST_NAME, TEST_PRICE);

            Assert.AreEqual(TEST_PRICE, drinkAddition.GetPrice());
        }
    }
}