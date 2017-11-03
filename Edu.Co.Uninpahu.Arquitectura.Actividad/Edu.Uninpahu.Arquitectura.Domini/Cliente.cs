using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Uninpahu.Arquitectura.Domini
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Fijo { get; set; }
        public String Celular { get; set; }

        public Cliente(int id, String nombre, String apellido, String fijo, String celular) {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fijo = fijo;
            this.Celular = celular;
        }

        public Cliente()
        {
        }
    }
}
