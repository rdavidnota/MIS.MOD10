using Aplicacion.Entidades.Persistencia;
using System.Collections.Generic;

namespace Aplicacion.Interfaces.Persistencia
{
    public interface IProductoController : IDataBaseContext
    {
        List<Producto> ObtenerProductos(Cliente cliente);
        List<PagoCuota> ObtenerPagoCuotas(Producto producto);
        List<CuotaPendiente> ObtenerCuotasPendientes(Producto producto);
        List<Documento> ObtenerDocumentos(Producto producto);
        void PagarCuota(TarjetaPrePago tarjetaPrepago, Producto producto);
    }
}
