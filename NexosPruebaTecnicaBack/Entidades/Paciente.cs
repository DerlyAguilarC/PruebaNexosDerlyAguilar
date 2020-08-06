using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class Paciente
    {
        [Key]
        public long Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string CodigoPostal { get; set; }
        public string TelefonoContacto { get; set; }

        public virtual ICollection<DoctoresPacientes> DoctoresPacientes { get; set; }
    }
}
