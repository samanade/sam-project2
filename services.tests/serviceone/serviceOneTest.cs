using Microsoft.AspNetCore.Mvc;
using serviceone.Controllers;
using Xunit;

namespace services.tests.serviceone
{
    public class serviceOneTest
    {
        [Fact]
        public void GetTest()
        {
            NumbersController numbersController = new NumbersController();
            var numbersContollerResult = numbersController.Get();

            Assert.NotNull(numbersContollerResult);
            Assert.IsType<ActionResult<string>>(numbersContollerResult);
        }
    }
}
