using Aplicacion.Entidades.Persistencia;
using Aplicacion.Interfaces.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Presentacion.Controladores
{
    public class ProductoController : IProductoController
    {
        [NonAction]
        public List<CuotaPendiente> ObtenerCuotasPendientes(Producto producto)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public List<Documento> ObtenerDocumentos(Producto producto)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public List<PagoCuota> ObtenerPagoCuotas(Producto producto)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public List<Producto> ObtenerProductos(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public void PagarCuota(TarjetaPrePago tarjetaPrepago, Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
