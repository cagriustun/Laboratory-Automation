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
    public class EmployeeController : Controller
    {
        Context c = new Context();
        public IActionResult Index(string search)
        {
            var data = c.Employees.Include(x => x.Laboratory).ToList();
            return View(c.Employees.Include(x => x.Laboratory).Where(x => x.EmployeeName.StartsWith(search) || x.EmployeeSurname.StartsWith(search) || search == null).ToList());
        }
        [HttpGet]
        public IActionResult NewEmployee()
        {
            List<SelectListItem> datas = (from item in c.Laboratorys.ToList()
                                         select new SelectListItem
                                         {
                                             Text = item.LaboratoryName,
                                             Value = item.LaboratoryID.ToString()
                                         }).ToList();
            ViewBag.data = datas;
            return View();
        }
        [HttpPost]
        public IActionResult NewEmployee(Employee e)
        {
            var emp = c.Laboratorys.Where(x => x.LaboratoryID == e.Laboratory.LaboratoryID).FirstOrDefault();
            e.Laboratory = emp;
            c.Employees.Add(e);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEmployee(int id)
        {
            var emp = c.Employees.Find(id);
            c.Employees.Remove(emp);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateEmployee(int id)
        {
            List<SelectListItem> datas = (from item in c.Laboratorys.ToList()
                                          select new SelectListItem
                                          {
                                              Text = item.LaboratoryName,
                                              Value = item.LaboratoryID.ToString()
                                          }).ToList();
            ViewBag.data = datas;
            var emp = c.Employees.Find(id);
            return View("UpdateEmployee", emp);
        }
        public IActionResult UpdateEmployee1(Employee e)
        {
            var emp = c.Employees.Find(e.EmployeeID);
            emp.EmployeeName = e.EmployeeName;
            emp.EmployeeSurname = e.EmployeeSurname;
            emp.EmployeeWorkingArea = e.EmployeeWorkingArea;
            emp.LaboratoryID = e.Laboratory.LaboratoryID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult EmployeeDetail(int id)
        {
            var datas = c.Tests.Where(x => x.EmployeeID == id).ToList();
            var empN = c.Employees.Where(x => x.EmployeeID == id).Select(y => (y.EmployeeName + " " + y.EmployeeSurname)).FirstOrDefault();
            ViewBag.empName = empN;
            return View(datas);
        }

    }
}
