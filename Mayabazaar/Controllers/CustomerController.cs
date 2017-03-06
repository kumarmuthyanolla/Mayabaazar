using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mayabazaar.Models;

namespace Mayabazaar.Controllers
{
    public class CustomerController : Controller
    {

          static  List<Customer> customers = new List<Customer>();
           

        [Route("Customer")]
        public ActionResult Index()
        {
            customers.Add(new Customer() { Name = "leonardo" });
            customers.Add(new Customer() { Name = "tom hanks" });
            customers.Add(new Customer() { Name = "stollne" });
            customers.Add(new Customer() { Name = "ryan reynolds" });

            return View(customers);
        }
        [Route("Customer/Details/{id}")]
        public ActionResult Details(int id)
        {
            
            if (id < customers.Count)
                return View(customers[id]);
            else
                return Content("No customer are present");

        }
    }
}