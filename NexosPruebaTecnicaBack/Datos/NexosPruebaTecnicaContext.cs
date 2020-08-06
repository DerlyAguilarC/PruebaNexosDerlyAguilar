using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public partial class NexosPruebaTecnicaContext : DbContext
    {
        public NexosPruebaTecnicaContext()
        {
        }

        public NexosPruebaTecnicaContext(DbContextOptions<NexosPruebaTecnicaContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Entidades.Doctor> Doctor { get; set; }
        public virtual DbSet<Entidades.DoctoresPacientes> DoctoresPacientes { get; set; }
        public virtual DbSet<Entidades.Paciente> Paciente { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:sqlserver.nippysoft.com,11433;Database=NexosPruebaTecnica;User Id=userPruebaTecnica;Password=Admin321");
            }
        }
    }
}
