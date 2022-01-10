using VehicleApp.Data;

namespace VehicleApp.Service
{
    public interface IVehicleMakeRepository
    {
       public  Task<List<VehicleMake>> GetVehicleMakeListAsync();
        public Task<VehicleMake> GetVehicleMakeByID(int? Id);

        public Task Insert(VehicleMake VehicleMake);
        public Task Update(VehicleMake VehicleMake);
        public Task Delete(int id);
    }
}

