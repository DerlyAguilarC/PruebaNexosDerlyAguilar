using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class Doctor
    {
        [Key]
        public long Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Especialidad { get; set; }
        public string NumeroCredencial { get; set; }
        public string HospitalTrabajo { get; set; }

        public virtual ICollection<DoctoresPacientes> DoctoresPacientes { get; set; }
    }
}
