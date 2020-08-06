using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DoctoresDatos : BaseContext
    {
        public async Task<List<Entidades.Doctor>> ObtenerListadoDoctores()
        {
            using (var contexto = ObtenerContexto())
            {
                return await contexto.Doctor.ToListAsync();
            }
        }

        public async Task<bool> CrearDoctor(Doctor nuevoDoctor)
        {
            using (var contexto = ObtenerContexto())
            {
                contexto.Doctor.Add(nuevoDoctor);
                await contexto.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<Entidades.ViewModels.PacienteAsignadoViewModel>> ObtenerPacientesPorDoctor(long idDoctor)
        {
            using (var contexto = ObtenerContexto())
            {
                return await contexto.Paciente.Select(s => new Entidades.ViewModels.PacienteAsignadoViewModel
                {
                    IdDoctor = idDoctor,
                    IdPaciente = s.Id,
                    NombrePaciente = s.NombreCompleto,
                    EstaAsignado = contexto.DoctoresPacientes.FirstOrDefault(ss => ss.IdDoctor == idDoctor && ss.IdPaciente == s.Id) != null
                }).ToListAsync();
            }
        }

    }
}
