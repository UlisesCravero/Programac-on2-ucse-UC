using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Deposito
    {
        List<Producto> produrctos;
        
        //Este metodo agrega al listado pero no publica evento
        public void addProducto(Monitor unMonitor)
        {
            // evento
            produrctos.Add(unMonitor);
        }
        //Este metodo agrega al listado pero no publica evento
        public void addProducto(Computadora unComputadora)
        {
            // evento
            produrctos.Add(unComputadora);
        }

        public void deleteProducto(string _id)
        {
            Producto p = produrctos.Find(x => x.id == _id);
            if (p != null)
            {
                produrctos.Remove(p);
            }
        }

        //Debe retornar una lista de objetos, como por ejemplo List<Producto>
        public List<string> obtenerListaProductos()
        {
            List<string> productosOrdenados = new List<string>();
            produrctos.ForEach(unProducto => productosOrdenados.Add(unProducto.ObtenerDescripcion()));
            productosOrdenados.Sort();
            return productosOrdenados;
        }
    }
}
