using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Uninpahu.Arquitectura.Domini
{
    public class D_Factura
    {
        public int NumDFactura { get; set; }
        public int NumFactura { get; set; }
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public float Valor { get; set; }
        public float Subtotal { get; set; }

        public D_Factura(int numDFactura, int numFactura, int codigo, int cantidad, float valor, float subtotal)
        {
            this.NumDFactura = numDFactura;
            this.NumFactura = numFactura;
            this.Codigo = codigo;
            this.Valor = valor;
            this.Subtotal = subtotal;
        }
    }
}
