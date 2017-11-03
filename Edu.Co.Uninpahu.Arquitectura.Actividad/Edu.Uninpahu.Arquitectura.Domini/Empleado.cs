using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Uninpahu.Arquitectura.Domini
{
    public class Empleado
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Direcccion { get; set; }
        public String Cargo { get; set; }
        public String Fijo { get; set; }
        public String Celular { get; set; }

        public Empleado(int id, string nombre, String apellido, String direccion, String cargo, String fijo, String celular) {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direcccion = direccion;
            this.Cargo = cargo;
            this.Fijo = fijo;
            this.Celular = celular;
        }
    }
}
