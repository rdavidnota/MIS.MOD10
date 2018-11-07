using Aplicacion.Entidades.Persistencia;
using System.Collections.Generic;

namespace Aplicacion.Interfaces.Persistencia
{
    public interface IReservaContext : IDataBaseContext
    {
        List<Reserva> ObtenerReserva(Cliente cliente);
        void ConvertirReserva(PreReserva preReserva);
        void PagarReserva(TarjetaPrePago tarjetaPrepago, Reserva reserva);
        void CambiarPlanPago(PlanPago planPago, Reserva reserva);
        void GenerarContrato(Reserva reserva, PlanPago planPago);

    }
}
