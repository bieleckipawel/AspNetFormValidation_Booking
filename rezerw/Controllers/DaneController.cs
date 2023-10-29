using Microsoft.AspNetCore.Mvc;
using rezerw.Models;

namespace rezerw.Controllers
{
    public class DaneController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane danenew){
            if (ModelState.IsValid)
            {
                return View("Result",danenew);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Result()
        {
            return View();
        }
    }
}
