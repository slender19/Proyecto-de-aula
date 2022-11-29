using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
     class Descripcion_ventaRepositorio:Implementacion<Descripcion_venta>
    {
        private static Descripcion_ventaRepositorio instance = new Descripcion_ventaRepositorio();

        public Descripcion_ventaRepositorio()
        {

        }
        internal static Descripcion_ventaRepositorio Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public bool delete(Descripcion_venta model)
        {
            throw new NotImplementedException();
        }

        public Descripcion_venta find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Descripcion_venta> findAll()
        {
            throw new NotImplementedException();
        }
        public bool save(List<Descripcion_venta> models)
        {
            foreach (Descripcion_venta venta in models)
            {
                save(venta);
            }

            return true;
        }

        public bool save(Descripcion_venta model)
        {
            var query = "insert into descripcion_factura (producto,cantidad,factura,precio) values ";
            query += " (" + model.Articulo + ", " + model.Cantidad + ", " + model.Venta + ", " + model.Precio.ToString().Replace(",", ".") + ")";

            return Conexion.getInstance().ejecutarQuery(query);
        }

        public bool update(Descripcion_venta model)
        {
            throw new NotImplementedException();
        }
        public int vendido(int articulo)
        {
            int vendido = 0;
            var query = "select p.id_Articulo, sum(d.cantidad) as Existencia from Articulo p inner join descripcion_factura d on p.id_Articulo = d.Articulo group by p.id_Articulo having p.id_Articulo =" + articulo;
            SqlDataReader reader = Conexion.getInstance().ejecutarQueryLeer(query);

            while (reader.Read())
            {
                vendido = reader.GetInt32(1);
            }

            reader.Close();
            return vendido;
        }
    }
}
