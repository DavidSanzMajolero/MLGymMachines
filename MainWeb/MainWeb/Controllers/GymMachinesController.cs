using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using MainWeb;
using FinalProject.Domain.Entities;
using MainWeb.Services;

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

        // POST: api/GymMachines/predict
        [HttpPost("predict")]
        public async Task<IActionResult> PredictMachine(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No image uploaded.");
            }

            // Leer la imagen como byte array
            byte[] imageBytes;
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                imageBytes = memoryStream.ToArray();
            }

            // Crear el input para el modelo de ML
            var input = new MLModelMachineGym.ModelInput
            {
                ImageSource = imageBytes
            };

            // Hacer la predicción con el modelo de ML
            var result = MLModelMachineGym.Predict(input);
            var predictedLabel = result.PredictedLabel;

            // Buscar la máquina por el nombre predicho
            var machine = await _gymMachineService.GetGymMachineByName(predictedLabel);
            if (machine == null)
            {
                return NotFound("Machine not found.");
            }

            return Ok(new
            {
                name = machine.Name,
                description = machine.Description,
                usingSteps = machine.UsingSteps
            });
        }
    }
}
