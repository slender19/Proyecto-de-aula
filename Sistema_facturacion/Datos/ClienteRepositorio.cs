using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    class ClienteRepositorio : Implementacion<Clientes>
    {
        private static ClienteRepositorio instance= new ClienteRepositorio();
        public ClienteRepositorio()
        {

        }
        internal static ClienteRepositorio Instancce
        {
            get { return instance; }
            set { instance = value; }
        }
        public bool delete(Clientes model)
        {
            var query = "delete from cliente where id_cliente=" + model.id_cliente;
            return Conexion.getInstance().ejecutarQuery(query);
        }

        public Clientes find(int id)
        {
            var query = "select * from cliente where id_cliente=" + id;
            Clientes cliente = new Clientes();
            SqlDataReader reader = Conexion.getInstance().ejecutarQueryLeer(query);

            while (reader.Read())
            {
                cliente.id_cliente = reader.GetInt32(0);
                cliente.NombreCl = reader.GetString(1);
                cliente.Cedula = reader.GetString(2);
                cliente.Telefono = reader.GetString(3);
                
            }

            reader.Close();
            return cliente;
        }

        public List<Clientes> findAll()
        {
            List<Clientes> clientes = new List<Clientes>();
            var query = "select * from cliente";
            SqlDataReader reader = Conexion.getInstance().ejecutarQueryLeer(query);

            while (reader.Read())
            {
                Clientes cliente = new Clientes();
                cliente.id_cliente = reader.GetInt32(0);
                cliente.NombreCl = reader.GetString(1);
                cliente.Cedula = reader.GetString(2);
                cliente.Telefono = reader.GetString(3);
                clientes.Add(cliente);
            }
            reader.Close();
            return clientes;
        }

        public bool save(Clientes model)
        {
            var query = "insert into cliente (nombre,Cedula,Telefono) values ";
            query += "('" + model.NombreCl + "', '" + model.Cedula + "','" + model.Telefono + "', '" +  "')";
            return Conexion.getInstance().ejecutarQuery(query);
        }

        public bool update(Clientes model)
        {
            var query = "update cliente set nombre='" + model.NombreCl + "', Cedula='" + model.Cedula + "',telefono='"  + "' where  id_cliente=" + model.id_cliente;
            return Conexion.getInstance().ejecutarQuery(query);
        }
    }
}
