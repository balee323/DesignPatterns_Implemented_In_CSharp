using DesignPatterns.DecoratorPattern.MultiDecoratedStockGrabber.Models;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.MultiDecoratedStockGrabber
{
    public class AlphaVantageCachingDecorator : IAlphaVantageClient
    {

        private IAlphaVantageClient _innerAlphaVantageClient;
        private IMemoryCache _memoryCache;


        public AlphaVantageCachingDecorator(IAlphaVantageClient alphaVantageClient, IMemoryCache memoryCache)
        {
            _innerAlphaVantageClient = alphaVantageClient;
            _memoryCache = memoryCache;
        }

        public async Task<Tuple<TodayStockValue, StockMeta>> GetLatestStockData(string symbol)
        {
            Tuple<TodayStockValue, StockMeta> cacheResults = null;
            Tuple<TodayStockValue, StockMeta> results = null;


            string cacheKey = $"Stock symbol {symbol}";

            try
            {
              
                if(_memoryCache.TryGetValue<Tuple<TodayStockValue, StockMeta>>(cacheKey, out cacheResults))
                {
                    results = cacheResults;
                }
                else
                {
                    results = await _innerAlphaVantageClient.GetLatestStockData(symbol);

                    //cache the value
                    _memoryCache.Set<Tuple<TodayStockValue, StockMeta>>(cacheKey, results, TimeSpan.FromSeconds(60));
                }                
             
            }
            catch(Exception ex)
            {

            }


            return results;
        }
    }
}
