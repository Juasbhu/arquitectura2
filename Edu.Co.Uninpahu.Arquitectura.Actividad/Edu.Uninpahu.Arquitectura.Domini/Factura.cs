using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Uninpahu.Arquitectura.Domini
{
    public class Factura
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }

        public Factura(int id, int idClient, int idEmpleado, DateTime fecha) {
            this.Id = id;
            this.IdClient = idClient;
            this.IdEmpleado = idEmpleado;
            this.Fecha = fecha;
        }
    }
}
