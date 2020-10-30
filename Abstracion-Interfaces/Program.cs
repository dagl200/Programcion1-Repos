using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracion
{
    class TestArma
    {
        static void Main(string[] args)
        {
            /* Arma Pistola = new Arma();
            Pistola.Modelo = Modelo.Colt;
            Pistola.año = 1911;
            Pistola.Tipo = "Pistola";
            */
            Rifle Rifle = new Rifle();
            Rifle.Modelo = Modelo.AK;
            Rifle.año = 47;
            Rifle.Tipo = "Rifle";

            Escopeta Shotgun = new Escopeta();
            Shotgun.año = 870;
            Shotgun.Modelo = Modelo.Remington;
            Shotgun.Tipo = "Shotgun";

            List<Arma> Gun = new List<Arma>();
            //Gun.Add(Pistola);
            Gun.Add(Rifle);
            Gun.Add(Shotgun);

            foreach (var Clase in Gun)
            {
                Console.WriteLine($"{Clase.Tipo} : {Clase.Modelo} {Clase.año}");
                Clase.Disparar();
                
            }

            Console.ReadKey();
        }
    }
}
