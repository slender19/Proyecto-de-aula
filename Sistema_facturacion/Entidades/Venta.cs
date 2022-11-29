using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public int Id_venta { get; set; }
        public int Numero { get; set; }
        public int Cliente { get; set; }
        public int Usuario { get; set; }
        public DateTime Fecha_venta { get; set; }
        public decimal Total { get; set; }
        public decimal Isv { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }

    }
}
