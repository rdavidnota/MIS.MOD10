using Aplicacion.Entidades.Presentacion;
using Aplicacion.Interfaces.Presentacion;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Presentacion.Controladores
{
    public class PreReservaController : IPreReservaCommand
    {
        [NonAction]
        public void DarBajaPreReserva(PreReserva preReserva)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public void EscogerPlanPago(PlanPago planPago, PreReserva prereserva)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public void GuardarNuevaPreReserva(PreReserva preReserva)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public List<PreReserva> ObtenerPreReserva(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public void PagarPrereserva(TarjetaPrePago tarjetaPrePago, PreReserva preReserva)
        {
            throw new NotImplementedException();
        }
    }
}
