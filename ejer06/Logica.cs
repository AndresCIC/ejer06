﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer06
{
    public class Logica
    {
        /**
         * Receive data object and return them concatenated 
         **/
        public String Datos(Datos d)
        {
            String datosString = d.texto + d.numero + d.otroNumero;

            return datosString;
        }


    }
}
