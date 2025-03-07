using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Wen
{
    internal class Program
    {
        public enum Menu
        {
            AgregarAuto = 1, MostrarAuto, ContarAutos, EliminarAuto, ActualizarAutos, Salir
        }
        
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();

            while (true)
            {
                switch (menu())
                {
                  case Menu.AgregarAuto:
                        acciones.AgregarAuto();
                        break;
                  case Menu.MostrarAuto:
                        acciones.MostrarAutos();
                        break ;
                  case Menu.ContarAutos:
                        Console.WriteLine(acciones.ContarAutos()); 
                        break ;
                  case Menu.EliminarAuto:
                        Console.WriteLine("Que auto quieres borrar?");
                        string marca = Console.ReadLine();
                        acciones.EliminarAuto(marca);
                        break ;
                    case Menu.ActualizarAutos:
                        Console.WriteLine("Que auto quieres actualizar?");
                        string marca1 = Console.ReadLine();
                        acciones.ActualizarAuto(marca1);
                        break ;
                    case Menu.Salir:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opcion NO valida, por favor intente de nuevo");
                        break;
                }
            }


        }

       static Menu menu()
        {
            Console.WriteLine("1) Agregar Auto");
            Console.WriteLine("2) Mostrar Autos");
            Console.WriteLine("3) Contar Autos");
            Console.WriteLine("4) Eliminar Auto");
            Console.WriteLine("5) actualizar Auto");
            Menu opc = (Menu) Convert.ToInt32(Console.ReadLine());
            return opc;
        }
       
    }
}
