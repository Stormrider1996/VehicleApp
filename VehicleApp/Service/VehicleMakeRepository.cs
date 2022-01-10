using Microsoft.EntityFrameworkCore;
using VehicleApp.Data;

namespace VehicleApp.Service
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        private readonly AppDBContext _context;

        public VehicleMakeRepository(AppDBContext context)
        {
            _context = context;
        }

       

        public async Task<VehicleMake> GetVehicleMakeByID(int? Id)
        {
            
            return await _context.VehicleMakes
               .FirstOrDefaultAsync(m => m.Id == Id);
        }

        public async Task<List<VehicleMake>> GetVehicleMakeListAsync()
        {
            return await _context.VehicleMakes.ToListAsync();
        }

        public async Task Insert(VehicleMake VehicleMake)
        {
            _context.Add(VehicleMake);
            await _context.SaveChangesAsync();
        }

        public async Task Update(VehicleMake VehicleMake)
        {
            _context.Update(VehicleMake);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var vehicleMake = await _context.VehicleMakes.FindAsync(id);
            _context.VehicleMakes.Remove(vehicleMake);
            await _context.SaveChangesAsync();
        }
    }
}
