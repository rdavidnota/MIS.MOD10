using Aplicacion.Entidades.Persistencia;
using Aplicacion.Interfaces.Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    class PreReservaContext : IPreReservaContext
    {
        public void DarBajaPreReserva(PreReserva preReserva)
        {
            throw new NotImplementedException();
        }

        public void EscogerPlanPago(PlanPago planPago, PreReserva prereserva)
        {
            throw new NotImplementedException();
        }

        public void GuardarNuevaPreReserva(PreReserva preReserva)
        {
            throw new NotImplementedException();
        }

        public List<PreReserva> ObtenerPreReserva(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void PagarPrereserva(TarjetaPrePago tarjetaPrePago, PreReserva preReserva)
        {
            throw new NotImplementedException();
        }
    }
}
