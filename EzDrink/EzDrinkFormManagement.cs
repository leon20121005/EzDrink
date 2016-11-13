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
    public partial class EzDrinkForm
    {
        //Delete the drink in the drink list if clicking the delete button (e.ColumnIndex = 0)
        private void ClickDrinkListDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                _managementPresentation.ClickDrinkListDataGridView(_drinkModel, e.RowIndex);
                UpdateDrinkDataGridView(_drinkListDataGridView, DELETE_BUTTON_TEXT);
            }
        }

        //Delete the addition in the addition list if clicking the delete button (e.ColumnIndex = 0)
        private void ClickAdditionListDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                _managementPresentation.ClickAdditionListDataGridView(_drinkModel, e.RowIndex);
                UpdateAdditionDataGridView(_additionListDataGridView, DELETE_BUTTON_TEXT);
            }
        }

        //Start adding new drink manually or confirm adding new drink if clicking the button
        private void ClickNewDrinkButton(object sender, EventArgs e)
        {
            _managementPresentation.ClickNewDrink(_drinkModel, _drinkNameTextBox.Text, _drinkPriceTextBox.Text);
            UpdateDrinkDataGridView(_drinkListDataGridView, DELETE_BUTTON_TEXT);
            UpdateManagementButtonState();
        }

        //Import file into drink list or cancel adding new drink manually if clicking the button
        private void ClickFileImportDrinkButton(object sender, EventArgs e)
        {
            _managementPresentation.ClickFileImportDrink(_drinkModel);
            UpdateDrinkDataGridView(_drinkListDataGridView, DELETE_BUTTON_TEXT);
            UpdateManagementButtonState();
        }

        //Start adding new addition manually or confirm adding new addition if clicking the button
        private void ClickNewAdditionButton(object sender, EventArgs e)
        {
            _managementPresentation.ClickNewAddition(_drinkModel, _additionNameTextBox.Text, _additionPriceTextBox.Text);
            UpdateAdditionDataGridView(_additionListDataGridView, DELETE_BUTTON_TEXT);
            UpdateManagementButtonState();
        }

        //Import file into addition list or cancel adding new addition manually if clicking the button
        private void ClickFileImportAdditionButton(object sender, EventArgs e)
        {
            _managementPresentation.ClickFileImportAddition(_drinkModel);
            UpdateAdditionDataGridView(_additionListDataGridView, DELETE_BUTTON_TEXT);
            UpdateManagementButtonState();
        }

        //Update the name or the price of the drink after editing the cell content
        private void EndEditDrinkListDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            _drinkModel.UpdateDrink(e.RowIndex, _drinkListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), int.Parse(_drinkListDataGridView.Rows[e.RowIndex].Cells[PRICE_COLUMN].Value.ToString()));
            UpdateDrinkDataGridView(_drinkListDataGridView, DELETE_BUTTON_TEXT);
        }

        //Update the name or the price of the addition after editing the cell content
        private void EndEditAdditionListDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            _drinkModel.UpdateAddition(e.RowIndex, _additionListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), int.Parse(_additionListDataGridView.Rows[e.RowIndex].Cells[PRICE_COLUMN].Value.ToString()));
            UpdateAdditionDataGridView(_additionListDataGridView, DELETE_BUTTON_TEXT);
        }

        //Synchronize the data of drink or drink list datagridview from the drink list
        private void UpdateDrinkDataGridView(DataGridView dataGridView, string buttonText)
        {
            dataGridView.Rows.Clear();
            for (int index = 0; index < _drinkModel.GetDrinkListSize(); index++)
            {
                dataGridView.Rows.Add(buttonText, _drinkModel.GetDrinkName(index), _drinkModel.GetDrinkPrice(index));
            }
        }

        //Synchronize the data of addition or addition list datagridview from the addition list
        private void UpdateAdditionDataGridView(DataGridView dataGridView, string buttonText)
        {
            dataGridView.Rows.Clear();
            for (int index = 0; index < _drinkModel.GetAdditionListSize(); index++)
            {
                dataGridView.Rows.Add(buttonText, _drinkModel.GetAdditionName(index), _drinkModel.GetAdditionPrice(index));
            }
        }

        //Update the state of the management system buttons
        private void UpdateManagementButtonState()
        {
            _newDrinkButton.Text = _managementPresentation.GetNewDrinkText();
            _fileImportDrinkButton.Text = _managementPresentation.GetFileImportDrinkText();
            _newAdditionButton.Text = _managementPresentation.GetNewAdditionText();
            _fileImportAdditionButton.Text = _managementPresentation.GetFileImportAdditionText();
            _drinkNameTextBox.Enabled = _managementPresentation.IsNewDrinkTextBoxEnabled();
            _drinkPriceTextBox.Enabled = _managementPresentation.IsNewDrinkTextBoxEnabled();
            _additionNameTextBox.Enabled = _managementPresentation.IsNewAdditionTextBoxEnabled();
            _additionPriceTextBox.Enabled = _managementPresentation.IsNewAdditionTextBoxEnabled();
            ClearManagementTextBox();
        }

        //Clear the text in the management system text boxes
        private void ClearManagementTextBox()
        {
            _drinkNameTextBox.Clear();
            _drinkPriceTextBox.Clear();
            _additionNameTextBox.Clear();
            _additionPriceTextBox.Clear();
        }

        //Load the history order list data into the detail datagridview
        private void ChangeHistoryDataGridViewCurrentCell(object sender, EventArgs e)
        {
            _detailDataGridView.Rows.Clear();
            OrderList orderList = _drinkModel.HistoryOrderList[_historyDataGridView.CurrentCell.RowIndex];
            for (int index = 0; index < orderList.GetOrderListSize(); index++)
            {
                _detailDataGridView.Rows.Add(orderList.GetOrderName(index), orderList.GetOrderTotalPrice(index), _drinkModel.ConvertSugarToString(orderList.GetOrderSugar(index)), _drinkModel.ConvertTemperatureToString(orderList.GetOrderTemperature(index)));
                _detailDataGridView.Rows[index].Cells[4].Value = _orderPresentation.GetAdditionItems(orderList, index);
            }
        }
    }
}