using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashProject.Models;

namespace TrashProject.Controllers
{
    [Authorize(Roles = RoleName.Employee)]
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;

        // GET: Employee
        public EmployeeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var employees = _context.Employees
             .ToList();
            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
           return RedirectToAction("RegisterEmployee", "Account");
        }

        // POST: Employee/Create
        

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
