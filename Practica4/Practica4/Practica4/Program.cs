using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Practica4
{
    public sealed class Palabra
    {
        public string elString { get; set; }
    }

    public static class Extension
    {
        public static int CantidadPalabras(string p)
        {
            int resultado = p.Split(' ').Length;
            return resultado;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Palabra unaPalabra = new Palabra();
            unaPalabra.elString = Console.ReadLine();
            Console.WriteLine(Extension.CantidadPalabras(unaPalabra.elString));




            Console.ReadLine();
        }
    }
}
