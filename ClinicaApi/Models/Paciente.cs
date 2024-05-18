﻿namespace ClinicaApi.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public List<Cita> Citas { get; set; }
    }
}
