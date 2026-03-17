using DB_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_layer.Repos
{
    public interface IDonors_Repo
    {
        Task<IEnumerable<Donor>> getDonors();

        Task<Donor> getDonorById(int idDonor);
    }
}
