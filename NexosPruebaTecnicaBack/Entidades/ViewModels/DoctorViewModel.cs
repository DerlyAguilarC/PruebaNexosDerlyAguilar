using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades.ViewModels
{
    public class DoctorViewModel
    {
        public long Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Especialidad { get; set; }
        public string NumeroCredencial { get; set; }
        public string HospitalTrabajo { get; set; }
    }
}
