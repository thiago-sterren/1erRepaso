using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class TipoDeProducto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public TipoDeProducto(int Id, string Nombre)
        {
            id = Id;
            nombre = Nombre;
        }
    }
}
