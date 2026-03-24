using Db_layer.DbContexts;
using DB_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_layer.Repos
{
    public class Appointments_Repo : IAppointments_Repo
    {
        private readonly Keep_calm_and_donate_DbContext _context;

        public Appointments_Repo(Keep_calm_and_donate_DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Appointment>> getAppointments()
        {
            return _context.Set<Appointment>();
        }

        public async Task<Appointment> AddAppointment(Appointment appointment)
        {
            _context.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment;
        }

    }
}
