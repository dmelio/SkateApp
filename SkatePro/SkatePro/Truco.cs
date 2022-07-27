using System;
using System.Collections.Generic;
using System.Text;

namespace SkatePro
{
    public class Truco
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Nvldificultad { get; set; }
        public string Comohacer { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

    }
    

}
