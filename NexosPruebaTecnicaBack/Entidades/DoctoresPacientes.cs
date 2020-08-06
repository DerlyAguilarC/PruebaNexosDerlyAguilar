using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades
{
    public class DoctoresPacientes
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Doctor")]
        public long IdDoctor { get; set; }

        [ForeignKey("Paciente")]
        public long IdPaciente { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
