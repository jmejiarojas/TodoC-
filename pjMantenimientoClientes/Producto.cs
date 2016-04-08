using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjMantenimientoClientes
{
    public class Producto
    {
        public String codigo { get; set; }
        public String descripcion { get; set; }
        public string categoria { get; set; }
        public DateTime fecha { get; set; }
        public int stock { get; set; }
        public double precio { get; set; }
    }
}
