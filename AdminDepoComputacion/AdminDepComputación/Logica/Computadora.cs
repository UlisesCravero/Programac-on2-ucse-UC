using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Computadora : Producto
    {
        public string descripProcesador { get; set; }
        public Enumenador.MemoriaRam memoriaRam { get; set; }
        public string fabricante { get; set; }

        //los guiones no hacen falta
        public Computadora(string _modelo, string _marca, int _numSerie) : base(_modelo, _marca, _numSerie)
        {

        }

        public override string ObtenerDescripcion()
        {
            return $"PC {modelo} - {marca} - {descripProcesador} {memoriaRam} RAM - {fabricante}";
        }
    }
}
