using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol
{
    class VehiculoCoche : BaseVehiculo 
    {
        public VehiculoCoche () { }

        public VehiculoCoche(int id, string marca, string modelo, int anio, int puertas)
        :base(id, marca, modelo, anio)
        {
            Puertas = puertas;
        }

        public int Puertas {  get; set; }
    }
}
