using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using servicethree;
using servicethree.Controllers;
using Xunit;

namespace services.tests.serviceone
{
    public class serviceThreeTest
    {

        private AppSettings appSettings = new AppSettings()
        {
            numbersServiceURL = "https://gwl-numbers.azurewebsites.net",
            lettersServiceURL = "https://gwl-letters.azurewebsites.net"
        };
        [Fact]
        public async void GetTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeContollerResult = await mergeController.Get();

            Assert.NotNull(mergeContollerResult);
            Assert.IsType<OkObjectResult>(mergeContollerResult);
        }
    }
}
