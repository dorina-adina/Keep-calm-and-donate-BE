using DB_layer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_layer.DbContexts
{
    public class Keep_calm_and_donate_DbContext : DbContext
    {
        public Keep_calm_and_donate_DbContext(DbContextOptions<Keep_calm_and_donate_DbContext> options) : base(options) { }

        public DbSet<Donor> Donors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<DB_layer.Entities.Type> Types { get; set; }
    }

}


