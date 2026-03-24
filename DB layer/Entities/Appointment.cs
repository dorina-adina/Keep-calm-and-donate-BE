using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_layer.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        [ForeignKey("Id")]
        public int TypeId { get; set; }
        [ForeignKey("Id")]
        public int DonorId { get; set; }
        [ForeignKey("Id")]
        public int HospitalId { get; set; }
        public DateTime Date { get; set; }
    }
}
