using Data_access_layer.Repos;
using DB_layer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_layer.Controllers
{
    [ApiController]
    [Route("api/donors")]
    public class Donors_Controllers : ControllerBase
    {
        private readonly IDonors_Repo _donors_Repo;
        private readonly ILogger<Donors_Controllers> _logger;

        public Donors_Controllers(IDonors_Repo donors_Repo, ILogger<Donors_Controllers> logger)
        {
            _donors_Repo = donors_Repo ?? throw new ArgumentNullException(nameof(donors_Repo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donor>>> GetDonors()
        {
            var result = await _donors_Repo.getDonors();
            return Ok(result);
        }

        [HttpGet ("{idDonor}")]
        public async Task<ActionResult<Donor>> GetDonorById(int idDonor)
        {
            var result = await _donors_Repo.getDonorById(idDonor);
            return Ok(result);

        }
    }
}
