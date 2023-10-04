using citas_medicas.Entities;
using Microsoft.EntityFrameworkCore;

namespace citas_medicas.Repositories
{
    public class CMContext : DbContext
    {
        public DbSet<Usuario> UsuariosDB { get; set; }
        public DbSet<Cita> CitasDB { get; set; }
        public DbSet<Paciente> PacientesDB { get; set; }
        public DbSet<Medico> MedicosDB { get; set; }
        public DbSet<Diagnostico> DiagnosticosDB { get; set; }

        public CMContext(DbContextOptions<CMContext> options) : base(options)
        {
        }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuarios = modelBuilder.Entity<Usuario>();
            usuarios.ToTable("USUARIOS");
       
            var pacientes = modelBuilder.Entity<Paciente>();
            pacientes.ToTable("PACIENTES");

            var medicos = modelBuilder.Entity<Medico>();
            medicos.ToTable("MEDICOS");

                //medicos.HasMany(m => m.Pacientes)
                //       .WithMany(p => p.Medicos)
                //       .UsingEntity<MedicoPaciente>(


                //        mp => mp.HasOne(prop => prop.Paciente)
                //        .WithMany()
                //        .HasForeignKey(prop => prop.PacienteId),

                //        mp => mp.HasOne(prop => prop.Medico)
                //        .WithMany()
                //        .HasForeignKey(prop => prop.MedicoId),

                //        mp =>
                //        {
                //            mp.HasKey(prop => new { prop.MedicoId, prop.PacienteId });
                //            mp.ToTable("MEDICO_PACIENTE");
                //        }
                //    );

                var citas = modelBuilder.Entity<Cita>();
            
            citas.HasOne(c=>c.Diagnostico)
                 .WithMany()
                 .HasForeignKey("DiagnosticoId");


            citas.ToTable("CITAS");

            var diagnosticos = modelBuilder.Entity<Diagnostico>();
            diagnosticos.ToTable("DIAGNOSTICOS");

        }
    }
}
