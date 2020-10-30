using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracion
{
    public class Escopeta : Arma
    {
        public override void Disparar()
        {
            Console.WriteLine("Pum! kchk, Pum! kchk, Pum! kchk \n");  
        }
    }
}
