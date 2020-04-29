using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Producto
    {
        protected string modelo { get; set; }
        protected string marca { get; set; }
        protected int numSerie { get; set; }
        public string id { get; } 


    
        public Producto(string _modelo, string _marca, int _numSerie)
        {
            this.modelo = _modelo;
            this.marca = _marca;
            this.numSerie = _numSerie;
            this.id = _modelo + _marca + _numSerie;
        }

        public abstract string ObtenerDescripcion();
    }
}
