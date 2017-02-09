using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap4.Models
{

    public class EmployeeModel
    {
        public EmployeeModel()
        {
            ReportingEmployees = new List<EmployeeModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string JobTitle { get; set; }

        public string About { get; set; }

        public int? ReportsTo { get; set; }


        public List<EmployeeModel> ReportingEmployees { get; set; }

    }
}
