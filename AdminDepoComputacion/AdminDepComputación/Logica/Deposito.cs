using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Deposito
    {
        List<Producto> Todosproductos;
        List<Monitor> monitores = new List<Monitor>();
        List<Computadora> computadoras = new List<Computadora>();

        public EventHandler notificacionProducto;
        
        public void addProducto(Monitor unMonitor)
        {
            Todosproductos.Add(unMonitor);
            notificacionProducto(unMonitor, new EventArgs());
        }
        
        public void addProducto(Computadora unComputadora)
        {
            Todosproductos.Add(unComputadora);
            notificacionProducto(unComputadora, new EventArgs());
        }

        public void deleteProducto(string _id)
        {
            Producto p = Todosproductos.Find(x => x.id == _id);
            if (p != null)
            {
                Todosproductos.Remove(p);
            }
            notificacionProducto(p, new EventArgs());
        }

        public List<Producto> obtenerListaProductos()
        {
            List<Producto> productos = new List<Producto>();

            productos.AddRange(this.monitores);
            productos.AddRange(this.computadoras);

            return productos.OrderByDescending(x => x is Computadora).ToList();
        }
    }
}
