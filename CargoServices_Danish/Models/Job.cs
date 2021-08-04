using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoServices_Danish.Models
{
    public class Job
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int DriverID { get; set; }
        public int VehicleID { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public string Status { get; set; }

        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
