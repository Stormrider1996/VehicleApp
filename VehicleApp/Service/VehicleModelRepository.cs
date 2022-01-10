using Microsoft.EntityFrameworkCore;
using VehicleApp.Data;
namespace VehicleApp.Service
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        private readonly AppDBContext _context;

        public VehicleModelRepository(AppDBContext context)
        {
            _context = context;
        }



        public async Task<VehicleModel> GetVehicleModelByID(int? Id)
        {

            return await _context.VehicleModels 
               .FirstOrDefaultAsync(m => m.Id == Id);
        }

        public async Task<List<VehicleModel>> GetVehicleModelListAsync()
        {
            return await _context.VehicleModels.ToListAsync();
        }

        public async Task Insert(VehicleModel VehicleModel)
        {
            _context.Add(VehicleModel);
            await _context.SaveChangesAsync();
        }

        public async Task Update(VehicleModel VehicleModel)
        {
            _context.Update(VehicleModel);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var VehicleModel = await _context.VehicleModels.FindAsync(id);
            _context.VehicleModels.Remove(VehicleModel);
            await _context.SaveChangesAsync(); 
        }
    }
}
