using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(C => C.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
           {
               new Customer { Id = 1, Name = "Karl Wall"},
               new Customer { Id = 2, Name = "Linnea Johansson"},
               new Customer { Id = 3, Name = "Göte Gustavsson"},
               new Customer { Id = 4, Name = "Nibbler"},
               new Customer { Id = 5, Name = "Nisse"}
           };
        }
    }
}