using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoSueldosHerencia
{
    class Empleado
    {
        public String codigo { get; set; }
        public String nombres { get; set; }
        public DateTime fechaIngreso { get; set; }
        public String telefono { get; set; }

        public int calculaAniosServicios()
        {
            return DateTime.Today.Year - fechaIngreso.Year;
        }
    }
}
