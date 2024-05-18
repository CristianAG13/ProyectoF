using static System.Reflection.Metadata.BlobBuilder;

namespace ClinicaApi.Models
{
    public class Roles
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<User> user { get; set; }

    }
}
