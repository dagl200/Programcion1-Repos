using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracion
{
   public class Rifle : Arma
    {
        public override void Disparar()
        {
            Console.WriteLine("Ta! Ta! Ta! Ta! Ta! \n");
        }
    }
}
