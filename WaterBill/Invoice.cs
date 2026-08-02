using System;
using System.Collections.Generic;
using System.Text;

namespace WaterBill
{
    public class Invoice
    {
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public int WaterConsumption { get; set; }
        public int ThisMonthReading { get; set; }
        public int LastMonthReading { get; set; }
        public int NumberOfPeople { get; set; }
        public double BasePrice { get; set; }
        public double EnvFee { get; set; }
        public double TotalPrice { get; set; }
        public double SubTotal { get; set; }
        public double VATFee { get; set; }

        public DateTime InvoiceDate { get; set; } = DateTime.Now;
    }
}
