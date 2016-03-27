using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectraSAC
{
    class Venta
    {
        public  DateTime fecha { get; set; }
        public double monto { get; set; }
        public String numVenta { get; set; }

        public double calculaDescuento()
        {
            return monto * 0.1;
        }

        //Este metodo se va a sobreescribir en las clases hijas
        public virtual double calculaNeto()
        {
            return monto - calculaDescuento();
        }
    }
}
