using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracion
{
     public  abstract class Arma
    {
        public Modelo Modelo { get; set; }
        public int año { get; set; }
        public string Tipo { get; set; }

         public virtual void Disparar()
        {
            Console.WriteLine("Pew! Pew! \n");
        }
    }
}
