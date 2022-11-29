using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
     class ArticuloRepositorio : Implementacion<Articulo>
    {
        private static ArticuloRepositorio instance= new ArticuloRepositorio();
        public ArticuloRepositorio()
        {

        }
        internal static ArticuloRepositorio Instance 
        {
            get { return instance; }
            set { instance = value; }
        }
        public bool delete(Articulo model)
        {
            var query = "delete from Articulo where id_Articulo=" + model.id_Articulo;
            return Conexion.getInstance().ejecutarQuery(query);
        }

        public Articulo find(int id)
        {
            Articulo producto = new Articulo();
            SqlDataReader reader = Conexion.getInstance().ejecutarQueryLeer("select * from Articulo where id_Articulo=" + id);

            while (reader.Read())
            {
                producto.id_Articulo = reader.GetInt32(0);
                producto.Nombre_Art = reader.GetString(1);
                producto.Tipo = reader.GetString(2);
                producto.Talla = reader.GetString(3);
                producto.Marca= reader.GetString(4);
                producto.cant_bodega = reader.GetInt32(5);
                producto.cantMin = reader.GetInt32(6);
                producto.cantMax = reader.GetInt32(7);
                producto.Precio_Venta = reader.GetDecimal(8);
                producto.Precio_Compra = reader.GetDecimal(9);

            }
            reader.Close();
            return producto;
        }

        public List<Articulo> findAll()
        {
            List<Articulo> articulos = new List<Articulo>();

            SqlDataReader reader = Conexion.getInstance().ejecutarQueryLeer("select * from Articulo");

            while (reader.Read())
            {
                Articulo producto = new Articulo();
                producto.id_Articulo = reader.GetInt32(0);
                producto.Nombre_Art = reader.GetString(1);
                producto.Tipo = reader.GetString(2);
                producto.Talla = reader.GetString(3);
                producto.Marca = reader.GetString(4);
                producto.cant_bodega = reader.GetInt32(5);
                producto.cantMin = reader.GetInt32(6);
                producto.cantMax = reader.GetInt32(7);
                producto.Precio_Venta = reader.GetDecimal(8);
                producto.Precio_Compra = reader.GetDecimal(9);
                articulos.Add(producto);
            }
            reader.Close();
            return articulos;
        }

        public bool save(Articulo model)
        {
            String query = "insert into Articulo (nombre,Tipo,Talla,Marca,Cant_bodega, cantMin, cantMax, Precio_Venta, Precio_Compra) values "
                + " ('" + model.Nombre_Art + "','" + model.Tipo + "','" + model.Talla + "','" + model.Marca + "','" + model.cant_bodega + "','" + model.cantMin + "','" + model.cantMax + "','" +model.Precio_Venta+ "','" +model.Precio_Compra+ "')";

            return Conexion.getInstance().ejecutarQuery(query);
        }

        public bool update(Articulo model)
        {
            String query = "update Articulo set nombre='" + model.Nombre_Art + "',precio_compra='" + model.Precio_Compra + "',precio_venta='" + model.Precio_Venta + "',Talla='" + model.Talla + "',minimo='" + model.cantMin + "',maximo='" + model.cantMax + "',tipo='" + model.Tipo +"',Marca='"+model.Marca +"',Cant_bodega='"+model.cant_bodega+"' where id_producto=" + model.id_Articulo;
            return Conexion.getInstance().ejecutarQuery(query);
        }
    }
}
