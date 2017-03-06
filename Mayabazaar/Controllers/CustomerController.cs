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

        Customer customer = new Customer()
        {
            Name = "Avatar"
        };
        // GET: Customers
        public ActionResult Index()
        {
            
            return View(customer);
        }

        public ActionResult Index(int id)
        {
            
            return View(customer);
        }
    }
}