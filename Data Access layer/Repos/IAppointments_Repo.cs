using DB_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_layer.Repos
{
    public interface IAppointments_Repo
    {      
       Task<IEnumerable<Appointment>> getAppointments();
       Task<Appointment> AddAppointment(Appointment appointment);
    }
}
