using Aplicacion.Entidades.Presentacion;
using System.Collections.Generic;

namespace Aplicacion.Interfaces.Presentacion
{
    interface IProductoCommand : IBaseCommand
    {
        List<Producto> ObtenerProductos(Cliente cliente);
        List<PagoCuota> ObtenerPagoCuotas(Producto producto);
        List<CuotaPendiente> ObtenerCuotasPendientes(Producto producto);
        List<Documento> ObtenerDocumentos(Producto producto);
        void PagarCuota(TarjetaPrePago tarjetaPrepago, Producto producto);
    }
}
