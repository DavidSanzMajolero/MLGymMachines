using MainWeb.Services;
using FinalProject.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MainWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GymMachinesController : ControllerBase
    {
        private readonly GymMachineService _gymMachineService;

        public GymMachinesController(GymMachineService gymMachineService)
        {
            _gymMachineService = gymMachineService;
        }

        // GET: api/GymMachines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GymMachine>>> GetGymMachines()
        {
            var machines = await _gymMachineService.GetGymMachines();
            return Ok(machines);
        }

        // GET: api/GymMachines/1
        [HttpGet("{id}")]
        public async Task<ActionResult<GymMachine>> GetGymMachine(int id)
        {
            var machine = await _gymMachineService.GetGymMachine(id);
            if (machine == null)
            {
                return NotFound();
            }
            return Ok(machine);
        }

        // GET: api/GymMachines/name/{name}
        [HttpGet("name/{name}")]
        public async Task<ActionResult<GymMachine>> GetGymMachineByName(string name)
        {
            var machine = await _gymMachineService.GetGymMachineByName(name);
            if (machine == null)
            {
                return NotFound();
            }
            return Ok(machine);
        }
    }
}
