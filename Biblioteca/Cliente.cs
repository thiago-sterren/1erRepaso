using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        public int dni { get; set; }
        public string email { get; set; }
        public string nombre { get; set; }
        public Cliente(int Dni, string Email, string Nombre)
        {
            dni = Dni;
            email = Email;
            nombre = Nombre;
        }
    }
}
