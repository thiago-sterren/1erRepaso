﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Tamanio
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public Tamanio(int Id, string Nombre)
        {
            id = Id;
            nombre = Nombre;
        }
    }
}
