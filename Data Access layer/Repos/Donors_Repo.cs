using Db_layer.DbContexts;
using DB_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_layer.Repos
{
    public class Donors_Repo : IDonors_Repo
    {
        private readonly Keep_calm_and_donate_DbContext _context;
        public Donors_Repo(Keep_calm_and_donate_DbContext context) 
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Donor>> getDonors()
        {
            return  _context.Set<Donor>();
        }

        public async Task<Donor> getDonorById(int idDonor)
        {
            var result = await _context.FindAsync<Donor>(idDonor);
            return result;
        }
    }
}
