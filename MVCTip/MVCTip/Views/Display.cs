using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTip.Views
{
    class Display
    {
        public double Percent { get; set; }
        public double Amount { get; set; }

        public double Total { get; set; }
        public double TipAmount { get; set; }
        public Display()
        {
            Percent = 0;
            Amount = 0;
            Total = 0;
            TipAmount = 0;
            GetValues();
        }
        private void GetValues()
        {
            Console.Write($"Enter the amount of meal: ");
            Amount = double.Parse(Console.ReadLine());
            Console.Write($"Enter the percent you want for tip: ");
            Percent = double.Parse(Console.ReadLine());
        }
        public void ShowTipAndTotal()
        {
            Console.WriteLine($"Your tip is: {TipAmount}");
            Console.WriteLine($"The total will be : {Total}");
        }
    }
}
