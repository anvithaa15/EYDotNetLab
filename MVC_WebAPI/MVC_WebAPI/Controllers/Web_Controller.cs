using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebAPI.Controllers
{
    public class Web_Controller : Controller
    {
        // GET: Web_
        public ActionResult Index()
        {
            return View();
        }
    }
}