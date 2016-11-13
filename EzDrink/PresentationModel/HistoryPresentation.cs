using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    public class HistoryPresentation
    {
        //Update the text of the history total price label from drink model
        public string UpdateHistoryTotalPriceLabel(DrinkModel drinkModel)
        {
            int historyOrderListTotalPrice = 0;
            const string TOTAL_PRICE_TEXT = "總價 : ";           
            foreach (OrderList orderList in drinkModel.HistoryOrderList)
            {
                historyOrderListTotalPrice += orderList.GetOrderListTotalPrice();
            }
            return TOTAL_PRICE_TEXT + historyOrderListTotalPrice.ToString();
        }
    }
}