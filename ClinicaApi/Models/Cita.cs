namespace ClinicaApi.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Lugar { get; set; }
        public string Status { get; set; } // ACTIVA o CANCELADA
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public string Tipo { get; set; } // Medicina General, Odontología, etc.

    }
}
