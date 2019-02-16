using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculatorApp.Models
{
    public class Tip
    {

        public string Restaurant { get; set; }
        public decimal BillAmount { get; set; }
        public decimal TipPercent { get; set; }
        public DateTime TimeOfBill { get; set; }
        public string TipDate
        {
            get
            {
                return TimeOfBill.ToString("dd-MM-yyyy");
            }
        }
        public string TipTime
        {
            get
            {
                return TimeOfBill.ToString("HH:mm:ss");
            }
        }
        public string TipAmount
        {
            get
            {
                return BillAmount * TipPercent / 100 + " Euro";
            }
        }

        public Tip()
        {
            TimeOfBill = DateTime.Now;
        }

    }
}
