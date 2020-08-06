using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class PacienteViewModel
    {
        public long Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string CodigoPostal { get; set; }
        public string TelefonoContacto { get; set; }

        public List<Entidades.ViewModels.DoctorViewModel> ListadoDoctores { get; set; }

    }
}
