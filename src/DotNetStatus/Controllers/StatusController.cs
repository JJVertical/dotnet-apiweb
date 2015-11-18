using System;
using Microsoft.AspNet.Mvc;

namespace DotNetStatus.Controllers
{
    public class StatusController : Controller
    {
        [Route("/Status")]
        public IActionResult Index()
        {
            string temp = "Hello there!";
            return View("Index", temp);
        }
    }
}
