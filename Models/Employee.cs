using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLaboratory2.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeWorkingArea { get; set; }
        public int LaboratoryID { get; set; }
        public Laboratory Laboratory { get; set; }
        public IList<Test> Tests { get; set; }
    }
}
