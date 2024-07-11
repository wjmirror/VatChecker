namespace VatChecker.Tests
{
    [TestClass]
    public class CheckVatNumberTest
    {
        [TestMethod]
        public async Task Test_Valid_VatNumber()
        {
            // Arrange
            var vatChecker = new VatCheckerApiClient(new HttpClient());
            vatChecker.BaseUrl = "https://ec.europa.eu/taxation_customs/vies/rest-api/";
            var checkReqest = new CheckVatRequest()
            {
                CountryCode = "IE",
                VatNumber = "6321274H"
            };

            // Act
            var result = await vatChecker.CheckVatNumberAsync(checkReqest);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Valid);

        }
    }
}