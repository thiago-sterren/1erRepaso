using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Consola2
{
    public class Program
    {
        static void Main(string[] args)
        {
            TipoDeProducto herramienta = new TipoDeProducto(1, "Herramienta");
            TipoDeProducto insumo = new TipoDeProducto(2, "Insumo");
            TipoDeProducto electricidad = new TipoDeProducto(3, "Electricidad");
            Tamanio grande = new Tamanio(1, "Grande");
            Tamanio mediano = new Tamanio(2, "Mediano");
            Tamanio chico = new Tamanio(3, "Chico");
            Producto producto1 = new Producto(1, "Martillo", herramienta, 1000, grande, 10);
            Producto producto2 = new Producto(2, "Destornillador", herramienta, 800, mediano, 8);
            Cliente cliente1 = new Cliente(45953027, "thiagosterren@gmail.com", "Thiago Sterren");
            List<(Producto, int)> lista1 = new List<(Producto, int)>();
            lista1.Add((producto1, 8));
            lista1.Add((producto2, 2));
            Venta venta1 = new Venta(cliente1, DateTime.Now, lista1);
            Console.WriteLine(venta1.id);
            Console.WriteLine(venta1.cliente_venta.nombre);
            Console.WriteLine(venta1.fecha);
            foreach (var item in venta1.lista_productos)
            {
                Console.WriteLine(item.Item1.descripcion);
                Console.WriteLine(item.Item2);
            }
            Console.WriteLine("Total $" + venta1.precio_total);
            Console.ReadLine();
        }
    }
}
