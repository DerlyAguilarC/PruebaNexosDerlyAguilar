using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class ServicioMapper : Interfaces.IServicioMapper
    {
        public T ConvertirA<T>(object obj)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(Newtonsoft.Json.JsonConvert.SerializeObject(obj));
        }
    }
}
