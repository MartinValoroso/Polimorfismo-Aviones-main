using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviones.Core.Aviones
{
    public class AvionComercial : Avion
    {
        public AvionComercial(string piloto, string copiloto, int capacidad, string lineaAerea) : base(piloto, copiloto)
        {
            Capacidad = capacidad;
            LineaAerea = lineaAerea;
        }

        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }
        public override string Aterriza()
        {
            return "Avion Aterrizando";
        }
        public override string Despegar()
        {
            return "Avion Despegando";
        }
        public override string ToString()
        {
            return $"Piloto: {Piloto}\n" +
                   $"Copiloto: {Copiloto}\n" +
                   $"Capacidad: {Capacidad}\n" +
                   $"LineaAerea: {LineaAerea}";
        }
    }
}
