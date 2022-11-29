using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo
    {
        public Articulo()
        {

        }
        public int id_Articulo { get; set; }
        public string Nombre_Art { get; set; }
        public string Tipo { get; set; }
        public string Talla { get; set; }
        public string Marca { get; set; }
        public int cant_bodega { get; set; }
        public int cantMin { get; set; }
        public int cantMax { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal Precio_Compra { get; set; }
    }
}
