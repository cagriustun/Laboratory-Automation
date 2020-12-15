using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLaboratory2.Models
{
    public class Test
    {
        [Key]
        public int TestID { get; set; }
        public string TestName { get; set; }
        public string TestTypes { get; set; }
        public string TestDescription { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
