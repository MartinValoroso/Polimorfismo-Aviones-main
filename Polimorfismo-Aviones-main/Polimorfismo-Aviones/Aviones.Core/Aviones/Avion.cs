using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviones.Core.Aviones
{
    public abstract class Avion
    {
        protected Avion(string piloto, string copiloto)
        {
            Piloto = piloto;
            Copiloto = copiloto;
        }

        public string Piloto { get; set; }
        public string Copiloto { get; set; }

        public abstract string Despegar();
        public abstract string Aterriza();

        public virtual string VerPropiedades()
        {
            return $"Piloto: {Piloto}\n" +
                   $"Copiloto: {Copiloto}";
        }
    }
}
