using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class ProveedoresElectronicos : IProveedor
    {
        public void EnviarPedido(Pedidos pedido)
        {
            Console.WriteLine("Enviando pedido de productos electrónicos");
        }
    }
}
