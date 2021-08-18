using Microsoft.AspNetCore.Mvc;

namespace ViteApi.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Test result");
        }
    }

}