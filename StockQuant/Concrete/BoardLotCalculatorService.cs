using System.Collections.Generic;
using System.Linq;
using StockQuant.Config;
using StockQuant.Models;

namespace StockQuant.Concrete
{
    public class BoardLotCalculatorService : IBoardLotCalculatorService
    {
        private readonly IBoardLotConfig[] config;

        public BoardLotCalculatorService(IBoardLotConfig[] config)
        {
            this.config = config;
        }

        public BoardLot GetMinimumBoardLot(double price)
        {
            IEnumerable<IBoardLotConfig> boardLots = config
                .Where(_ => _.max >= (price - _.tickSize) 
                    && _.min <= (price + _.tickSize))
                .OrderBy(_ => _.lotSize);
            IBoardLotConfig boardLot = boardLots.First();
                
            BoardLot result = new BoardLot()
            {
                LotSize = boardLot.lotSize,
                TickSize = boardLot.tickSize,
                IsBoundary = boardLots.Count() > 1
            };
            return result;
        }
    }
}