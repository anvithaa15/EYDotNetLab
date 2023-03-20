using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2mvc.Controllers
{
    public class EYController : Controller
    {
        public IActionResult Index(int id) //can add view here..}
        {
            ViewBag.ID = id; //to pass data
            return View();
        }
        public IActionResult mypage()
        {
            return View();
        }
    }
}
