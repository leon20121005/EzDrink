using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public partial class DrinkModel
    {
        #region Constant Declaration

        const string DRINK1_NAME = "茉莉綠茶";
        const int DRINK1_PRICE = 20;
        const string DRINK2_NAME = "阿薩姆紅茶";
        const int DRINK2_PRICE = 25;
        const string DRINK3_NAME = "高山青茶";
        const int DRINK3_PRICE = 40;
        const string DRINK4_NAME = "鐵觀音";
        const int DRINK4_PRICE = 50;
        const string DRINK5_NAME = "烏龍青茶";
        const int DRINK5_PRICE = 30;

        const string ADDITION1_NAME = "珍珠";
        const int ADDITION1_PRICE = 5;
        const string ADDITION2_NAME = "椰果";
        const int ADDITION2_PRICE = 5;
        const string ADDITION3_NAME = "仙草";
        const int ADDITION3_PRICE = 10;
        const string ADDITION4_NAME = "布丁";
        const int ADDITION4_PRICE = 10;

        const string NORMAL_SUGAR_TEXT = "正常";
        const string HALF_SUGAR_TEXT = "半糖";
        const string LESS_SUGAR_TEXT = "少糖";
        const string NO_SUGAR_TEXT = "無糖";
        const string NORMAL_ICE_TEXT = "正常";
        const string LESS_ICE_TEXT = "少冰";
        const string NO_ICE_TEXT = "去冰";
        const string HOT_TEXT = "溫熱";
        const string ERROR_TEXT = "Error";

        #endregion

        //Initialize the drink list and the drink addition list
        public void InitializeList()
        {
            _drinkList.Add(new Drink(DRINK1_NAME, DRINK1_PRICE));
            _drinkList.Add(new Drink(DRINK2_NAME, DRINK2_PRICE));
            _drinkList.Add(new Drink(DRINK3_NAME, DRINK3_PRICE));
            _drinkList.Add(new Drink(DRINK4_NAME, DRINK4_PRICE));
            _drinkList.Add(new Drink(DRINK5_NAME, DRINK5_PRICE));

            _additionList.Add(new DrinkAddition(ADDITION1_NAME, ADDITION1_PRICE));
            _additionList.Add(new DrinkAddition(ADDITION2_NAME, ADDITION2_PRICE));
            _additionList.Add(new DrinkAddition(ADDITION3_NAME, ADDITION3_PRICE));
            _additionList.Add(new DrinkAddition(ADDITION4_NAME, ADDITION4_PRICE));
        }
    }
}