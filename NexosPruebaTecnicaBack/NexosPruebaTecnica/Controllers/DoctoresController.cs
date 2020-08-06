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
    public class DoctoresController : ControllerBase
    {
        private Interfaces.IServicioDoctores servicioDoctores;
        private Interfaces.IServicioMapper servicioMapper;

        public DoctoresController(Interfaces.IServicioDoctores _servicioDoctores, Interfaces.IServicioMapper _servicioMapper)
        {
            servicioDoctores = _servicioDoctores;
            servicioMapper = _servicioMapper;
        }

        [HttpGet]
        [Route("ObtenerListadoDoctores")]
        public async Task<RespuestaGenerica<List<DoctorViewModel>>> ObtenerListadoDoctores()
        {
            RespuestaGenerica<List<DoctorViewModel>> respuestaGenerica = new RespuestaGenerica<List<DoctorViewModel>>();

            try
            {
                var listadoDoctores = await servicioDoctores.ObtenerListadoDoctores();
                respuestaGenerica.AsignarRespuesta(servicioMapper.ConvertirA<List<DoctorViewModel>>(listadoDoctores));
            }
            catch (Exception ex)
            {
                respuestaGenerica.CrearError(ex.Message);
            }

            return respuestaGenerica;
        }

        [HttpGet]
        [Route("ObtenerListadoPacientesAsignados")]
        public async Task<RespuestaGenerica<List<Entidades.ViewModels.PacienteAsignadoViewModel>>> ObtenerListadoPacientesAsignados(long idDoctor)
        {
            RespuestaGenerica<List<Entidades.ViewModels.PacienteAsignadoViewModel>> respuestaGenerica = new RespuestaGenerica<List<Entidades.ViewModels.PacienteAsignadoViewModel>>();

            try
            {
                var listadoPacientes = await servicioDoctores.ObtenerListadoPacientesAsignados(idDoctor);
                respuestaGenerica.AsignarRespuesta(listadoPacientes);
            }
            catch (Exception ex)
            {
                respuestaGenerica.CrearError(ex.Message);
            }

            return respuestaGenerica;
        }

        [HttpPost]
        [Route("CrearDoctor")]
        public async Task<RespuestaGenerica<bool>> CrearDoctor(Doctor nuevoDoctor)
        {
            RespuestaGenerica<bool> respuestaGenerica = new RespuestaGenerica<bool>();

            try
            {
                respuestaGenerica.AsignarRespuesta(await servicioDoctores.CrearDoctor(nuevoDoctor));
            }
            catch (Exception ex)
            {
                respuestaGenerica.CrearError(ex.Message);
            }

            return respuestaGenerica;
        }
    }
}
