using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class BaseContext
    {
        protected NexosPruebaTecnicaContext ObtenerContexto()
        {
            NexosPruebaTecnicaContext contexto = new NexosPruebaTecnicaContext();
            return contexto;
        }
    }
}
