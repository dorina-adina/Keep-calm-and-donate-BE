using AutoMapper;
using Bussines_layer.Models;
using Data_access_layer.Repos;
using DB_layer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_layer.Controllers
{
    [ApiController]
    [Route("api/appointments")]
    public class Appointments_Controller : ControllerBase
    {
        private readonly IAppointments_Repo _appointments_Repo;
        private readonly ILogger<Appointments_Controller> _logger;
        private readonly IMapper _mapper;

        public Appointments_Controller(IAppointments_Repo appointments_Repo, ILogger<Appointments_Controller> logger, IMapper mapper)
        {
            _appointments_Repo = appointments_Repo ?? throw new ArgumentNullException(nameof(appointments_Repo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = _mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointments()
        {
            var result = _appointments_Repo.getAppointments();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> InsertAppointment(AppointmentDTO appointment)
        {
            try
            {
                if (appointment == null)
                {
                    return NotFound("Null appointment");
                }

                var appointmentToInsert = _mapper.Map<AppointmentDTO, Appointment>(appointment);

                var item = await _appointments_Repo.AddAppointment(appointmentToInsert);

                return Ok(appointment);
            }

            catch (Exception ex) {
                return StatusCode(500, "Server error");
            }

        }
        
    }
}
