using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entidades.ViewModels;

namespace NexosPruebaTecnica.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private Interfaces.IServicioPaciente servicioPaciente;
        private Interfaces.IServicioMapper servicioMapper;

        public PacientesController(Interfaces.IServicioPaciente _servicioPaciente, Interfaces.IServicioMapper _servicioMapper)
        {
            servicioPaciente = _servicioPaciente;
            servicioMapper = _servicioMapper;
        }

        [HttpGet]
        [Route("ObtenerListadoPacientes")]
        public async Task<RespuestaGenerica<List<PacienteViewModel>>> ObtenerListadoPacientes()
        {
            RespuestaGenerica<List<PacienteViewModel>> respuestaGenerica = new RespuestaGenerica<List<PacienteViewModel>>();

            try
            {
                var listadoDoctores = await servicioPaciente.ObtenerListadoPacientes();
                respuestaGenerica.AsignarRespuesta(servicioMapper.ConvertirA<List<PacienteViewModel>>(listadoDoctores));
            }
            catch (Exception ex)
            {
                respuestaGenerica.CrearError(ex.Message);
            }

            return respuestaGenerica;
        }

        [HttpGet]
        [Route("ObtenerPacientePorId")]
        public async Task<RespuestaGenerica<PacienteViewModel>> ObtenerPacientePorId(long idPaciente)
        {
            RespuestaGenerica<PacienteViewModel> respuestaGenerica = new RespuestaGenerica<PacienteViewModel>();

            try
            {
                var listadoDoctores = await servicioPaciente.ObtenerPacientePorId(idPaciente);
                respuestaGenerica.AsignarRespuesta(servicioMapper.ConvertirA<PacienteViewModel>(listadoDoctores));
            }
            catch (Exception ex)
            {
                respuestaGenerica.CrearError(ex.Message);
            }

            return respuestaGenerica;
        }

        [HttpPost]
        [Route("CrearPaciente")]
        public async Task<RespuestaGenerica<bool>> CrearPaciente(Paciente paciente)
        {
            RespuestaGenerica<bool> respuestaGenerica = new RespuestaGenerica<bool>();

            try
            {
                respuestaGenerica.AsignarRespuesta(await servicioPaciente.CrearPaciente(paciente));
            }
            catch (Exception ex)
            {
                respuestaGenerica.CrearError(ex.Message);
            }

            return respuestaGenerica;
        }

        [HttpPut]
        [Route("ActualizarPaciente")]
        public async Task<RespuestaGenerica<bool>> ActualizarPaciente(Paciente paciente)
        {
            RespuestaGenerica<bool> respuestaGenerica = new RespuestaGenerica<bool>();

            try
            {
                respuestaGenerica.AsignarRespuesta(await servicioPaciente.ActualizarPaciente(paciente));
            }
            catch (Exception ex)
            {
                respuestaGenerica.CrearError(ex.Message);
            }

            return respuestaGenerica;
        }

        [HttpDelete]
        [Route("EliminarPaciente")]
        public async Task<RespuestaGenerica<bool>> EliminarPaciente(long idPaciente)
        {
            RespuestaGenerica<bool> respuestaGenerica = new RespuestaGenerica<bool>();

            try
            {
                respuestaGenerica.AsignarRespuesta(await servicioPaciente.EliminarPaciente(idPaciente));
            }
            catch (Exception ex)
            {
                respuestaGenerica.CrearError(ex.Message);
            }

            return respuestaGenerica;
        }

    }
}
