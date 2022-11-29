using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Descripcion_venta
    {
        public Descripcion_venta()
        {

        }

        public int Id_Descripcion { get; set; }
        public int Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Venta { get; set; }
        public decimal Precio { get; set; }

    }
}
