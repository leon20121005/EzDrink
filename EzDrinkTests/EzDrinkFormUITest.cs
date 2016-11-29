using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using ezLogUITest;

namespace EzDrinkFormUITest
{
    /// <summary>
    /// CodedUITest1 的摘要描述
    /// </summary>
    [CodedUITest]
    public class EzDrinkFormUITest
    {
        //Relative path
        private const string FILE_PATH = "..\\..\\..\\EzDrink\\obj\\Debug\\EzDrink.exe";
        private const string TITLE = "EzDrink";

        public EzDrinkFormUITest()
        {
        }

        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, TITLE);
        }

        [TestMethod]
        public void UITestNewDrinkButtonEnable()
        {
            // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
            Robot.ClickTabControl("後台管理");
            Robot.ClickButton("_newDrinkButton");
            Robot.AssertEdit("_drinkNameTextBox", "");
        }

        [TestMethod]
        public void UITestNewDrinkButton()
        {
            Robot.ClickTabControl("後台管理");
            Robot.ClickButton("_newDrinkButton");
            Robot.SetEdit("_drinkNameTextBox", "test drink");
            Robot.SetEdit("_drinkPriceTextBox", "0");
            Robot.ClickButton("_newDrinkButton");
            Robot.AssertDataItemsInDataGridView("_drinkListDataGridView", 6);
        }

        [TestMethod]
        public void UITestFileImportDrinkButton()
        {
            Robot.ClickTabControl("後台管理");

            Robot.ClickButton("_newDrinkButton");
            Robot.ClickButton("_fileImportDrinkButton");

            Robot.ClickButton("_fileImportDrinkButton");
            Robot.AssertWindow("開啟");
        }

        [TestMethod]
        public void UITestNewAdditionButtonEnable()
        {
            Robot.ClickTabControl("後台管理");
            Robot.ClickButton("_newAdditionButton");
            Robot.AssertEdit("_additionNameTextBox", "");
        }

        [TestMethod]
        public void UITestNewAdditionButton()
        {
            Robot.ClickTabControl("後台管理");
            Robot.ClickButton("_newAdditionButton");
            Robot.SetEdit("_additionNameTextBox", "test addition");
            Robot.SetEdit("_additionPriceTextBox", "0");
            Robot.ClickButton("_newAdditionButton");
            Robot.AssertDataItemsInDataGridView("_additionListDataGridView", 5);
        }

        [TestMethod]
        public void UITestFileImportAdditionButton()
        {
            Robot.ClickTabControl("後台管理");

            Robot.ClickButton("_newAdditionButton");
            Robot.ClickButton("_fileImportAdditionButton");

            Robot.ClickButton("_fileImportAdditionButton");
            Robot.AssertWindow("開啟");
        }

        [TestMethod]
        public void UITestButtonsEnable()
        {
            AssertButtonsEnable(false);
            Robot.AssertButtonEnable("_payButton", false);

            Robot.ClickDataGridView("_drinkDataGridView", "1");

            AssertButtonsEnable(true);
            Robot.AssertButtonEnable("_payButton", false);

            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.AssertButtonEnable("_payButton", true);
        }

        [TestMethod]
        public void UITestSugarButtons()
        {
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.ClickDataGridView("_additionDataGridView", "1");
            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.AssertDataGridViewByIndex("_orderDataGridView", "1", new string[] { "茉莉綠茶", "25", "正常", "正常", "珍珠", "刪除" });

            Robot.ClickButton("_halfSugarButton");
            Robot.AssertDataGridViewByIndex("_orderDataGridView", "1", new string[] { "茉莉綠茶", "25", "半糖", "正常", "珍珠", "刪除" });

            Robot.ClickButton("_lessSugarButton");
            Robot.AssertDataGridViewByIndex("_orderDataGridView", "1", new string[] { "茉莉綠茶", "25", "少糖", "正常", "珍珠", "刪除" });

            Robot.ClickButton("_noSugarButton");
            Robot.AssertDataGridViewByIndex("_orderDataGridView", "1", new string[] { "茉莉綠茶", "25", "無糖", "正常", "珍珠", "刪除" });
        }

        [TestMethod]
        public void UITestIceButtons()
        {
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.ClickDataGridView("_additionDataGridView", "1");
            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.AssertDataGridViewByIndex("_orderDataGridView", "1", new string[] { "茉莉綠茶", "25", "正常", "正常", "珍珠", "刪除" });

            Robot.ClickButton("_lessIceButton");
            Robot.AssertDataGridViewByIndex("_orderDataGridView", "1", new string[] { "茉莉綠茶", "25", "正常", "少冰", "珍珠", "刪除" });

            Robot.ClickButton("_noIceButton");
            Robot.AssertDataGridViewByIndex("_orderDataGridView", "1", new string[] { "茉莉綠茶", "25", "正常", "去冰", "珍珠", "刪除" });

            Robot.ClickButton("_hotButton");
            Robot.AssertDataGridViewByIndex("_orderDataGridView", "1", new string[] { "茉莉綠茶", "25", "正常", "溫熱", "珍珠", "刪除" });
        }

        [TestMethod]
        public void UITestPay()
        {
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.ClickButton("_payButton");

            AssertButtonsEnable(false);
            Robot.AssertButtonEnable("_payButton", false);
        }

        [TestMethod]
        public void UITestDrinkDataGridView()
        {
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.AssertDataItemsInDataGridView("_orderDataGridView", 1);
        }

        [TestMethod]
        public void UITestAdditionDataGridView()
        {
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.ClickDataGridView("_additionDataGridView", "1");
            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.AssertDataGridViewByIndex("_orderDataGridView", "1", new string[] { "茉莉綠茶", "25", "正常", "正常", "珍珠", "刪除" });
        }

        [TestMethod]
        public void UITestOrderDataGridView()
        {
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.AssertDataItemsInDataGridView("_orderDataGridView", 1);
            Robot.DeleteOrderDataGridView("_orderDataGridView", "1");
            Robot.AssertDataItemsInDataGridView("_orderDataGridView", 0);
        }

        [TestMethod]
        public void UITestDrinkListDataGridView()
        {
            Robot.ClickTabControl("後台管理");
            Robot.DeleteDataGridView("_drinkListDataGridView", "1");
            Robot.AssertWindow("訊息");
        }

        [TestMethod]
        public void UITestAdditionListDataGridView()
        {
            Robot.ClickTabControl("後台管理");
            Robot.DeleteDataGridView("_additionListDataGridView", "1");
            Robot.AssertWindow("訊息");
        }

        [TestMethod]
        public void UITestHistoryDataGridView()
        {
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.ClickButton("_payButton");
            Robot.ClickTabControl("歷史紀錄");
            Robot.AssertDataItemsInDataGridView("_historyDataGridView", 1);
        }

        [TestMethod]
        public void UITestDetailDataGridView()
        {
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.ClickDataGridView("_orderDataGridView", "2");
            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.ClickButton("_payButton");
            Robot.ClickTabControl("歷史紀錄");
            Robot.ClickDataGridView("_historyDataGridView", "1");
            Robot.AssertDataItemsInDataGridView("_detailDataGridView", 2);
        }

        [TestMethod]
        public void UITestIntegratedCase()
        {
            Robot.ClickDataGridView("_drinkDataGridView", "1");
            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.ClickButton("_payButton");
            Robot.ClickDataGridView("_drinkDataGridView", "2");
            Robot.ClickButton("_normalSugarButton");
            Robot.ClickButton("_normalIceButton");
            Robot.ClickButton("_payButton");
            Robot.ClickTabControl("歷史紀錄");
            Robot.AssertDataItemsInDataGridView("_historyDataGridView", 2);
        }

        [TestMethod]
        public void UITestExit()
        {
            Robot.ClickMenuItem(new string[] { "File", "Exit" });
        }

        [TestMethod]
        public void UITestAbout()
        {
            Robot.ClickMenuItem(new string[] { "Help", "About" });
            Robot.AssertWindow("關於 EzDrink");
        }

        private void AssertButtonsEnable(bool enable)
        {
            Robot.AssertButtonEnable("_normalSugarButton", enable);
            Robot.AssertButtonEnable("_halfSugarButton", enable);
            Robot.AssertButtonEnable("_lessSugarButton", enable);
            Robot.AssertButtonEnable("_noSugarButton", enable);
            Robot.AssertButtonEnable("_normalIceButton", enable);
            Robot.AssertButtonEnable("_lessIceButton", enable);
            Robot.AssertButtonEnable("_noIceButton", enable);
            Robot.AssertButtonEnable("_hotButton", enable);
        }

        #region 其他測試屬性

        // 您可以使用下列其他屬性撰寫測試: 

        ////在每項測試執行前先使用 TestInitialize 執行程式碼 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
        //}

        ////在每項測試執行後使用 TestCleanup 執行程式碼
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
        //}

        #endregion

        /// <summary>
        ///取得或設定提供目前測試回合
        ///相關資訊與功能的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}