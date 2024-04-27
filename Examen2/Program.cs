using Examen2.Clases;

class Program
{
    static void Main(string[] args)
    {
        ProveedoresElectronicos proveedorElectronica = new ProveedoresElectronicos();
        ProveedoresRopa proveedorRopa = new ProveedoresRopa();

        GestorPedidos gestorPedidos = new GestorPedidos();

        Pedidos pedidoElectronica = new Pedidos(1, "ClienteElectronica", new List<Producto>
        {
            new Producto { Nombre = "Smartphone", Precio = 500 },
            new Producto { Nombre = "Laptop", Precio = 1200 }
        });

        Console.WriteLine("Pedido de productos electrónicos:");
        Console.WriteLine($"Número de pedido: {pedidoElectronica.NumeroPedido}");
        Console.WriteLine($"Cliente: {pedidoElectronica.NombreCliente}");
        Console.WriteLine("Productos:");
        foreach (var producto in pedidoElectronica.Productos)
        {
            Console.WriteLine($"- {producto.Nombre}: ${producto.Precio}");
        }

        gestorPedidos.EnviarPedidoSegunTipoProducto(pedidoElectronica, proveedorElectronica);



        Pedidos pedidoRopa = new Pedidos(2, "ClienteRopa", new List<Producto>
        {
            new Producto { Nombre = "Camisa", Precio = 40 },
            new Producto { Nombre = "Pantalón", Precio = 60 }
        });

        Console.WriteLine("\nPedido de productos de ropa:");
        Console.WriteLine($"Número de pedido: {pedidoRopa.NumeroPedido}");
        Console.WriteLine($"Cliente: {pedidoRopa.NombreCliente}");
        Console.WriteLine("Productos:");
        foreach (var producto in pedidoRopa.Productos)
        {
            Console.WriteLine($"- {producto.Nombre}: ${producto.Precio}");
        }

        gestorPedidos.EnviarPedidoSegunTipoProducto(pedidoRopa, proveedorRopa);

        Console.ReadLine();
    }
}