using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace SerializacionBinaria
{
    [Serializable()]
    class Alumno
    {
        public String codigo { get; set; }
        public String apellidos { get; set; }
        public String nombres { get; set; }
        public String email { get; set; }
        public Bitmap foto { get; set; }
    }
}
