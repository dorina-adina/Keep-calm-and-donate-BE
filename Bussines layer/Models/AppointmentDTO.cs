using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_layer.Models
{
    public class AppointmentDTO
    {
        public int TypeId { get; set; }
        public int DonorId { get; set; }
        public int HospitalId { get; set; }
        public DateTime Date { get; set; }
    }
}
