using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto:VehiculoTerrestre
    {
        
        public int Puertas { get; set; }

        public bool TechoDesc { get; set; }

        public Auto() { }

        public Auto(string modelo, decimal velMax, string motor, string traccion,string tipo, int puertas, bool techoDesc):base(modelo,velmax,motor,traccion,tipo)
        {
            this.Tipo = tipo;
            this.Puertas = puertas;
            this.TechoDesc = techoDesc;
        }
    }
}
