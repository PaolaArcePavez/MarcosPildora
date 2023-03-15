using MarcosPildora;

namespace UnitTest
{
    [TestClass]
    public class SoapStoreFinanceServiceUnitTest
    {
        private readonly SoapStoreFinanceService _soapStoreFinanceService;
        public SoapStoreFinanceServiceUnitTest()
        {
            _soapStoreFinanceService = new SoapStoreFinanceService();
        }
       
        [TestMethod]
        public void ChangeSoapProductPriceTest()
        {
            //Arrange
            var soapListA = new List<SoapItem>();
            var soapListB = new List<SoapItem>();

            var soapItemA = new SoapItem();
            soapItemA.Price = 100;
            var soapItemB = new SoapItem();
            soapItemB.Price = 50;
            var soapItemC = new SoapItem();
            soapItemC.Price = 200;

            soapListA.Add(soapItemA);
            soapListA.Add(soapItemB);
            soapListA.Add(soapItemC);

            //Act 
            var priceRisenSoapList = _soapStoreFinanceService.ChangeSoapProductPrice(soapListA, 0.5M, true);
            var priceRisenSoapListB = _soapStoreFinanceService.ChangeSoapProductPrice(soapListB, 0.5M, true);

            //Assert
            Assert.AreEqual(150, priceRisenSoapList[0].Price, 0, "Custom error message");
            Assert.AreEqual(75, priceRisenSoapList[1].Price, 0, "Custom error message");
            Assert.AreEqual(300, priceRisenSoapList[2].Price, 0, "Custom error message");
            Assert.AreEqual(priceRisenSoapListB.Count, 0, 0, "Custom error messege"); // de la lista B
        }

    }
}