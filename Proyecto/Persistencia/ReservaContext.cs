using Aplicacion.Entidades.Persistencia;
using Aplicacion.Interfaces.Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class ReservaContext : IReservaContext
    {
        public void CambiarPlanPago(PlanPago planPago, Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public void ConvertirReserva(PreReserva preReserva)
        {
            throw new NotImplementedException();
        }

        public void GenerarContrato(Reserva reserva, PlanPago planPago)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> ObtenerReserva(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void PagarReserva(TarjetaPrePago tarjetaPrepago, Reserva reserva)
        {
            throw new NotImplementedException();
        }
    }
}
