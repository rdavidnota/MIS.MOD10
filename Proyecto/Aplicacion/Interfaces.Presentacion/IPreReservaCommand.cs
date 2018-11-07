using Aplicacion.Entidades.Presentacion;
using System.Collections.Generic;

namespace Aplicacion.Interfaces.Presentacion
{
    public interface IPreReservaCommand : IBaseCommand
    {
        List<PreReserva> ObtenerPreReserva(Cliente cliente);
        void EscogerPlanPago(PlanPago planPago, PreReserva prereserva);
        void GuardarNuevaPreReserva(PreReserva preReserva);
        void DarBajaPreReserva(PreReserva preReserva);
        void PagarPrereserva(TarjetaPrePago tarjetaPrePago, PreReserva preReserva);
    }
}
