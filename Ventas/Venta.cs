using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    class Venta
    {
        public String descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }

        public double asignarPrecio()
        {
            /*
            Impresora Inyección 150.00
            Impresora Laser 320.00
            Mouse Óptico 60.00
            Teclado Multimedia 50.00
            */
            if (descripcion == "Impresora Inyección") return 150.00;
            else if (descripcion == "Impresora Laser") return 320.00;
            else if (descripcion == "Mouse Óptico") return 60.00;
            else if (descripcion == "Teclado Multimedia") return 50.00;
            else return 0;
        }

        public double calcularSubtotal()
        {
            return precio * cantidad;
        }

        public double calcularDescuento()
        {
            return calcularSubtotal() * 7.5 / 100;
        }

        public double calcularNeto()
        {
            return calcularSubtotal() - calcularDescuento();
        }
    }
}
