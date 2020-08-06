using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IServicioMapper
    {
        T ConvertirA<T>(object obj);
    }
}
