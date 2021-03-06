﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class EzDrinkForm : Form
    {
        DrinkModel _drinkModel = new DrinkModel();
        OrderPresentation _orderPresentation = new OrderPresentation();
        ManagementPresentation _managementPresentation = new ManagementPresentation();
        HistoryPresentation _historyPresentation = new HistoryPresentation();

        const int SUGAR_COLUMN = 2;
        const int TEMPERATURE_COLUMN = 3;
        const int ADDITION_COLUMN = 4;
        const int PRICE_COLUMN = 2;
        const string SELECT_BUTTON_TEXT = "選擇";
        const string DELETE_BUTTON_TEXT = "刪除";

        public EzDrinkForm()
        {
            InitializeComponent();
            _drinkModel.InitializeList();

            UpdateDrinkDataGridView(_drinkDataGridView, SELECT_BUTTON_TEXT);
            UpdateAdditionDataGridView(_additionDataGridView, SELECT_BUTTON_TEXT);
            UpdateOrderButtonState();
            SetAdditionDataGridViewEnable(_orderPresentation.IsAdditionDataGridViewEnabled());
        }

        //Close the application if clicking the exit
        private void ClickExitToolStripMenuItem(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Add the drink into the order list if clicking the select button (e.ColumnIndex = 0)
        private void ClickDrinkDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                _orderPresentation.ClickDrinkDataGridView(_drinkModel, e.RowIndex);
                _orderDataGridView.Rows.Add(_drinkModel.GetDrinkName(e.RowIndex), _drinkModel.GetDrinkPrice(e.RowIndex));
                UpdateOrderButtonState();
                SetAdditionButtonDisable(_orderDataGridView.CurrentRow.Index);
            }
        }

        //Add the drink addition into the order list if clicking the select button (e.ColumnIndex = 0)
        private void ClickAdditionDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && ((DataGridViewDisableButtonCell)_additionDataGridView.Rows[e.RowIndex].Cells[0]).Enabled != false)
            {
                _orderPresentation.ClickAdditionDataGridView(_drinkModel, _orderDataGridView.CurrentRow.Index, _additionDataGridView.CurrentRow.Index);
                _orderDataGridView.CurrentRow.Cells[1].Value = _drinkModel.OrderList.GetOrderTotalPrice(_orderDataGridView.CurrentRow.Index).ToString();
                _orderDataGridView.CurrentRow.Cells[ADDITION_COLUMN].Value = _orderPresentation.GetAdditionItems(_drinkModel.OrderList, _orderDataGridView.CurrentRow.Index);
                UpdateOrderButtonState();
                SetAdditionButtonDisable(_orderDataGridView.CurrentRow.Index);
            }
        }

        //Delete the order in the order list if clicking the delete button (e.ColumnIndex = 5)
        private void ClickOrderDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                _orderPresentation.ClickOrderDataGridView(_drinkModel, e.RowIndex);
                _orderDataGridView.Rows.RemoveAt(e.RowIndex);
                UpdateOrderButtonState();
                SetAdditionDataGridViewEnable(_orderPresentation.IsAdditionDataGridViewEnabled());

            }
            if (_drinkModel.OrderList.GetOrderListSize() != 0)
            {
                SetAdditionButtonDisable(_orderDataGridView.CurrentRow.Index);
            }
        }

        //Ensure that addition datagridview will always refresh when user clicks order datagridview 
        private void ClickOrderDataGridView(object sender, EventArgs e)
        {
            if (_drinkModel.OrderList.GetOrderListSize() != 0)
            {
                SetAdditionButtonDisable(_orderDataGridView.CurrentRow.Index);
            }
        }

        //Set the sweetness to normal sugar
        private void ClickNormalSugarButton(object sender, EventArgs e)
        {
            _orderPresentation.ClickSugarButton(_drinkModel, _orderDataGridView.CurrentRow.Index, Sugar.NormalSugar);
            _orderDataGridView.CurrentRow.Cells[SUGAR_COLUMN].Value = _drinkModel.ConvertSugarToString(Sugar.NormalSugar);
            UpdateOrderButtonState();
        }

        //Set the sweetness to half sugar
        private void ClickHalfSugarButton(object sender, EventArgs e)
        {
            _orderPresentation.ClickSugarButton(_drinkModel, _orderDataGridView.CurrentRow.Index, Sugar.HalfSugar);
            _orderDataGridView.CurrentRow.Cells[SUGAR_COLUMN].Value = _drinkModel.ConvertSugarToString(Sugar.HalfSugar);
            UpdateOrderButtonState();
        }

        //Set the sweetness to less sugar
        private void ClickLessSugarButton(object sender, EventArgs e)
        {
            _orderPresentation.ClickSugarButton(_drinkModel, _orderDataGridView.CurrentRow.Index, Sugar.LessSugar);
            _orderDataGridView.CurrentRow.Cells[SUGAR_COLUMN].Value = _drinkModel.ConvertSugarToString(Sugar.LessSugar);
            UpdateOrderButtonState();
        }

        //Set the sweetness to no sugar
        private void ClickNoSugarButton(object sender, EventArgs e)
        {
            _orderPresentation.ClickSugarButton(_drinkModel, _orderDataGridView.CurrentRow.Index, Sugar.NoSugar);
            _orderDataGridView.CurrentRow.Cells[SUGAR_COLUMN].Value = _drinkModel.ConvertSugarToString(Sugar.NoSugar);
            UpdateOrderButtonState();
        }

        //Set the ice level to normal ice
        private void ClickNormalIceButton(object sender, EventArgs e)
        {
            _orderPresentation.ClickTemperatureButton(_drinkModel, _orderDataGridView.CurrentRow.Index, Temperature.NormalIce);
            _orderDataGridView.CurrentRow.Cells[TEMPERATURE_COLUMN].Value = _drinkModel.ConvertTemperatureToString(Temperature.NormalIce);
            UpdateOrderButtonState();
        }

        //Set the ice level to less ice
        private void ClickLessIceButton(object sender, EventArgs e)
        {
            _orderPresentation.ClickTemperatureButton(_drinkModel, _orderDataGridView.CurrentRow.Index, Temperature.LessIce);
            _orderDataGridView.CurrentRow.Cells[TEMPERATURE_COLUMN].Value = _drinkModel.ConvertTemperatureToString(Temperature.LessIce);
            UpdateOrderButtonState();
        }

        //Set the ice level to no ice
        private void ClickNoIceButton(object sender, EventArgs e)
        {
            _orderPresentation.ClickTemperatureButton(_drinkModel, _orderDataGridView.CurrentRow.Index, Temperature.NoIce);
            _orderDataGridView.CurrentRow.Cells[TEMPERATURE_COLUMN].Value = _drinkModel.ConvertTemperatureToString(Temperature.NoIce);
            UpdateOrderButtonState();
        }

        //Set the ice level to hot
        private void ClickHotButton(object sender, EventArgs e)
        {
            _orderPresentation.ClickTemperatureButton(_drinkModel, _orderDataGridView.CurrentRow.Index, Temperature.Hot);
            _orderDataGridView.CurrentRow.Cells[TEMPERATURE_COLUMN].Value = _drinkModel.ConvertTemperatureToString(Temperature.Hot);
            UpdateOrderButtonState();
        }

        //Store the current order list and clear the datagridview
        private void ClickPayButton(object sender, EventArgs e)
        {
            int currentTotalPrice = _drinkModel.OrderList.GetOrderListTotalPrice();
            _orderPresentation.ClickPay(_drinkModel);
            _orderDataGridView.Rows.Clear();
            UpdateOrderButtonState();
            SetAdditionDataGridViewEnable(_orderPresentation.IsAdditionDataGridViewEnabled());
            _historyTotalPriceLabel.Text = _historyPresentation.UpdateHistoryTotalPriceLabel(_drinkModel);
            _historyDataGridView.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd tt hh:mm:ss"), currentTotalPrice);
        }

        //Update the state of the order system buttons
        private void UpdateOrderButtonState()
        {
            _normalSugarButton.Enabled = _orderPresentation.IsSugarTemperatureEnabled();
            _halfSugarButton.Enabled = _orderPresentation.IsSugarTemperatureEnabled();
            _lessSugarButton.Enabled = _orderPresentation.IsSugarTemperatureEnabled();
            _noSugarButton.Enabled = _orderPresentation.IsSugarTemperatureEnabled();
            _normalIceButton.Enabled = _orderPresentation.IsSugarTemperatureEnabled();
            _lessIceButton.Enabled = _orderPresentation.IsSugarTemperatureEnabled();
            _noIceButton.Enabled = _orderPresentation.IsSugarTemperatureEnabled();
            _hotButton.Enabled = _orderPresentation.IsSugarTemperatureEnabled();
            _payButton.Enabled = _orderPresentation.IsPayEnabled();
            _totalPriceLabel.Text = _orderPresentation.GetTotalPriceLabelText();
        }

        //Set all addition datagridview buttons enable or disable
        private void SetAdditionDataGridViewEnable(bool enabled)
        {
            foreach (DataGridViewRow row in _additionDataGridView.Rows)
            {
                ((DataGridViewDisableButtonCell)row.Cells[0]).Enabled = enabled;
            }
            _additionDataGridView.Refresh();
        }

        //Set addition datagridview button disable individually
        private void SetAdditionButtonDisable(int orderListIndex)
        {
            SetAdditionDataGridViewEnable(true);
            for (int i = 0; i < _drinkModel.OrderList.GetOrderAdditionListSize(orderListIndex); i++)
            {
                for (int j = 0; j < _drinkModel.GetAdditionListSize(); j++)
                {
                    if (_drinkModel.GetAdditionName(j) == _drinkModel.OrderList.GetOrderAdditionName(orderListIndex, i))
                    {
                        ((DataGridViewDisableButtonCell)_additionDataGridView.Rows[j].Cells[0]).Enabled = false;
                    }
                }
            }
            _additionDataGridView.Refresh();
        }

        //Show the development information if clicking about
        private void ClickAboutToolStripMenuItem(object sender, EventArgs e)
        {
            MessageBox.Show("開發者學號: 103820010\n開發者名稱: 商資穎\n最後更新日期: 2016/11/29\n版本編號: 5.0", "關於 EzDrink");
        }

        //Initialize and synchronize the date of datagridviews when changing the tab page
        private void ChangeTabControlSelectedIndex(object sender, EventArgs e)
        {
            if (_tabControl.SelectedTab == _orderSystemTabPage)
            {
                UpdateDrinkDataGridView(_drinkDataGridView, SELECT_BUTTON_TEXT);
                UpdateAdditionDataGridView(_additionDataGridView, SELECT_BUTTON_TEXT);
            }
            if (_tabControl.SelectedTab == _managementSystemTabPage)
            {
                UpdateDrinkDataGridView(_drinkListDataGridView, DELETE_BUTTON_TEXT);
                UpdateAdditionDataGridView(_additionListDataGridView, SELECT_BUTTON_TEXT);
                UpdateManagementButtonState();
            }
        }
    }
}