using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace AdminDepComputación
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void notificacionEventoProducto(Object producto, EventArgs e)
        {
            if (producto is Monitor)
            {
                Monitor unMonitor = producto as Monitor;
                Console.WriteLine($"Producto eliminado/eliminado - {unMonitor.ObtenerDescripcion()}");
            }
            else
            {
                Computadora unaComputadora = producto as Computadora;
                Console.WriteLine($"Producto eliminado/eliminado - {unaComputadora.ObtenerDescripcion()}");
            }
        }
    }
}
