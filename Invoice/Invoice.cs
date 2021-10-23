using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invoice
{
    public class Invoice
    {
        #region Fields
        private string partDescription;
        private string partNumber;
        private decimal pricePerItem;
        private int quantity;
        #endregion

        #region Constructors
        public Invoice(string descr, string number, decimal price, int quan)
        {
            partDescription = descr;
            partNumber = number;
            pricePerItem = price;
            quantity = quan;
        }

        
        #endregion

        #region Properties
        public string PartDescrition { get { return partDescription; } set { partDescription = value; } }
        public string PartNumber { get { return partNumber; } set { partNumber = value; } }
        public decimal PricePerItem { get { return pricePerItem; } set { pricePerItem = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        #endregion

        #region Metods
        public decimal GetInvoiceAmount()
        {
            if (pricePerItem > 0 && quantity > 0)
            {
                decimal amount = pricePerItem * quantity;
                return amount;
            }
            else { return 0; }
        }

        #endregion
    }
}