using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public TipoDeProducto tipo { get; set; }
        public double precio { get; set; }
        public Tamanio tamanio { get; set; }
        public int stock { get; set; }
        public Producto(int Id, string Descripcion, TipoDeProducto Tipo, double Precio, Tamanio Tam, int Stock)
        {
            id = Id;
            descripcion = Descripcion;
            tipo = Tipo;
            precio = Precio;
            tamanio = Tam;
            stock = Stock;
        }
    }
}
