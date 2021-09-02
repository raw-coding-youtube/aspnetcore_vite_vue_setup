using Microsoft.AspNetCore.Mvc;

namespace ViteApi.Controllers
{
    [Route("/api/[controller]")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Test result");
        }
    }

}