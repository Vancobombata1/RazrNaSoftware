using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTip.Models
{
    class Tip
    {
        private double percent;
        public double Amount { get; set; }

        public double  Percent
        {
            get { return this.percent; }
            set
            {
                if (value>1)
                {
                    this.percent = value / 100.0;
                } 
                this.percent = value; }
        }
        public Tip(double amount,double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }
        public Tip() : this(0, 0) { }
        public double CalculateTip()
        {
            return Amount * Percent;
        }
    public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }
    }
}
