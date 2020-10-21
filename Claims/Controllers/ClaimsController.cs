using Claims.AuthorizationAttributes;
using Microsoft.AspNetCore.Mvc;

namespace Claims.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Index() => View();

        [YearsWorked(2)]
        public IActionResult TwoYearRewards()
        {
            return View();
        }

        [YearsWorked(5)]
        public IActionResult FiveYearRewards()
        {
            return View();
        }

        [YearsWorked(10)]
        public IActionResult TenYearRewards()
        {
            return View();
        }
    }
}
