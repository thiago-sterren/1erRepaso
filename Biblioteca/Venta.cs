using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Venta
    {
        public int id { get; set; }
        public Cliente cliente_venta { get; set; }
        public DateTime fecha { get; set; }
        public double precio_total { get; set; }
        public List<(Producto, int)> lista_productos { get; set; }
        public double CalcularMonto()
        {
            double resultado_por_item = 0;
            double total = 0;
            foreach (var item in lista_productos)
            {
                resultado_por_item = item.Item2 * item.Item1.precio;
                total += resultado_por_item;
            }
            return total;
        }
        public Venta(Cliente CV, DateTime Fecha, List<(Producto, int)> Lista)
        {
            cliente_venta = CV;
            fecha = Fecha;
            lista_productos = Lista;
            precio_total = CalcularMonto();
        }
    }
}
