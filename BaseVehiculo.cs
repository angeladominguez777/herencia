using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol
{
    class BaseVehiculo 
    {
        public BaseVehiculo () { }
        public BaseVehiculo(int id, string marca, string modelo, int anio)
        {
            ID = id;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public int ID { get; set; }

        public string Marca {  get; set; }

        public string Modelo { get; set; }
        public int Anio { get; set; }

    }
}
