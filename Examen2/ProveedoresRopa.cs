using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class ProveedoresRopa : IProveedor
    {
        public void EnviarPedido(Pedidos pedido)
        {
            Console.WriteLine("Enviando pedido de productos de ropa");
        }
    }
}
