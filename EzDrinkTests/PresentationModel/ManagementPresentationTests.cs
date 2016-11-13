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
    public class ManagementPresentationTests
    {
        const string TEST_NAME = "Null";
        const int TEST_PRICE = 0;
        DrinkModel _drinkModel;
        PrivateObject _privateDrinkModel;
        ManagementPresentation _managementPresentation;
        PrivateObject _privateManagementPresentationPresentation;

        [TestInitialize()]
        public void Initialize()
        {
            _drinkModel = new DrinkModel();
            _privateDrinkModel = new PrivateObject(_drinkModel);
            _managementPresentation = new ManagementPresentation();
            _privateManagementPresentationPresentation = new PrivateObject(_managementPresentation);
        }

        [TestMethod()]
        public void ClickNewDrinkTest()
        {
            _managementPresentation.ClickNewDrink(_drinkModel, TEST_NAME, TEST_PRICE.ToString());
            bool targetEnabled = (bool)_privateManagementPresentationPresentation.GetFieldOrProperty("_isNewDrinkTextBoxEnabled");
            Assert.IsTrue(targetEnabled);

            _managementPresentation.ClickNewDrink(_drinkModel, TEST_NAME, TEST_PRICE.ToString());
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");
            Assert.AreEqual(TEST_NAME, drinkList[0].GetName());
        }

        [TestMethod()]
        public void ClickNewAdditionTest()
        {
            _managementPresentation.ClickNewAddition(_drinkModel, TEST_NAME, TEST_PRICE.ToString());
            bool targetEnabled = (bool)_privateManagementPresentationPresentation.GetFieldOrProperty("_isNewAdditionTextBoxEnabled");
            Assert.IsTrue(targetEnabled);

            _managementPresentation.ClickNewAddition(_drinkModel, TEST_NAME, TEST_PRICE.ToString());
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");
            Assert.AreEqual(TEST_NAME, additionList[0].GetName());
        }

        [TestMethod()]
        public void ClickFileImportDrinkTest()
        {
            _managementPresentation.ClickFileImportDrink(_drinkModel);
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");
            Assert.AreEqual(0, drinkList.Count);
        }

        [TestMethod()]
        public void ClickFileImportAdditionTest()
        {
            _managementPresentation.ClickFileImportAddition(_drinkModel);
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");
            Assert.AreEqual(0, additionList.Count);
        }

        [TestMethod()]
        public void ClickDrinkListDataGridViewTest()
        {
            _drinkModel.AddDrink(TEST_NAME, TEST_PRICE);
            _managementPresentation.ClickDrinkListDataGridView(_drinkModel, 0);
            List<Drink> drinkList = (List<Drink>)_privateDrinkModel.GetFieldOrProperty("_drinkList");
            Assert.AreEqual(0, drinkList.Count);
        }

        [TestMethod()]
        public void ClickAdditionListDataGridViewTest()
        {
            _drinkModel.AddAddition(TEST_NAME, TEST_PRICE);
            _managementPresentation.ClickAdditionListDataGridView(_drinkModel, 0);
            List<DrinkAddition> additionList = (List<DrinkAddition>)_privateDrinkModel.GetFieldOrProperty("_additionList");
            Assert.AreEqual(0, additionList.Count);
        }

        [TestMethod()]
        public void IsNewDrinkTextBoxEnabledTest()
        {
            _privateManagementPresentationPresentation.SetFieldOrProperty("_isNewDrinkTextBoxEnabled", true);
            Assert.AreEqual(true, _managementPresentation.IsNewDrinkTextBoxEnabled());

            _privateManagementPresentationPresentation.SetFieldOrProperty("_isNewDrinkTextBoxEnabled", false);
            Assert.AreEqual(false, _managementPresentation.IsNewDrinkTextBoxEnabled());
        }

        [TestMethod()]
        public void IsNewAdditionTextBoxEnabledTest()
        {
            _privateManagementPresentationPresentation.SetFieldOrProperty("_isNewAdditionTextBoxEnabled", true);
            Assert.AreEqual(true, _managementPresentation.IsNewAdditionTextBoxEnabled());

            _privateManagementPresentationPresentation.SetFieldOrProperty("_isNewAdditionTextBoxEnabled", false);
            Assert.AreEqual(false, _managementPresentation.IsNewAdditionTextBoxEnabled());
        }

        [TestMethod()]
        public void GetNewDrinkTextTest()
        {
            _privateManagementPresentationPresentation.SetFieldOrProperty("_newDrinkText", "");
            Assert.AreEqual("", _managementPresentation.GetNewDrinkText());

            _privateManagementPresentationPresentation.SetFieldOrProperty("_newDrinkText", null);
            Assert.AreEqual(null, _managementPresentation.GetNewDrinkText());
        }

        [TestMethod()]
        public void GetFileImportDrinkTextTest()
        {
            _privateManagementPresentationPresentation.SetFieldOrProperty("_fileImportDrinkText", "");
            Assert.AreEqual("", _managementPresentation.GetFileImportDrinkText());

            _privateManagementPresentationPresentation.SetFieldOrProperty("_fileImportDrinkText", null);
            Assert.AreEqual(null, _managementPresentation.GetFileImportDrinkText());
        }

        [TestMethod()]
        public void GetNewAdditionTextTest()
        {
            _privateManagementPresentationPresentation.SetFieldOrProperty("_newAdditionText", "");
            Assert.AreEqual("", _managementPresentation.GetNewAdditionText());

            _privateManagementPresentationPresentation.SetFieldOrProperty("_newAdditionText", null);
            Assert.AreEqual(null, _managementPresentation.GetNewAdditionText());
        }

        [TestMethod()]
        public void GetFileImportAdditionTextTest()
        {
            _privateManagementPresentationPresentation.SetFieldOrProperty("_fileImportAdditionText", "");
            Assert.AreEqual("", _managementPresentation.GetFileImportAdditionText());

            _privateManagementPresentationPresentation.SetFieldOrProperty("_fileImportAdditionText", null);
            Assert.AreEqual(null, _managementPresentation.GetFileImportAdditionText());
        }
    }
}