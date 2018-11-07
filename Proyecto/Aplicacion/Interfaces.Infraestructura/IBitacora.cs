using Aplicacion.Entidades.Infraestructura;

namespace Aplicacion.Interfaces.Infraestructura
{
    public interface IBitacora
    {
        void RegistrarAccionBitacora(Accion accion, Usuario usuario);
    }
}
