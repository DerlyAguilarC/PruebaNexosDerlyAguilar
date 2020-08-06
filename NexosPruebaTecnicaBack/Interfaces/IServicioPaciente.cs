using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IServicioPaciente
    {
        Task<List<Entidades.ViewModels.PacienteViewModel>> ObtenerListadoPacientes();
        Task<Entidades.Paciente> ObtenerPacientePorId(long idPaciente);
        Task<bool> CrearPaciente(Paciente nuevoPaciente);
        Task<bool> ActualizarPaciente(Paciente paciente);
        Task<bool> EliminarPaciente(long idPaciente);
    }
}

