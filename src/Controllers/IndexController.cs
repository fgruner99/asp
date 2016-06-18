using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApi
{
    [Route("/")]
    public class IndexController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("Request processed by " + System.Environment.MachineName);
        }
    }
}