using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Computadora : Producto
    {
        public string descripProcesador { get; set; }
        public Enumenador.MemoriaRam memoriaRam { get; set; }
        public string fabricante { get; set; }

        public Computadora(string modelo, string marca, int numSerie, string descripProcesador, Enumenador.MemoriaRam memoriaRam, string fabricante) : base(modelo, marca, numSerie)
        {
            this.descripProcesador = descripProcesador;
            this.memoriaRam = memoriaRam;
            this.fabricante = fabricante;
        }

        public override string ObtenerDescripcion()
        {
            return $"PC {modelo} - {marca} - {descripProcesador} {memoriaRam} RAM - {fabricante}";
        }
    }
}
