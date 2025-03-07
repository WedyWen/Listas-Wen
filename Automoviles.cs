using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Wen
{
    internal class Automoviles
    {
        public Automoviles(string marca, string modelo, int anio, int noPuertas, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            NoPuertas = noPuertas;
            Color = color;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int NoPuertas { get; set; }
        public string Color { get; set; }

        public Automoviles() { }
        
    }
}
