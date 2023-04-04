using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web_day4.Controllers
{
    public class @new : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
