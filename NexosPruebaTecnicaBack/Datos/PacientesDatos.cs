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
    public class PacientesDatos : BaseContext
    {
        public async Task<List<Entidades.ViewModels.PacienteViewModel>> ObtenerListadoPacientes()
        {
            using (var contexto = ObtenerContexto())
            {
                return await contexto.Paciente.Select(s => new Entidades.ViewModels.PacienteViewModel()
                {
                    Id = s.Id,
                    CodigoPostal = s.CodigoPostal,
                    NumeroSeguroSocial = s.NumeroSeguroSocial,
                    NombreCompleto = s.NombreCompleto,
                    TelefonoContacto = s.TelefonoContacto,
                    ListadoDoctores = contexto.DoctoresPacientes.Include("Doctor").Where(ss => ss.IdPaciente == s.Id).Select(ss => new Entidades.ViewModels.DoctorViewModel()
                    {
                        Id = ss.Doctor.Id,
                        NombreCompleto = ss.Doctor.NombreCompleto
                    }).ToList()
                }).ToListAsync();
            }
        }

        public async Task<Entidades.Paciente> ObtenerPacientePorId(long idPaciente)
        {
            using (var contexto = ObtenerContexto())
            {
                return await contexto.Paciente.FirstOrDefaultAsync(s => s.Id == idPaciente);
            }
        }

        public async Task<bool> CrearPaciente(Paciente nuevoPaciente)
        {
            using (var contexto = ObtenerContexto())
            {
                contexto.Paciente.Add(nuevoPaciente);
                await contexto.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> ActualizarPaciente(Paciente paciente)
        {
            using (var contexto = ObtenerContexto())
            {
                contexto.Paciente.Update(paciente);
                await contexto.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> BorrarPaciente(long idPaciente)
        {
            using (var contexto = ObtenerContexto())
            {
                var paciente = await contexto.Paciente.FirstOrDefaultAsync(s => s.Id == idPaciente);
                if (paciente != null)
                {
                    contexto.Paciente.Remove(paciente);
                    await contexto.SaveChangesAsync();
                }
                return true;
            }
        }


    }
}
