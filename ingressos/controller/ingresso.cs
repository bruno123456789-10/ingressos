using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingressos.controller
{
    internal class ingresso
    {
        int resul;
        
        public decimal Calcular(int valor, int qntd)
        {


            int resul = valor * qntd;


            return resul;
        }
    }
}
