using static System.Reflection.Metadata.BlobBuilder;

namespace ClinicaApi.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<UserRole> UserRoles { get; set; }

    }
}
