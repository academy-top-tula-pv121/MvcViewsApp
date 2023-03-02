using Microsoft.AspNetCore.Mvc;
using MvcViewsApp.Models;
using System.Diagnostics;

namespace MvcViewsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /*
            ViewData
            ViewBag
            Model object
            */

            this.ViewData["title"] = "Home page";
            ViewData["header"] = "Welcome to Home page";
            ViewData["users"] = new List<string>() { "Bob", "Joe", "Tim", "Sam" };

            ViewBag.Date = DateTime.Now.ToLongDateString();
            ViewBag.Hour = DateTime.Now.Hour;
            ViewBag.Users = new List<string>() { "Leo", "Tom", "Jim", "Sam" };

            List<string> usersList = new List<string>() { "Max", "Ann", "Kim", "Pit" };

            return View(usersList);
        }

        
    }
}