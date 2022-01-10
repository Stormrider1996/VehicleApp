using VehicleApp.Data;
namespace VehicleApp.Service
{
    public interface IVehicleModelRepository
    {
        public Task<List<VehicleModel>> GetVehicleModelListAsync();
        public Task<VehicleModel> GetVehicleModelByID(int? Id);

        public Task Insert(VehicleModel VehicleMake);
        public Task Update(VehicleModel VehicleMake);
        public Task Delete(int id);
    }
}
