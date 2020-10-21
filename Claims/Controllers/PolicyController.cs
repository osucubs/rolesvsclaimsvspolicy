using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Claims.Controllers
{

    public class PolicyController : Controller
    {
        public IActionResult Index() => View();

        [Authorize(Policy = "WorkedTwoYears")]
        public IActionResult TwoYearRewards()
        {
            return View();
        }

        [Authorize(Policy = "WorkedFiveYears")]
        public IActionResult FiveYearRewards()
        {
            return View();
        }

        [Authorize(Policy = "WorkedTenYears")]
        public IActionResult TenYearRewards()
        {
            return View();
        }
    }
}
