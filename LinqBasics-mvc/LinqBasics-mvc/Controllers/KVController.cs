using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LinqBasics_mvc.Controllers
{
    public class KVController : Controller
    {
        List<student> stud = new List<student>()
            {
             new student(){studid=200,studname="harsha",studmarks=89},
             new student(){studid=201,studname="anvitha",studmarks=55},
             new student(){studid=202,studname="bhoomika",studmarks=78},
             new student(){studid=203,studname="rachana",studmarks=98},
             new student(){studid=204,studname="rahul",studmarks=96}
            };
        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult index()
        {
            //displaying all the student details
            var res = (from s in stud select s);
            ViewBag.result = res;

            //aggregate func to count total num of students present
            var ans = (from s in stud select s.studid);           
            ViewBag.value = stud.Count;

            //adding another name
            ViewBag.name = "bhoomika";



            //ViewData["result"] = stud;
            //ViewBag.results = stud;

            return View();
        }

    }
}
