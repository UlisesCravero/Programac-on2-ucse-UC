using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Monitor : Producto
    {
        private int anioFabricacion { get; set; }
        private int? pulgadas { get; set; }

        public Monitor(string _modelo, string _marca, int _numSerie, int _anioFabricacion, int _pulgadas ) : base(_modelo, _marca, _numSerie)
        {
            this.anioFabricacion = _anioFabricacion;
            this.pulgadas = _pulgadas;
        }

        public bool esNuevo()
        {
            return anioFabricacion == DateTime.Now.Year;
        }

        public override string ObtenerDescripcion()
        {
            return $"Monitor {marca} - {modelo} - {pulgadas}";
        }
    }
}
