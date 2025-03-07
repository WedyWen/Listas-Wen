using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Wen
{
    internal class Acciones
    {
        public List<Automoviles> Listaautomoviles = new List<Automoviles>();
        Automoviles a = new Automoviles();

        public void AgregarAuto()
        {

            Console.WriteLine("Marca");
            a.Marca = Console.ReadLine();

            Console.WriteLine("Modelo");
            a.Modelo = Console.ReadLine();

            Console.WriteLine("Año");
            a.Anio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numero de puertas");
            a.NoPuertas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Color");
            a.Color = Console.ReadLine();

            Listaautomoviles.Add(new Automoviles(a.Marca, a.Modelo, a.Anio, a.NoPuertas, a.Color));
            Console.WriteLine("Auto agregado correctamente");

        }
        public void MostrarAutos()
        {
            foreach (var p in Listaautomoviles)
            {
                Console.WriteLine($"Marca: {p.Marca}");
                Console.WriteLine($"Modelo: {p.Modelo}");
                Console.WriteLine($"Año: {p.Anio}");
                Console.WriteLine($"Numero de puertas: {p.NoPuertas}");
                Console.WriteLine($"Color: {p.Color}");
            }
        }

        public int ContarAutos()
        {
            return Listaautomoviles.Count;
        }

        public void EliminarAuto(string nombremarca)
        {
            var automovil = Listaautomoviles.Find(x => x.Marca == nombremarca);
            if (automovil != null)
            {
                Listaautomoviles.Remove(automovil);
                Console.WriteLine("Se elimino con exito");
            }
            else { Console.WriteLine("No se encontró tu automovil"); }
        }

        
           public void ActualizarAuto(string nombremarca)
        {
            var automovil = Listaautomoviles.FirstOrDefault(x => x.Marca == nombremarca);
            if (automovil != null)
            {
                Console.WriteLine("Ingrese los nuevos datos del automóvil:");

                Console.WriteLine("Nueva Marca:");
                automovil.Marca = Console.ReadLine();

                Console.WriteLine("Nuevo Modelo:");
                automovil.Modelo = Console.ReadLine();

                Console.WriteLine("Nuevo Año:");
                automovil.Anio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nuevo Número de puertas:");
                automovil.NoPuertas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nuevo Color:");
                automovil.Color = Console.ReadLine();

                Console.WriteLine("Automóvil actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró el automovil");
            }
        }

    }
}

