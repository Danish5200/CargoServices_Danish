using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CargoServices_Danish.Models
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string VehicleNo { get; set; }
        [Display(Name = "Vehicle Type")]
        public int VehicleTypeID { get; set; }

        public VehicleType VehicleType { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
