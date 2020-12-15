using CoreLaboratory2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLaboratory2.Controllers
{
    public class LaboratoryController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var data = c.Laboratorys.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult NewLaboratory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewLaboratory(Laboratory lab)
        {
            c.Laboratorys.Add(lab);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteLaboratory(int id)
        {
            var lab = c.Laboratorys.Find(id);
            if (lab.Employees != null)
            {
                var i = 0;
            }
            else
            {
                c.Laboratorys.Remove(lab);
                c.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult UpdateLaboratory(int id)
        {
            var lab = c.Laboratorys.Find(id);
            return View("UpdateLaboratory", lab);
        }
        public IActionResult UpdateLaboratory1(Laboratory l)
        {
            var lab = c.Laboratorys.Find(l.LaboratoryID);
            lab.LaboratoryName = l.LaboratoryName;
            lab.LaboratoryType = l.LaboratoryType;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult LaboratoryDetail(int id)
        {
            var datas = c.Employees.Where(x => x.LaboratoryID == id).ToList();
            var labN = c.Laboratorys.Where(x => x.LaboratoryID == id).Select(y => y.LaboratoryName).FirstOrDefault();
            ViewBag.labName = labN;
            return View(datas);
        }
    }
}
