using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class PacienteAsignadoViewModel
    {
        public long IdDoctor { get; set; }
        public long IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public bool EstaAsignado { get; set; }

    }
}
