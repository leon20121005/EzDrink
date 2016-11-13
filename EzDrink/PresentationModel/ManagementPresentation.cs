using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EzDrink
{
    public partial class ManagementPresentation
    {
        #region Constant Declaration

        const int SIZE_PER_ITEM = 2;
        const string NEW_TEXT = "新增";
        const string FILE_IMPORT_TEXT = "從檔案匯入";
        const string CONFIRM_TEXT = "確定";
        const string CANCEL_TEXT = "取消";
        const string FILE_IMPORT_ERROR_TITLE = "錯誤";
        const string FILE_IMPORT_ERROR_TEXT = "檔案類型或格式錯誤，請重新選取";
        const string DELETE_CONFIRM_TITLE = "訊息";
        const string DELETE_CONFIRM_TEXT = "確定要刪除嗎?";
        const string NEW_ITEM_ERROR_TITLE = "錯誤";
        const string NEW_ITEM_ERROR_TEXT = "名稱和價錢不可為空白，且新增不能重複";
        const string INPUT_PRICE_ERROR_TEXT = "價錢欄位必須為數字";
        const string FILTER_PARAMETER = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";

        #endregion

        //Change the button state and access to the model when clciking new drink
        public void ClickNewDrink(DrinkModel drinkModel, string drinkName, string drinkPrice)
        {
            if (_isNewDrinkTextBoxEnabled == false)
            {
                SetNewDrinkEnable(true);
            }
            else
            {
                if (drinkName != "" && drinkPrice != "" && !drinkModel.IsDrinkExist(drinkName))
                {
                    AddDrink(drinkModel, drinkName, drinkPrice);
                }
                else
                {
                    MessageBox.Show(NEW_ITEM_ERROR_TEXT, NEW_ITEM_ERROR_TITLE);
                }
            }
        }

        //Change the button state and access to the model when clciking new addition
        public void ClickNewAddition(DrinkModel drinkModel, string additionName, string additionPrice)
        {
            if (_isNewAdditionTextBoxEnabled == false)
            {
                SetNewAdditionEnable(true);
            }
            else
            {
                if (additionName != "" && additionPrice != "" && !drinkModel.IsAdditionExist(additionName))
                {
                    AddAddition(drinkModel, additionName, additionPrice);
                }
                else
                {
                    MessageBox.Show(NEW_ITEM_ERROR_TEXT, NEW_ITEM_ERROR_TITLE);
                }
            }
        }

        //Change the button state and access to the model when clciking file import drink
        public void ClickFileImportDrink(DrinkModel drinkModel)
        {
            if (_isNewDrinkTextBoxEnabled == false)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = FILTER_PARAMETER;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                  
                    StreamReader drinkFile = new StreamReader(openFileDialog.FileName, Encoding.Default);
                    ImportFileIntoDrink(drinkFile, drinkModel);
                    drinkFile.Close();
                }
            }
            else
            {
                SetNewDrinkEnable(false);
            }
        }

        //Change the button state and access to the model when clciking file import addition
        public void ClickFileImportAddition(DrinkModel drinkModel)
        {
            if (_isNewAdditionTextBoxEnabled == false)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = FILTER_PARAMETER;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader drinkFile = new StreamReader(openFileDialog.FileName, Encoding.Default);
                    ImportFileIntoAddition(drinkFile, drinkModel);
                    drinkFile.Close();
                }
            }
            else
            {
                SetNewAdditionEnable(false);
            }
        }

        //Change the button state and access to the model when clciking drink list datagridview
        public void ClickDrinkListDataGridView(DrinkModel drinkModel, int drinkListRowIndex)
        {
            DialogResult confirmDialog;
            confirmDialog = MessageBox.Show(DELETE_CONFIRM_TEXT, DELETE_CONFIRM_TITLE, MessageBoxButtons.YesNo);
            if (confirmDialog == DialogResult.Yes)
            {
                drinkModel.DeleteDrink(drinkListRowIndex);
            }
        }

        //Change the button state and access to the model when clciking addition list datagridview
        public void ClickAdditionListDataGridView(DrinkModel drinkModel, int additionListRowIndex)
        {
            DialogResult confirmDialog;
            confirmDialog = MessageBox.Show(DELETE_CONFIRM_TEXT, DELETE_CONFIRM_TITLE, MessageBoxButtons.YesNo);
            if (confirmDialog == DialogResult.Yes)
            {
                drinkModel.DeleteAddition(additionListRowIndex);
            }
        }

        //Return the enabled state of the drink name/price text box
        public bool IsNewDrinkTextBoxEnabled()
        {
            return _isNewDrinkTextBoxEnabled;
        }

        //Return the enabled state of the addition name/price text box
        public bool IsNewAdditionTextBoxEnabled()
        {
            return _isNewAdditionTextBoxEnabled;
        }

        //Return the text of the new drink button
        public string GetNewDrinkText()
        {
            return _newDrinkText;
        }

        //Return the text of the file import drink button
        public string GetFileImportDrinkText()
        {
            return _fileImportDrinkText;
        }

        //Return the text of the new addition button
        public string GetNewAdditionText()
        {
            return _newAdditionText;
        }

        //Return the text of the file import addition button
        public string GetFileImportAdditionText()
        {
            return _fileImportAdditionText;
        }

        private bool _isNewDrinkTextBoxEnabled = false;
        private bool _isNewAdditionTextBoxEnabled = false;
        private string _newDrinkText = NEW_TEXT;
        private string _fileImportDrinkText = FILE_IMPORT_TEXT;
        private string _newAdditionText = NEW_TEXT;
        private string _fileImportAdditionText = FILE_IMPORT_TEXT;
    }
}