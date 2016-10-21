using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class PresentationModel
    {
        //Change the button state when clciking categort datagridview
        public void ClickCategoryDataGridView()
        {
            _isNormalSugarEnabled = true;
            _isHalfSugarEnabled = true;
            _isLessSugarEnabled = true;
            _isNoSugarEnabled = true;
            _isNormalIceEnabled = true;
            _isLessIceEnabled = true;
            _isNoIceEnabled = true;
            _isHotEnabled = true;
            _isAdditionDataGridViewEnabled = true;
        }

        //Change the button state when clciking order datagridview
        public void ClickOrderDataGridView(DrinkModel drinkModel)
        {
            if (drinkModel.GetOrderListSize() == 0)
            {
                _isNormalSugarEnabled = false;
                _isHalfSugarEnabled = false;
                _isLessSugarEnabled = false;
                _isNoSugarEnabled = false;
                _isNormalIceEnabled = false;
                _isLessIceEnabled = false;
                _isNoIceEnabled = false;
                _isHotEnabled = false;
                _isAdditionDataGridViewEnabled = false;
            }
        }

        //Update pay button state when clciking sugar, temperature or delete order
        public void UpdatePayState(DrinkModel drinkModel)
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

        //Change the button state when clciking pay button
        public void ClickPay()
        {
            _isNormalSugarEnabled = false;
            _isHalfSugarEnabled = false;
            _isLessSugarEnabled = false;
            _isNoSugarEnabled = false;
            _isNormalIceEnabled = false;
            _isLessIceEnabled = false;
            _isNoIceEnabled = false;
            _isHotEnabled = false;
            _isPayEnabled = false;
            _isAdditionDataGridViewEnabled = false;
        }

        //Get total price label text from drink model
        public string GetTotalPriceLabelText(DrinkModel drinkModel)
        {
            const string TOTAL_PRICE_TEXT = "總價: ";
            return TOTAL_PRICE_TEXT + drinkModel.GetOrderListTotalPrice();
        }

        //Get the Normal Sugar button is enabled or not
        public bool IsNormalSugarEnabled()
        {
            return _isNormalSugarEnabled;
        }

        //Get the Half Sugar button is enabled or not
        public bool IsHalfSugarEnabled()
        {
            return _isHalfSugarEnabled;
        }

        //Get the Less Sugar button is enabled or not
        public bool IsLessSugarEnabled()
        {
            return _isLessSugarEnabled;
        }

        //Get the No Sugar button is enabled or not
        public bool IsNoSugarEnabled()
        {
            return _isNoSugarEnabled;
        }

        //Get the Normal Ice button is enabled or not
        public bool IsNormalIceEnabled()
        {
            return _isNormalIceEnabled;
        }

        //Get the Less Ice button is enabled or not
        public bool IsLessIceEnabled()
        {
            return _isLessIceEnabled;
        }

        //Get the No Ice button is enabled or not
        public bool IsNoIceEnabled()
        {
            return _isNoIceEnabled;
        }

        //Get the Hot button is enabled or not
        public bool IsHotEnabled()
        {
            return _isHotEnabled;
        }

        //Get the Pay button is enabled or not
        public bool IsPayEnabled()
        {
            return _isPayEnabled;
        }

        //Get the Addition datagridview button is enabled or not
        public bool IsAdditionDataGridViewEnabled()
        {
            return _isAdditionDataGridViewEnabled;
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
    }
}