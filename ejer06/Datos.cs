using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer06
{
    public class Datos
    {
        //Data definition
        public string texto { get; private set; }
        public int numero { get; private set; }
        public int otroNumero { get; private set; }

        //Constructor
        public Datos(string v1, int v2, int v3)
        {
            this.texto = v1;
            this.numero = v2;
            this.otroNumero = v3;
        }

    }
}
