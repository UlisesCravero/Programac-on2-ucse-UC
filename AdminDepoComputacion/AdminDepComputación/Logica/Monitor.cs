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

        public Monitor(string _modelo, string _marca, int _numSerie, int _anioFabricacion, int _pulgadas ) : base(_modelo, _marca, _numSerie)
        {
            this.anioFabricacion = _anioFabricacion;
            this.pulgadas = _pulgadas;
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
