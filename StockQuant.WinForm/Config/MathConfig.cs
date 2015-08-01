using StockQuant.Config;

namespace StockQuant.WinForm.Config
{
    public class MathConfig : Configurator.Config, IMathConfig
    {
        public double breakeven_interval { get; set; }
    }
}