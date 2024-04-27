using Examen2;

class Program
{
    static void Main(string[] args)
    {
        ProveedoresElectronicos proveedorElectronica = new ProveedoresElectronicos();
        ProveedoresRopa proveedorRopa = new ProveedoresRopa();

        GestorPedidos gestorPedidos = new GestorPedidos();

        Pedidos pedidoElectronica = new Pedidos();
        gestorPedidos.EnviarPedidoSegunTipoProducto(pedidoElectronica, proveedorElectronica);

        Pedidos pedidoRopa = new Pedidos();
        gestorPedidos.EnviarPedidoSegunTipoProducto(pedidoRopa, proveedorRopa);

        Console.ReadLine();
    }
}