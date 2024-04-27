using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Clases
{
    public class Pedidos
    {
        public int NumeroPedido { get; set; }
        public string NombreCliente { get; set; }
        public List<Producto> Productos { get; set; }

        public Pedidos(int numeroPedido, string nombreCliente, List<Producto> productos)
        {
            NumeroPedido = numeroPedido;
            NombreCliente = nombreCliente;
            Productos = productos;
        }
    }

    //Para ejemplificar una situacion real
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
    }
}