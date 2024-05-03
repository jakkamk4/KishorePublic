using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Location : ILocation
    {
        public string LocationNameOfEmployee { get; set; }

        public Location(IEmployee employee)
        {
            this.LocationNameOfEmployee = GetEmpLocation(employee.EmpName);
        }

        public string GetEmpLocation(string empName)
        {
            if (empName == "Test Employee")
            {
                return "Test Location";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
