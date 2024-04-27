using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Interfaces;

namespace Examen2.Clases
{
    public class GestorPedidos
    {
        public void EnviarPedidoSegunTipoProducto(Pedidos pedido, IProveedor proveedor)
        {
            proveedor.EnviarPedido(pedido);
        }
    }
}
