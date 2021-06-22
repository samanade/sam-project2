using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Threading.Tasks;

namespace servicethree.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        private AppSettings Configuration;
        public MergeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var numbersService = $"{Configuration.numbersServiceURL}/numbers";
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(numbersService);
            var lettersService = $"{Configuration.lettersServiceURL}/letters";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(lettersService);
            var mergedResponse = $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
