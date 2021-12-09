using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWEBAPI_DK_Interation.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public decimal salary { get; set; }
    }
}
