namespace Catalog.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }

        [HttpGet("test")]
        public string Test()
        {
            return "etst";
        }
    }
}
