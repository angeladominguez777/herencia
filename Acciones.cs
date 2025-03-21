using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol
{
    internal class Acciones
    {
        private List<VehiculoCoche> lista = new List<VehiculoCoche>();
        VehiculoCoche a = new VehiculoCoche();

        public void AddStudent()
        {
            lista.Add(new VehiculoCoche(a.Nombre,a.Edad,a.Genero,a.Matricula,a.Carrera));
        }
    }
}
