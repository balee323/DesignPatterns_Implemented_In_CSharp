using DesignPatterns.DecoratorPattern.StockGrabber;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DesignPatterns.StockGrabber.Tests
{
    [TestFixture]
    class AlphaVantageTests
    {

        AlphaVantageClient _client;
        

        [SetUp]
        public void Setup()
        {
            _client = new AlphaVantageClient();
        }

        [Test]
        public async Task Get_AmdStockPrice_NotNull()
        {
            var stockdata = await _client.GetLatestStockData("AMD");

            Assert.IsNotNull(stockdata);
        }

    }
}
