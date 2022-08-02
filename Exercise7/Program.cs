using System;

namespace Exercise7
{
    internal class InvoiceSlip 
    {
        private string description;
        private double price;
        private double quantity;

        public InvoiceSlip (String description, double amount, int quantity)
        {
            this.description = description;
            this.price = amount;
            this.quantity = quantity;
        }
        public string Description
        {
            get { return description; }
        }
        public double Price
        {
            get { return price; }
        }
        public int Getquantity()
        {
            return  (int)quantity;
        }

        public double calcSalesAmount()
        {
            double sales = price * quantity;

            return sales;
        }
        public double calcDiscount()
        {
            double discount = 0;
            if (quantity > 10)
            {
                discount = 0;
            }
            else if (quantity < 10 && quantity < 20)
            {
                discount = calcSalesAmount() * 0.005;
            }
             else if (quantity > 10 && quantity < 20)
            {
                discount = calcSalesAmount() * 0.010;
            }  

            return discount;
        }
    }
}
