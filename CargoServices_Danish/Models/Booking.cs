using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CargoServices_Danish.Models
{
    public class Booking
    {
        public int ID { get; set; }
        [Display(Name = "Customer Name")]
        public int CustomerID { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Booking Date")]
        public Nullable<DateTime> Date { get; set; }

        public Customer Customer { get; set; }
    }
}
