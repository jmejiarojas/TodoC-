using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoVendedores
{
    class Pago
    {
        public String categoria { get; set; }
        public int horas { get; set; }
        public String vendedor { get; set; }

        public Pago()
        {

        }

        public double asignarCosto()
        {
            if (categoria == "A") return 40;
            else if (categoria == "B") return 30;
            else if (categoria == "C") return 20;
            else if (categoria == "D") return 10;
            else return 0;
        }

        public double calcularSubtotal()
        {
            return horas * asignarCosto();
        }

        public double calcularDescuento()
        {
            return calcularSubtotal() * 0.1;
        }

        public double calcularNeto()
        {
            return calcularSubtotal() - calcularDescuento();
        }
    }
}
