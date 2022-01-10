using System.ComponentModel.DataAnnotations;

namespace VehicleApp.Data
{
    public class VehicleModel
    {
        [Key]
        public int Id { get; set; }
        public string MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
