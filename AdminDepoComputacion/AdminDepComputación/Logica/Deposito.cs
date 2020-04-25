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
        
        public void addProducto(Monitor unMonitor)
        {
            // evento
            produrctos.Add(unMonitor);
        }

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

        public List<string> obtenerListaProductos()
        {
            List<string> productosOrdenados = new List<string>();
            produrctos.ForEach(unProducto => productosOrdenados.Add(unProducto.ObtenerDescripcion()));
            productosOrdenados.Sort();
            return productosOrdenados;
        }
    }
}
