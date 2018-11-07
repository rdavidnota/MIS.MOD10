using Aplicacion.Entidades.Presentacion;
using Aplicacion.Interfaces.Presentacion;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Presentacion.Controladores
{
    public class ReservaController : IReservaCommand
    {
        [NonAction]
        public void CambiarPlanPago(PlanPago planPago, Reserva reserva)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public void ConvertirReserva(PreReserva preReserva)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public void GenerarContrato(Reserva reserva, PlanPago planPago)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public List<Reserva> ObtenerReserva(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public void PagarReserva(TarjetaPrePago tarjetaPrepago, Reserva reserva)
        {
            throw new NotImplementedException();
        }
    }
}
