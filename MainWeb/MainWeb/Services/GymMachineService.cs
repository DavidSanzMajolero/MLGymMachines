using FinalProject.Domain;
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MainWeb.Services
{
    public class GymMachineService
    {
        private readonly MachineContext _context;

        public GymMachineService(MachineContext context)
        {
            _context = context;
        }

        public async Task<List<GymMachine>> GetGymMachines()
        {
            return await _context.GymMachines.ToListAsync();
        }

        public async Task<GymMachine> GetGymMachine(int id)
        {
            return await _context.GymMachines.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<GymMachine> GetGymMachineByName(string name)
        {
            // Busca insensible a mayúsculas
            return await _context.GymMachines
                                 .FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
        }

        public async Task AddGymMachine(GymMachine gymMachine)
        {
            _context.GymMachines.Add(gymMachine);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateGymMachine(GymMachine gymMachine)
        {
            _context.GymMachines.Update(gymMachine);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGymMachine(int id)
        {
            var gymMachine = await GetGymMachine(id);
            if (gymMachine != null)  // Asegúrate de que la máquina exista antes de intentar eliminarla
            {
                _context.GymMachines.Remove(gymMachine);
                await _context.SaveChangesAsync();
            }
        }
    }
}
