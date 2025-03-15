using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol
{
    internal class Acciones
    {
        private List<Alumno> lista = new List<Alumno>();
        Alumno a = new Alumno();

        public void AddStudent()
        {
            lista.Add(new Alumno(a.Nombre,a.Edad,a.Genero,a.Matricula,a.Carrera));
        }
    }
}
