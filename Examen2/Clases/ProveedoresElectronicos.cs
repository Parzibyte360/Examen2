using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Interfaces;

namespace Examen2.Clases
{
    public class ProveedoresElectronicos : IProveedor
    {
        public void EnviarPedido(Pedidos pedido)
        {
            Console.WriteLine("Enviando pedido de productos electrónicos");
        }
    }
}
