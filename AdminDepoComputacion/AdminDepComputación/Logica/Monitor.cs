using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Monitor : Producto
    {
        private int anioFabricacion { get; set; }
        private int? pulgadas { get; set; }

        public Monitor(string modelo, string marca, int numSerie, int anioFabricacion, int pulgadas ) : base(modelo, marca, numSerie)
        {
            this.anioFabricacion = anioFabricacion;
            this.pulgadas = pulgadas;
        }
        //podria ser una propiedad de solo lectura tambien
        public bool esNuevo()
        {
            return anioFabricacion == DateTime.Now.Year;
        }
        //podria ser una propiedad de solo lectura tambien
        public override string ObtenerDescripcion()
        {
            return $"Monitor {marca} - {modelo} - {pulgadas}";
        }
    }
}
