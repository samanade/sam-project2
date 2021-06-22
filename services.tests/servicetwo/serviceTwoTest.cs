using Microsoft.AspNetCore.Mvc;
using serviceone.Controllers;
using Xunit;

namespace services.tests.serviceone
{
    public class serviceTwoTest
    {
        [Fact]
        public void GetTest()
        {
            LettersController lettersController = new LettersController();
            var lettersControllerResult = lettersController.Get();

            Assert.NotNull(lettersControllerResult);
            Assert.IsType<ActionResult<string>>(lettersControllerResult);
        }
    }
}
