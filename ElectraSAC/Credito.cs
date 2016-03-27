using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectraSAC
{
    class Credito: Venta
    {
        public int numLetras { get; set; }

        public double calculaMontoMensual()
        {
            return calculaNeto() / numLetras;
        }

        private double asignarPorcentaje()
        {
            if (numLetras == 3) return 0.2;
            else if (numLetras == 6) return 0.4;
            else if (numLetras == 9) return 0.6;
            else if (numLetras == 12) return 0.8;
            else return 0;
        }

        //Este metodo me calcula el TotalNeto mas el credito
        public override double calculaNeto()
        {
            return monto + monto * asignarPorcentaje();
        }
    }
}
