using Entidades;
using Entidades.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ServicioDoctores : Interfaces.IServicioDoctores
    {
        public async Task<bool> CrearDoctor(Doctor nuevoDoctor)
        {
            Datos.DoctoresDatos doctoresDatos = new Datos.DoctoresDatos();
            return await doctoresDatos.CrearDoctor(nuevoDoctor);
        }

        public async Task<List<Doctor>> ObtenerListadoDoctores()
        {
            Datos.DoctoresDatos doctoresDatos = new Datos.DoctoresDatos();
            return await doctoresDatos.ObtenerListadoDoctores();
        }

        public async Task<List<PacienteAsignadoViewModel>> ObtenerListadoPacientesAsignados(long idDoctor)
        {
            Datos.DoctoresDatos doctoresDatos = new Datos.DoctoresDatos();
            return await doctoresDatos.ObtenerPacientesPorDoctor(idDoctor);
        }
    }
}
