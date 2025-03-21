using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol
{
    internal class ControllerVehiculo
    {
        Dictionary<int, VehiculoCoche> diccionariocoche = new Dictionary<int, VehiculoCoche> ();
        Dictionary<int, VehiculoCamion> diccionariocamion = new Dictionary<int, VehiculoCamion>();
        VehiculoCamion vca = new VehiculoCamion ();
        VehiculoCoche vco = new VehiculoCoche ();

        public void AddCoche()
        {
            Console.WriteLine("Dame matrícula:");
            int id = Convert.ToInt32(Console.ReadLine());

            diccionariocoche.Add(id, new VehiculoCoche(vco.ID, vco.Marca, vco.Modelo, vco.Anio, vco.Puertas));
        }

        public void AddCamion()
        {
            Console.WriteLine("Dame matrícula:");
            int id = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Add(id, new VehiculoCamion(vca.ID, vca.Marca, vca.Modelo, vca.Anio, vca.CapacidadCarga));
        }

        public void LeerCoche()
        {
            foreach (var coch in diccionariocoche)
            {
                Console.WriteLine($"ID: {coch.Value.ID}");
                Console.WriteLine($"Marca: {coch.Value.Marca}");
                Console.WriteLine($"Modelo: {coch.Value.Modelo}");
                Console.WriteLine($"Año: {coch.Value.Anio}");
                Console.WriteLine($"Puertas: {coch.Value.Puertas}");
            }
        }

        public void LeerCamion()
        {
            foreach (var cam in diccionariocamion)
            {
                Console.WriteLine($"ID: {cam.Value.ID}");
                Console.WriteLine($"Marca: {cam.Value.Marca}");
                Console.WriteLine($"Modelo: {cam.Value.Modelo}");
                Console.WriteLine($"Año: {cam.Value.Anio}");
                Console.WriteLine($"Capacidad: {cam.Value.CapacidadCarga}");
            }
        }

        public void EliminarCoche()
        {
            Console.WriteLine("Dame id para eliminar");
            int id = Convert.ToInt32(Console.ReadLine());

            diccionariocoche.Remove(id);
        }

        public void EliminarCamion()
        {
            Console.WriteLine("Dame id para eliminar");
            int id = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Remove(id);
        }

        public void ActualizarCoche()
        {

        }
    }
}
