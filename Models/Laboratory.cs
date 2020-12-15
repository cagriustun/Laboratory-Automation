using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLaboratory2.Models
{
    public class Laboratory
    {
        [Key]
        public int LaboratoryID { get; set; }
        public string LaboratoryName { get; set; }
        public string LaboratoryType { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}
