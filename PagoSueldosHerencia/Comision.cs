using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoSueldosHerencia
{
    class Comision:Empleado
    {
        public double montoVendido { get; set; }

        public double calculaSueldo()
        {
            double sueldo = montoVendido * 0.1;
            if (calculaAniosServicios() < 3)
            {
                return sueldo + 200;
            }
            else
            {
                return sueldo;
            }
        }
    }
}
