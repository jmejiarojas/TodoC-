using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoSueldosHerencia
{
    class Asalariado:Empleado
    {
        public double bruto { get; set; }

        public Asalariado()
        {
            bruto = 1200;
        }

        public double calculaDescuento()
        {
            return bruto * 0.1;
        }

        public double calcularNeto()
        {
            return bruto - calculaDescuento();
        }
    }
}
