using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Deposito
    {
        List<Producto> produrctos;

        public EventHandler notificacionProducto;
        
        //Este metodo agrega al listado pero no publica evento
        public void addProducto(Monitor unMonitor)
        {
            produrctos.Add(unMonitor);
            notificacionProducto(unMonitor, new EventArgs());
        }
        //Este metodo agrega al listado pero no publica evento
        public void addProducto(Computadora unComputadora)
        {
            produrctos.Add(unComputadora);
            notificacionProducto(unComputadora, new EventArgs());
        }

        public void deleteProducto(string _id)
        {

            Producto p = produrctos.Find(x => x.id == _id);
            if (p != null)
            {
                produrctos.Remove(p);
            }
            notificacionProducto(p, new EventArgs());
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
