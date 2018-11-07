using Aplicacion.Entidades.Persistencia;
using System.Collections.Generic;

namespace Aplicacion.Interfaces.Persistencia
{
    public interface IPreReservaContext : IDataBaseContext
    {
        List<PreReserva> ObtenerPreReserva(Cliente cliente);
        void EscogerPlanPago(PlanPago planPago, PreReserva prereserva);
        void GuardarNuevaPreReserva(PreReserva preReserva);
        void DarBajaPreReserva(PreReserva preReserva);
        void PagarPrereserva(TarjetaPrePago tarjetaPrePago, PreReserva preReserva);
    }
}
