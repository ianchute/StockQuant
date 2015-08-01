namespace StockQuant.Models
{
    public class BoardLot
    {
        public double TickSize { get; set; }

        public int LotSize { get; set; }

        public bool IsBoundary { get; set; }
    }
}