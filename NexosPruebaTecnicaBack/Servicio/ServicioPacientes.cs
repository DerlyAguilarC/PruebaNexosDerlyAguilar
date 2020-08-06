using Entidades;
using Entidades.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ServicioPacientes : Interfaces.IServicioPaciente
    {
        public async Task<bool> ActualizarPaciente(Paciente paciente)
        {
            Datos.PacientesDatos pacientesDatos = new Datos.PacientesDatos();
            return await pacientesDatos.ActualizarPaciente(paciente);
        }


        public async Task<bool> CrearPaciente(Paciente nuevoPaciente)
        {
            Datos.PacientesDatos pacientesDatos = new Datos.PacientesDatos();
            return await pacientesDatos.CrearPaciente(nuevoPaciente);
        }

        public async Task<bool> EliminarPaciente(long idPaciente)
        {
            Datos.PacientesDatos pacientesDatos = new Datos.PacientesDatos();
            return await pacientesDatos.BorrarPaciente(idPaciente);
        }

        public async Task<List<Entidades.ViewModels.PacienteViewModel>> ObtenerListadoPacientes()
        {
            Datos.PacientesDatos pacientesDatos = new Datos.PacientesDatos();
            return await pacientesDatos.ObtenerListadoPacientes();
        }

        public async Task<Paciente> ObtenerPacientePorId(long idPaciente)
        {
            Datos.PacientesDatos pacientesDatos = new Datos.PacientesDatos();
            return await pacientesDatos.ObtenerPacientePorId(idPaciente);
        }
    }
}
