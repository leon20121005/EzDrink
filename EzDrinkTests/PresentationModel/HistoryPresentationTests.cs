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
    public class HistoryPresentationTests
    {
        const string TEST_NAME = "Null";
        const int TEST_PRICE = 0;

        [TestMethod()]
        public void UpdateHistoryTotalPriceLabelTest()
        {        

            DrinkModel drinkModel = new DrinkModel();
            PrivateObject privateDrinkModel = new PrivateObject(drinkModel);
            HistoryPresentation historyPresentation = new HistoryPresentation();

            drinkModel.AddDrink(TEST_NAME, TEST_PRICE);
            drinkModel.AddOrder(0);
            drinkModel.StoreOrderList();

            Assert.AreEqual("總價 : " + TEST_PRICE, historyPresentation.UpdateHistoryTotalPriceLabel(drinkModel));
        }
    }
}