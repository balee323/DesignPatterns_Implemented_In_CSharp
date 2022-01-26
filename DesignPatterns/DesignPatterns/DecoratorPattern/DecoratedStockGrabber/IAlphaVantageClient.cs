using DesignPatterns.DecoratorPattern.DecoratedStockGrabber.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.DecoratedStockGrabber
{
    public interface IAlphaVantageClient
    {
        Task<Tuple<TodayStockValue, StockMeta>> GetLatestStockData(string symbol);
    }
}
