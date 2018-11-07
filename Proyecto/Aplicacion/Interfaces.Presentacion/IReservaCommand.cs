using Aplicacion.Entidades.Presentacion;
using System.Collections.Generic;

namespace Aplicacion.Interfaces.Presentacion
{
    public interface IReservaCommand : IBaseCommand
    {
        List<Reserva> ObtenerReserva(Cliente cliente);
        void ConvertirReserva(PreReserva preReserva);
        void PagarReserva(TarjetaPrePago tarjetaPrepago, Reserva reserva);
        void CambiarPlanPago(PlanPago planPago, Reserva reserva);
        void GenerarContrato(Reserva reserva, PlanPago planPago);

    }
}
