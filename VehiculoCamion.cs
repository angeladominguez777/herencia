using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace arbol
{
    internal class VehiculoCamion : BaseVehiculo
    {
        public VehiculoCamion() { }
        public VehiculoCamion(int id, string marca, string modelo, int anio, int capacidadCarga)
        :base(id,  marca, modelo, anio)
        {
            CapacidadCarga = capacidadCarga;
        }

        public int CapacidadCarga { get; set; }
    }
}
