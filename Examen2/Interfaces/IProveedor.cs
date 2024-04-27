using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Clases;

namespace Examen2.Interfaces
{
    public interface IProveedor
    {
        public void EnviarPedido(Pedidos pedido);
    }
}
