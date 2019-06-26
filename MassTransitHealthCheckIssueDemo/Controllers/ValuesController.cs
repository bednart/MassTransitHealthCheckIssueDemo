using Microsoft.AspNetCore.Mvc;

namespace MassTransitHealthCheckIssueDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello world!";
        }
    }
}
