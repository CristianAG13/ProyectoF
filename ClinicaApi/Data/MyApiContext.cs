using ClinicaApi.Models;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;

namespace ClinicaApi.Data
{
    public class MyApiContext : DbContext
    {
        public MyApiContext(DbContextOptions<MyApiContext> options)
            : base(options)
        {

        }

        //protected override void OnConfiguring
        //(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        // }

        // One to Many
        public DbSet<ClinicaApi.Models.Cita> Cita { get; set; } = default!;
        public DbSet<ClinicaApi.Models.Paciente> Paciente { get; set; } = default!;


        // Many to Many
        public DbSet<ClinicaApi.Models.Roles> Roles { get; set; } = default!;
        public DbSet<ClinicaApi.Models.User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {





            // One to Many

            modelBuilder.Entity<User>()
            .HasOne<Roles>(User => User.Roles)
            .WithMany(Roles => Roles.user)
            .HasForeignKey(k => k.RoleId);


            // Many to Many

        }
    }

}
