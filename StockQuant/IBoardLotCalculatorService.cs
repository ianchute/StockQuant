using StockQuant.Models;

namespace StockQuant
{
    public interface IBoardLotCalculatorService
    {
        BoardLot GetMinimumBoardLot(double price);
    }
}