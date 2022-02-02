using DesignPatterns.DecoratorPattern.MultiDecoratedStockGrabber;
using Microsoft.Extensions.Caching.Memory;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DesignPatterns.StockGrabber.MultiDecorator.Tests
{
    [TestFixture]
    class AlphaVantageMultiDecoratorTests
    {

        IAlphaVantageClient _clientWithCache;

        [SetUp]
        public void Setup()
        {

            IMemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());

            //build it like an onion
            IAlphaVantageClient client = new AlphaVantageClient();
            IAlphaVantageClient clientWithLogger = new AlphaVantageLoggingDecorator(client);
            _clientWithCache = new AlphaVantageCachingDecorator(clientWithLogger, memoryCache);
        }

        [Test]
        public async Task Get_AmdStockPrice_NotNull()
        {
            //call 1, not in cache
            var stockdata = await _clientWithCache.GetLatestStockData("AMD");

            await Task.Delay(1000);

            //call 2, will be in cache
            stockdata = await _clientWithCache.GetLatestStockData("AMD");

            Assert.IsNotNull(stockdata);
        }

    }
}
