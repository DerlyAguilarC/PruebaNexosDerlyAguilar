namespace Entidades.ViewModels
{
    public class RespuestaGenerica<T>
    {
        public bool EsError { get; set; }
        public string MensajeError { get; set; }
        public T ObjRespuesta { get; set; }

        public void CrearError(string mensaje)
        {
            EsError = true;
            MensajeError = mensaje;
            ObjRespuesta = default(T);
        }
        public void AsignarRespuesta(T _objRespuesta)
        {
            EsError = false;
            MensajeError = string.Empty;
            ObjRespuesta = _objRespuesta;
        }
    }
}
