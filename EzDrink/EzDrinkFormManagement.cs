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
                UpdateDrinkListDataGridView();
            }
        }

        //Delete the addition in the addition list if clicking the delete button (e.ColumnIndex = 0)
        private void ClickAdditionListDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                _managementPresentation.ClickAdditionListDataGridView(_drinkModel, e.RowIndex);
                UpdateAdditionListDataGridView();
            }
        }

        //Start adding new drink manually or confirm adding new drink if clicking the button
        private void ClickNewDrinkButton(object sender, EventArgs e)
        {
            _managementPresentation.ClickNewDrink(_drinkModel, _drinkNameTextBox.Text, _drinkPriceTextBox.Text);
            UpdateManagementButtonState();
            UpdateDrinkListDataGridView();
        }

        //Import file into drink list or cancel adding new drink manually if clicking the button
        private void ClickFileImportDrinkButton(object sender, EventArgs e)
        {
            _managementPresentation.ClickFileImportDrink(_drinkModel);
            UpdateManagementButtonState();
            UpdateDrinkListDataGridView();
        }

        //Start adding new addition manually or confirm adding new addition if clicking the button
        private void ClickNewAdditionButton(object sender, EventArgs e)
        {
            _managementPresentation.ClickNewAddition(_drinkModel, _additionNameTextBox.Text, _additionPriceTextBox.Text);
            UpdateManagementButtonState();
            UpdateAdditionListDataGridView();
        }

        //Import file into addition list or cancel adding new addition manually if clicking the button
        private void ClickFileImportAdditionButton(object sender, EventArgs e)
        {
            _managementPresentation.ClickFileImportAddition(_drinkModel);
            UpdateManagementButtonState();
            UpdateAdditionListDataGridView();
        }

        //Update the data of category datagridview from the drink list
        private void UpdateCategoryDataGridView()
        {
            _categoryDataGridView.Rows.Clear();
            for (int index = 0; index < _drinkModel.GetDrinkListSize(); index++)
            {
                _categoryDataGridView.Rows.Add(SELECT_BUTTON_TEXT, _drinkModel.GetDrinkName(index), _drinkModel.GetDrinkPrice(index));
            }
        }

        //Update the data of addition datagridview from the addition list
        private void UpdateAdditionDataGridView()
        {
            _additionDataGridView.Rows.Clear();
            for (int index = 0; index < _drinkModel.GetAdditionListSize(); index++)
            {
                _additionDataGridView.Rows.Add(SELECT_BUTTON_TEXT, _drinkModel.GetAdditionName(index), _drinkModel.GetAdditionPrice(index));
            }
        }

        //Update the data of drink list datagridview from the drink list
        private void UpdateDrinkListDataGridView()
        {
            _drinkListDataGridView.Rows.Clear();
            for (int index = 0; index < _drinkModel.GetDrinkListSize(); index++)
            {
                _drinkListDataGridView.Rows.Add(DELETE_BUTTON_TEXT, _drinkModel.GetDrinkName(index), _drinkModel.GetDrinkPrice(index));
            }
        }

        //Update the data of addition list datagridview from the addition list
        private void UpdateAdditionListDataGridView()
        {
            _additionListDataGridView.Rows.Clear();
            for (int index = 0; index < _drinkModel.GetAdditionListSize(); index++)
            {
                _additionListDataGridView.Rows.Add(DELETE_BUTTON_TEXT, _drinkModel.GetAdditionName(index), _drinkModel.GetAdditionPrice(index));
            }
        }

        //Update the state of the management system buttons
        private void UpdateManagementButtonState()
        {
            _drinkNameTextBox.Enabled = _managementPresentation.IsDrinkNamePriceEnabled();
            _drinkPriceTextBox.Enabled = _managementPresentation.IsDrinkNamePriceEnabled();
            _additionNameTextBox.Enabled = _managementPresentation.IsAdditionNamePriceEnabled();
            _additionPriceTextBox.Enabled = _managementPresentation.IsAdditionNamePriceEnabled();
            _newDrinkButton.Text = _managementPresentation.GetNewDrinkText();
            _fileImportDrinkButton.Text = _managementPresentation.GetFileImportDrinkText();
            _newAdditionButton.Text = _managementPresentation.GetNewAdditionText();
            _fileImportAdditionButton.Text = _managementPresentation.GetFileImportAdditionText();
        }

        //Update the name or the price of the drink after editing the cell content
        private void EndEditDrinkListDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            _drinkModel.UpdateDrink(e.RowIndex, _drinkListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), int.Parse(_drinkListDataGridView.Rows[e.RowIndex].Cells[PRICE_COLUMN].Value.ToString()));
            UpdateDrinkListDataGridView();
        }

        //Update the name or the price of the addition after editing the cell content
        private void EndEditAdditionListDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            _drinkModel.UpdateAddition(e.RowIndex, _additionListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), int.Parse(_additionListDataGridView.Rows[e.RowIndex].Cells[PRICE_COLUMN].Value.ToString()));
            UpdateAdditionListDataGridView();
        }
    }
}