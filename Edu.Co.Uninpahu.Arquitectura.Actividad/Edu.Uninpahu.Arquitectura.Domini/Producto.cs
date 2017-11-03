using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Uninpahu.Arquitectura.Domini
{
    public class Producto
    {
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public int CantidadDisponible { get; set; }
        public float ValorUnitario { get; set; }
        public int PorcentajeIva { get; set; }

        public Producto()
        {

        }

        public Producto(int codigo, String nombre, int cantidad, float valorU, int porcentajeIva)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.CantidadDisponible = cantidad;
            this.ValorUnitario = valorU;
            this.PorcentajeIva = porcentajeIva;
        }
    }
}
