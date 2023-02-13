using MVCTip.Models;
using MVCTip.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTip.Controllers
{
    class TipCalculatorController
    {
        private Tip tip;
        private Display display;
        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.Amount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();  

        }
    }
}
