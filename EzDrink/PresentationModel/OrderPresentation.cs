using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class OrderPresentation
    {
        //Change the button state and access to the model when clciking category datagridview
        public void ClickCategoryDataGridView(DrinkModel drinkModel, int categoryRowIndex)
        {
            drinkModel.AddOrder(categoryRowIndex);
            UpdateTotalPriceLabel(drinkModel);
            UpdatePayState(drinkModel);

            SetButtonEnable(true);        
        }

        //Change the button state and access to the model when clciking addition datagridview
        public void ClickAdditionDataGridView(DrinkModel drinkModel, int additionRowIndex, int orderRowIndex)
        {
            drinkModel.AddOrderAddition(additionRowIndex, orderRowIndex);
            UpdateTotalPriceLabel(drinkModel);
        }

        //Change the button state and access to the model when clciking order datagridview
        public void ClickOrderDataGridView(DrinkModel drinkModel, int orderRowIndex)
        {
            drinkModel.DeleteOrder(orderRowIndex);
            UpdateTotalPriceLabel(drinkModel);
            UpdatePayState(drinkModel);

            if (drinkModel.GetOrderListSize() == 0)
            {
                SetButtonEnable(false);
            }          
        }

        //Change the button state and access to the model when clciking sugar buttons
        public void ClickSugarButton(DrinkModel drinkModel, int rowIndex, Sugar sugar)
        {
            drinkModel.SetOrderSugar(rowIndex, sugar);
            UpdatePayState(drinkModel);
        }

        //Change the button state and access to the model when clciking temperature buttons
        public void ClickTemperatureButton(DrinkModel drinkModel, int rowIndex, Temperature temperature)
        {
            drinkModel.SetOrderTemperature(rowIndex, temperature);
            UpdatePayState(drinkModel);
        }

        //Change the button state and access to the model when clciking pay button
        public void ClickPay(DrinkModel drinkModel)
        {
            drinkModel.StoreOrderList();
            UpdateTotalPriceLabel(drinkModel);
            UpdatePayState(drinkModel);

            SetButtonEnable(false);
        }

        //Return the enabled state of the normal sugar button
        public bool IsNormalSugarEnabled()
        {
            return _isNormalSugarEnabled;
        }

        //Return the enabled state of the half sugar button
        public bool IsHalfSugarEnabled()
        {
            return _isHalfSugarEnabled;
        }

        //Return the enabled state of the less sugar button
        public bool IsLessSugarEnabled()
        {
            return _isLessSugarEnabled;
        }

        //Return the enabled state of the no sugar button
        public bool IsNoSugarEnabled()
        {
            return _isNoSugarEnabled;
        }

        //Return the enabled state of the normal ice button
        public bool IsNormalIceEnabled()
        {
            return _isNormalIceEnabled;
        }

        //Return the enabled state of the less ice button
        public bool IsLessIceEnabled()
        {
            return _isLessIceEnabled;
        }

        //Return the enabled state of the no ice button
        public bool IsNoIceEnabled()
        {
            return _isNoIceEnabled;
        }

        //Return the enabled state of the hot button
        public bool IsHotEnabled()
        {
            return _isHotEnabled;
        }

        //Return the enabled state of the pay button
        public bool IsPayEnabled()
        {
            return _isPayEnabled;
        }

        //Return the enabled state of the addition datagridview
        public bool IsAdditionDataGridViewEnabled()
        {
            return _isAdditionDataGridViewEnabled;
        }

        //Return the text of the total price label
        public string GetTotalPriceLabelText()
        {
            return _totalPriceLabelText;
        }

        //Update the text of the total price label from drink model
        private void UpdateTotalPriceLabel(DrinkModel drinkModel)
        {
            const string TOTAL_PRICE_TEXT = "總價: ";
            _totalPriceLabelText = TOTAL_PRICE_TEXT + drinkModel.GetOrderListTotalPrice().ToString();
        }

        //Update the state of the pay button when clciking category, sugar, temperature, delete order or pay
        private void UpdatePayState(DrinkModel drinkModel)
        {
            _isPayEnabled = true;

            if (drinkModel.GetOrderListSize() == 0)
            {
                _isPayEnabled = false;
            }

            for (int i = 0; i < drinkModel.GetOrderListSize(); i++)
            {
                if (drinkModel.GetOrderSugar(i) == Sugar.Null || drinkModel.GetOrderTemperature(i) == Temperature.Null)
                {
                    _isPayEnabled = false;
                }
            }
        }

        //Set the state of the 9 buttons
        private void SetButtonEnable(bool enabled)
        {
            _isNormalSugarEnabled = enabled;
            _isHalfSugarEnabled = enabled;
            _isLessSugarEnabled = enabled;
            _isNoSugarEnabled = enabled;
            _isNormalIceEnabled = enabled;
            _isLessIceEnabled = enabled;
            _isNoIceEnabled = enabled;
            _isHotEnabled = enabled;

            _isAdditionDataGridViewEnabled = enabled;
        }

        private bool _isNormalSugarEnabled = false;
        private bool _isHalfSugarEnabled = false;
        private bool _isLessSugarEnabled = false;
        private bool _isNoSugarEnabled = false;
        private bool _isNormalIceEnabled = false;
        private bool _isLessIceEnabled = false;
        private bool _isNoIceEnabled = false;
        private bool _isHotEnabled = false;
        private bool _isPayEnabled = false;
        private bool _isAdditionDataGridViewEnabled = false;
        private string _totalPriceLabelText;
    }
}