using StockQuant.Config;

namespace StockQuant.WinForm.Config
{
    public class BoardLotConfig : Configurator.Config, IBoardLotConfig
    {
        public double min { get; set; }

        public double max { get; set; }

        public double tickSize { get; set; }

        public int lotSize { get; set; }
    }
}