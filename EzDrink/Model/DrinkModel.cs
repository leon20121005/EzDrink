using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class DrinkModel
    {
        OrderList _orderList = new OrderList();
        List<Drink> _drinkList = new List<Drink>();
        List<DrinkAddition> _additionList = new List<DrinkAddition>();
        List<OrderList> _allList = new List<OrderList>();

        #region Constant Declaration

        const string DRINK1_NAME = "茉莉綠茶";
        const int DRINK1_PRICE = 20;
        Drink _drink1 = new Drink(DRINK1_NAME, DRINK1_PRICE);

        const string DRINK2_NAME = "阿薩姆紅茶";
        const int DRINK2_PRICE = 25;
        Drink _drink2 = new Drink(DRINK2_NAME, DRINK2_PRICE);

        const string DRINK3_NAME = "高山青茶";
        const int DRINK3_PRICE = 40;
        Drink _drink3 = new Drink(DRINK3_NAME, DRINK3_PRICE);

        const string DRINK4_NAME = "鐵觀音";
        const int DRINK4_PRICE = 50;
        Drink _drink4 = new Drink(DRINK4_NAME, DRINK4_PRICE);

        const string DRINK5_NAME = "烏龍青茶";
        const int DRINK5_PRICE = 30;
        Drink _drink5 = new Drink(DRINK5_NAME, DRINK5_PRICE);

        const string ADDITION1_NAME = "珍珠";
        const int ADDITION1_PRICE = 5;
        DrinkAddition _addition1 = new DrinkAddition(ADDITION1_NAME, ADDITION1_PRICE);

        const string ADDITION2_NAME = "椰果";
        const int ADDITION2_PRICE = 5;
        DrinkAddition _addition2 = new DrinkAddition(ADDITION2_NAME, ADDITION2_PRICE);

        const string ADDITION3_NAME = "仙草";
        const int ADDITION3_PRICE = 10;
        DrinkAddition _addition3 = new DrinkAddition(ADDITION3_NAME, ADDITION3_PRICE);

        const string ADDITION4_NAME = "布丁";
        const int ADDITION4_PRICE = 10;
        DrinkAddition _addition4 = new DrinkAddition(ADDITION4_NAME, ADDITION4_PRICE);

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
            _drinkList.Add(_drink1);
            _drinkList.Add(_drink2);
            _drinkList.Add(_drink3);
            _drinkList.Add(_drink4);
            _drinkList.Add(_drink5);

            _additionList.Add(_addition1);
            _additionList.Add(_addition2);
            _additionList.Add(_addition3);
            _additionList.Add(_addition4);
        }

        //Add the order into the order list
        public void AddDrink(int drinkListIndex)
        {
            _orderList.AddOrder(new Order(_drinkList[drinkListIndex]));
        } 

        //Delete the order in the order list
        public void DeleteOrder(int orderListIndex)
        {
            _orderList.DeleteOrder(orderListIndex);
        }
        
        //Add the drink addition into the order list
        public void AddAddition(int additionListIndex, int orderListIndex)
        {
            _orderList.AddOrderAddition(orderListIndex, _additionList[additionListIndex]);
        }

        //Return the size of the order list
        public int GetOrderListSize()
        {
            return _orderList.GetOrderListSize();
        }

        //Return the size of the order drink addition list 
        public int GetOrderAdditionListSize(int orderListIndex)
        {
            return _orderList.GetOrderAdditionListSize(orderListIndex);
        }

        //Return the drink name in the drink list
        public string GetDrinkName(int drinkListIndex)
        {
            return _drinkList[drinkListIndex].GetName();
        }
        
        //Return the drink price in the drink list
        public int GetDrinkPrice(int drinkListIndex)
        {
            return _drinkList[drinkListIndex].GetPrice();
        }

        //Return the drink addition name in the drink addition list
        public string GetAdditionName(int additionListIndex)
        {
            return _additionList[additionListIndex].GetName();
        }

        //Return the drink addition price in the drink addition list
        public int GetAdditionPrice(int additionListIndex)
        {
            return _additionList[additionListIndex].GetPrice();
        }

        //Return the order total price in the order list
        public int GetOrderTotalPrice(int orderListIndex)
        {
            return _orderList.GetOrderTotalPrice(orderListIndex);
        }

        //Return the order sweetness in the order list
        public Sugar GetOrderSugar(int orderListIndex)
        {
            return _orderList.GetOrderSugar(orderListIndex);
        }

        //Return the order ice level in the order list
        public Temperature GetOrderTemperature(int orderListIndex)
        {
            return _orderList.GetOrderTemperature(orderListIndex);
        }
        
        //Return the order addition name in the order list
        public string GetOrderAdditionName(int orderListIndex, int additionListIndex)
        {
            return _orderList.GetOrderAdditionName(orderListIndex, additionListIndex);
        }

        //Transform the sugar type into the string type
        public string ConvertSugarToString(Sugar sugar)
        {
            switch (sugar)
            {
                case Sugar.NormalSugar:
                    return NORMAL_SUGAR_TEXT;
                case Sugar.HalfSugar:
                    return HALF_SUGAR_TEXT;
                case Sugar.LessSugar:
                    return LESS_SUGAR_TEXT;
                case Sugar.NoSugar:
                    return NO_SUGAR_TEXT;
                default:
                    return ERROR_TEXT;
            }
        }

        //Transform the temperature type into the string type
        public string ConvertTemperatureToString(Temperature temperature)
        {
            switch (temperature)
            {
                case Temperature.NormalIce:
                    return NORMAL_ICE_TEXT;
                case Temperature.LessIce:
                    return LESS_ICE_TEXT;
                case Temperature.NoIce:
                    return NO_ICE_TEXT;
                case Temperature.Hot:
                    return HOT_TEXT;
                default:
                    return ERROR_TEXT;
            }
        }

        //Set the sweetness of the order
        public void SetSugar(int orderListIndex, Sugar sugar)
        {
            _orderList.SetOrderSugar(orderListIndex, sugar); 
        }

        //Set the ice level of the order
        public void SetTemperature(int orderListIndex, Temperature temperature)
        {
            _orderList.SetOrderTemperature(orderListIndex, temperature);
        }

        //Return the order list total price from the order list
        public string GetOrderListTotalPrice()
        {
            return _orderList.GetOrderListTotalPrice().ToString();
        }

        //Store the current order list into the list of the order list
        public void StoreOrderList()
        {
            _allList.Add(_orderList);
            _orderList.ClearOrderList();
        }
    }
}