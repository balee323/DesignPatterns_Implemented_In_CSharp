using DesignPatterns.DecoratorPattern.DecoratedStockGrabber;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DesignPatterns.StockGrabber.Decorator.Tests
{
    [TestFixture]
    class AlphaVantageDecoratorTests
    {

        IAlphaVantageClient _clientWithLogger;

        [SetUp]
        public void Setup()
        {
            _clientWithLogger = new AlphaVantageLoggingDecorator(new AlphaVantageClient());
        }

        [Test]
        public async Task Get_AmdStockPrice_NotNull()
        {
            var stockdata = await _clientWithLogger.GetLatestStockData("AMD");

            Assert.IsNotNull(stockdata);
        }

    }
}
