using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockQuant.Config;

namespace StockQuant.WinForm.Config
{
    public class FeesConfig : Configurator.Config, IFeesConfig
    {
        public double commission { get; set; }

        public double commission_min { get; set; }

        public double vat_on_commission { get; set; }

        public double pse_fee { get; set; }

        public double sccp_fee { get; set; }

        public double sales_tax { get; set; }
    }
}