using CoreLaboratory2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLaboratory2.Controllers
{
    public class TestController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var data = c.Tests.Include(x => x.Employee).ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult NewTest()
        {
            List<SelectListItem> datas = (from item in c.Employees.ToList()
                                          select new SelectListItem
                                          {
                                              Text = item.EmployeeName + " " + item.EmployeeSurname,
                                              Value = item.EmployeeID.ToString()
                                          }).ToList();
            ViewBag.data = datas;
            return View();
        }
        [HttpPost]
        public IActionResult NewTest(Test t)
        {
            var emp = c.Employees.Where(x => x.EmployeeID == t.Employee.EmployeeID).FirstOrDefault();
            t.Employee = emp;
            c.Tests.Add(t);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTest(int id)
        {
            var emp = c.Tests.Find(id);
            c.Tests.Remove(emp);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateTest(int id)
        {
            List<SelectListItem> datas = (from item in c.Employees.ToList()
                                          select new SelectListItem
                                          {
                                              Text = item.EmployeeName + " " + item.EmployeeSurname,
                                              Value = item.EmployeeID.ToString()
                                          }).ToList();
            ViewBag.data = datas;
            var emp = c.Tests.Find(id);
            return View("UpdateTest", emp);
        }
        public IActionResult UpdateTest1(Test t)
        {
            var emp = c.Tests.Find(t.TestID);
            emp.TestName = t.TestName;
            emp.TestTypes = t.TestTypes;
            emp.TestDescription = t.TestDescription;
            emp.EmployeeID = t.Employee.EmployeeID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
