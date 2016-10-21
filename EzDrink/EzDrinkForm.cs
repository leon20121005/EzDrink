using System;
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
        PresentationModel _presentationModel = new PresentationModel();

        const int SIZE_OF_DRINKS = 5;
        const int SIZE_OF_ADDITIONS = 4;
        const int SUGAR_COLUMN = 2;
        const int TEMPERATURE_COLUMN = 3;
        const int ADDITION_COLUMN = 4;
        const string SELECT_BUTTON_TEXT = "選擇";

        public EzDrinkForm()
        {
            InitializeComponent();
            _drinkModel.InitializeList();

            for (int index = 0; index < SIZE_OF_DRINKS; index++)
            {
                _categoryDataGridView.Rows.Add(SELECT_BUTTON_TEXT, _drinkModel.GetDrinkName(index), _drinkModel.GetDrinkPrice(index));
            }
            for (int index = 0; index < SIZE_OF_ADDITIONS; index++)
            {
                _additionDataGridView.Rows.Add(SELECT_BUTTON_TEXT, _drinkModel.GetAdditionName(index), _drinkModel.GetAdditionPrice(index));
            }
            UpdateButtonState();
            SetAdditionDataGridViewEnable(_presentationModel.IsAdditionDataGridViewEnabled());
        }

        //Close the application if pressing the exit
        private void ClickExitToolStripMenuItem(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Add the drinks into the order list if pressing the button (e.ColumnIndex = 0)
        private void ClickCategoryDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                _drinkModel.AddDrink(e.RowIndex);
                _orderDataGridView.Rows.Add(_drinkModel.GetDrinkName(e.RowIndex), _drinkModel.GetDrinkPrice(e.RowIndex));
                _totalPriceLabel.Text = _presentationModel.GetTotalPriceLabelText(_drinkModel);
                _presentationModel.ClickCategoryDataGridView();
                UpdateButtonState();
                SetAdditionButtonDisable(_orderDataGridView.CurrentRow.Index);
            }
        }

        //Add the drink additions into the order list if pressing the button (e.ColumnIndex = 0)
        private void ClickAdditionDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && _drinkModel.GetOrderListSize() != 0 && ((DataGridViewDisableButtonCell)_additionDataGridView.Rows[e.RowIndex].Cells[0]).Enabled != false)
            {
                _drinkModel.AddAddition(_additionDataGridView.CurrentRow.Index, _orderDataGridView.CurrentRow.Index);
                _orderDataGridView.CurrentRow.Cells[1].Value = _drinkModel.GetOrderTotalPrice(_orderDataGridView.CurrentRow.Index).ToString();
                _orderDataGridView.CurrentRow.Cells[ADDITION_COLUMN].Value += _additionDataGridView.CurrentRow.Cells[1].Value.ToString();
                _totalPriceLabel.Text = _presentationModel.GetTotalPriceLabelText(_drinkModel);
                SetAdditionButtonDisable(_orderDataGridView.CurrentRow.Index);
            }
        }

        //Delete the order in the order list if pressing the button (e.ColumnIndex = 5)
        private void ClickOrderDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                _drinkModel.DeleteOrder(e.RowIndex);
                _orderDataGridView.Rows.RemoveAt(e.RowIndex);
                _totalPriceLabel.Text = _presentationModel.GetTotalPriceLabelText(_drinkModel);
                _presentationModel.ClickOrderDataGridView(_drinkModel);
                _presentationModel.UpdatePayState(_drinkModel);
                UpdateButtonState();
                SetAdditionDataGridViewEnable(_presentationModel.IsAdditionDataGridViewEnabled());
            }
            if (_drinkModel.GetOrderListSize() != 0)
            {
                SetAdditionButtonDisable(_orderDataGridView.CurrentRow.Index);
            }
        }

        //Ensure that addition datagridview will refresh when user clicks every time 
        private void ClickOrderDataGridView(object sender, EventArgs e)
        {
            if (_drinkModel.GetOrderListSize() != 0)
            {
                SetAdditionButtonDisable(_orderDataGridView.CurrentRow.Index);
            }
        }

        //Set the sweetness to normal sugar
        private void ClickNormalSugarButton(object sender, EventArgs e)
        {
            _drinkModel.SetSugar(_orderDataGridView.CurrentRow.Index, Sugar.NormalSugar);
            _orderDataGridView.CurrentRow.Cells[SUGAR_COLUMN].Value = _drinkModel.ConvertSugarToString(Sugar.NormalSugar);
            _presentationModel.UpdatePayState(_drinkModel);
            UpdateButtonState();
        }

        //Set the sweetness to half sugar
        private void ClickHalfSugarButton(object sender, EventArgs e)
        {
            _drinkModel.SetSugar(_orderDataGridView.CurrentRow.Index, Sugar.HalfSugar);
            _orderDataGridView.CurrentRow.Cells[SUGAR_COLUMN].Value = _drinkModel.ConvertSugarToString(Sugar.HalfSugar);
            _presentationModel.UpdatePayState(_drinkModel);
            UpdateButtonState();
        }

        //Set the sweetness to less sugar
        private void ClickLessSugarButton(object sender, EventArgs e)
        {
            _drinkModel.SetSugar(_orderDataGridView.CurrentRow.Index, Sugar.LessSugar);
            _orderDataGridView.CurrentRow.Cells[SUGAR_COLUMN].Value = _drinkModel.ConvertSugarToString(Sugar.LessSugar);
            _presentationModel.UpdatePayState(_drinkModel);
            UpdateButtonState();
        }

        //Set the sweetness to no sugar
        private void ClickNoSugarButton(object sender, EventArgs e)
        {
            _drinkModel.SetSugar(_orderDataGridView.CurrentRow.Index, Sugar.NoSugar);
            _orderDataGridView.CurrentRow.Cells[SUGAR_COLUMN].Value = _drinkModel.ConvertSugarToString(Sugar.NoSugar);
            _presentationModel.UpdatePayState(_drinkModel);
            UpdateButtonState();
        }

        //Set the ice level to normal ice
        private void ClickNormalIceButton(object sender, EventArgs e)
        {
            _drinkModel.SetTemperature(_orderDataGridView.CurrentRow.Index, Temperature.NormalIce);
            _orderDataGridView.CurrentRow.Cells[TEMPERATURE_COLUMN].Value = _drinkModel.ConvertTemperatureToString(Temperature.NormalIce);
            _presentationModel.UpdatePayState(_drinkModel);
            UpdateButtonState();
        }

        //Set the ice level to less ice
        private void ClickLessIceButton(object sender, EventArgs e)
        {
            _drinkModel.SetTemperature(_orderDataGridView.CurrentRow.Index, Temperature.LessIce);
            _orderDataGridView.CurrentRow.Cells[TEMPERATURE_COLUMN].Value = _drinkModel.ConvertTemperatureToString(Temperature.LessIce);
            _presentationModel.UpdatePayState(_drinkModel);
            UpdateButtonState();
        }

        //Set the ice level to no ice
        private void ClickNoIceButton(object sender, EventArgs e)
        {
            _drinkModel.SetTemperature(_orderDataGridView.CurrentRow.Index, Temperature.NoIce);
            _orderDataGridView.CurrentRow.Cells[TEMPERATURE_COLUMN].Value = _drinkModel.ConvertTemperatureToString(Temperature.NoIce);
            _presentationModel.UpdatePayState(_drinkModel);
            UpdateButtonState();
        }

        //Set the ice level to hot
        private void ClickHotButton(object sender, EventArgs e)
        {
            _drinkModel.SetTemperature(_orderDataGridView.CurrentRow.Index, Temperature.Hot);
            _orderDataGridView.CurrentRow.Cells[TEMPERATURE_COLUMN].Value = _drinkModel.ConvertTemperatureToString(Temperature.Hot);
            _presentationModel.UpdatePayState(_drinkModel);
            UpdateButtonState();
        }

        //Store the current order list and clear the datagridview
        private void ClickPayButton(object sender, EventArgs e)
        {
            _drinkModel.StoreOrderList();
            _orderDataGridView.Rows.Clear();
            _totalPriceLabel.Text = _presentationModel.GetTotalPriceLabelText(_drinkModel);
            _presentationModel.ClickPay();
            UpdateButtonState();
            SetAdditionDataGridViewEnable(_presentationModel.IsAdditionDataGridViewEnabled());
        }

        //Update the state of the buttons
        private void UpdateButtonState()
        {
            _normalSugarButton.Enabled = _presentationModel.IsNormalSugarEnabled();
            _halfSugarButton.Enabled = _presentationModel.IsHalfSugarEnabled();
            _lessSugarButton.Enabled = _presentationModel.IsLessSugarEnabled();
            _noSugarButton.Enabled = _presentationModel.IsNoSugarEnabled();
            _normalIceButton.Enabled = _presentationModel.IsNormalIceEnabled();
            _lessIceButton.Enabled = _presentationModel.IsLessIceEnabled();
            _noIceButton.Enabled = _presentationModel.IsNoIceEnabled();
            _hotButton.Enabled = _presentationModel.IsHotEnabled();
            _payButton.Enabled = _presentationModel.IsPayEnabled();
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
            if (_drinkModel.GetOrderListSize() != 0)
            {
                for (int i = 0; i < _drinkModel.GetOrderAdditionListSize(orderListIndex); i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (_drinkModel.GetAdditionName(j) == _drinkModel.GetOrderAdditionName(orderListIndex, i))
                        {
                            ((DataGridViewDisableButtonCell)_additionDataGridView.Rows[j].Cells[0]).Enabled = false;
                        }
                    }
                }
            }
            _additionDataGridView.Refresh();
        }

        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("開發者學號: 103820010\n開發者名稱: 商資穎\n最後更新日期: 2016/10/16\n版本編號: 1.0", "About");
        }
    }
}