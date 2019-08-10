using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashProject.Models;

namespace TrashProject.Controllers
{
    public class CustomerController : Controller
    { private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult CustomerIndex()
        {
            var user = _context.Users.Find(User.Identity.GetUserId());
            return View(user);
        }

        // GET: Customer/Details/5
        public ActionResult AddAddress()
        {
            return View();
        }

        // GET: Customer/Create
        [HttpPost]
        public ActionResult AddAddress(AddAddressViewModel model)
        {
            var user = _context.Users.Find(User.Identity.GetUserId());
            user.Address = model.Address;


            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return View("CustomerIndex");
        }

       
       
        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
       



    }

    
}

