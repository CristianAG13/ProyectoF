using ClinicaApi.Models;

namespace ClinicaApi.Models
{


    public class Sucursal
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        
        public string Direccion { get; set; }

        public List<Cita> Citas { get; set; }
    }
}