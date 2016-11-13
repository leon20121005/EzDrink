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
        const char SPACE_CHARACTER = ' ';
        const char ENTER_CHARACTER = '\n';

        //Set the enable state of the new drink
        private void SetNewDrinkEnable(bool enabled)
        {
            _isNewDrinkTextBoxEnabled = enabled;
            if (enabled)
            {
                _newDrinkText = CONFIRM_TEXT;
                _fileImportDrinkText = CANCEL_TEXT;
            }
            else
            {
                _newDrinkText = NEW_TEXT;
                _fileImportDrinkText = FILE_IMPORT_TEXT;
            }
        }

        //Set the enable state of the new addition
        private void SetNewAdditionEnable(bool enabled)
        {
            _isNewAdditionTextBoxEnabled = enabled;
            if (enabled)
            {
                _newAdditionText = CONFIRM_TEXT;
                _fileImportAdditionText = CANCEL_TEXT;
            }
            else
            {
                _newDrinkText = NEW_TEXT;
                _fileImportDrinkText = FILE_IMPORT_TEXT;
            }
        }

        //Add the new drink into the drink list
        private void AddDrink(DrinkModel drinkModel, string drinkName, string drinkPrice)
        {
            try
            {
                drinkModel.AddDrink(drinkName, int.Parse(drinkPrice));
            }
            catch
            {
                MessageBox.Show(INPUT_PRICE_ERROR_TEXT, NEW_ITEM_ERROR_TITLE);
                return;
            }
            SetNewDrinkEnable(false);
        }

        //Add the new addiiton into the addition list
        private void AddAddition(DrinkModel drinkModel, string additionName, string additionPrice)
        {
            try
            {
                drinkModel.AddAddition(additionName, int.Parse(additionPrice));
            }
            catch
            {
                MessageBox.Show(INPUT_PRICE_ERROR_TEXT, NEW_ITEM_ERROR_TITLE);
                return;
            }
            SetNewAdditionEnable(false);
        }

        //Read the text in the file and add into the drink list
        private void ImportFileIntoDrink(StreamReader drinkFile, DrinkModel drinkModel)
        {
            string lines = drinkFile.ReadToEnd();
            string[] words = lines.Split(SPACE_CHARACTER, ENTER_CHARACTER);
            for (int index = 0; index < words.Length; index += SIZE_PER_ITEM)
            {
                try
                {
                    drinkModel.AddDrink(words[index], int.Parse(words[index + 1]));
                }
                catch
                {
                    MessageBox.Show(FILE_IMPORT_ERROR_TEXT, FILE_IMPORT_ERROR_TITLE);
                    ClickFileImportDrink(drinkModel);
                    break;
                }
            }
        }

        //Read the text in the file and add into the addition list
        private void ImportFileIntoAddition(StreamReader drinkFile, DrinkModel drinkModel)
        {
            string lines = drinkFile.ReadToEnd();
            string[] words = lines.Split(SPACE_CHARACTER, ENTER_CHARACTER);
            for (int index = 0; index < words.Length; index += SIZE_PER_ITEM)
            {
                try
                {
                    drinkModel.AddAddition(words[index], int.Parse(words[index + 1]));
                }
                catch
                {
                    MessageBox.Show(FILE_IMPORT_ERROR_TEXT, FILE_IMPORT_ERROR_TITLE);
                    ClickFileImportAddition(drinkModel);
                    break;
                }
            }
        }
    }
}