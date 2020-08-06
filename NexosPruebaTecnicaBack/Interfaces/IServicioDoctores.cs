using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IServicioDoctores
    {
        Task<List<Entidades.Doctor>> ObtenerListadoDoctores();
        Task<bool> CrearDoctor(Doctor nuevoDoctor);

        Task<List<Entidades.ViewModels.PacienteAsignadoViewModel>> ObtenerListadoPacientesAsignados(long idDoctor);
    }
}
