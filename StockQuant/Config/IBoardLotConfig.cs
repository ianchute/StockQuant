namespace StockQuant.Config
{
    public interface IBoardLotConfig
    {
        double min { get; set; }

        double max { get; set; }

        double tickSize { get; set; }

        int lotSize { get; set; }
    }
}