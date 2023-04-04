using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_WebAPI.Controllers
{
    public class myController : ApiController
    {
        EYDatabaseEntities db = new EYDatabaseEntities();
        //this method will return all customer's list

        public IEnumerable<customerss> Get()
        {
            return db.customersses.ToList();
        }

        //this method will return a single customer against id
        public customerss Get(int id)
        {
            customerss customerss = db.customersses.Find(id);
            return customerss;
        }

        //this method will add a new customer
        public void POST(customerss cust)
        {
            db.customersses.Add(cust);
            db.SaveChanges();
        }
    }
}
