namespace StockQuant.Models
{
    public abstract class StockAction
    {
        public double Price { get; set; }

        public int Volume { get; set; }
    }
}