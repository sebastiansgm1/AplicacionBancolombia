using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Net;
using System.Windows;


namespace Datos
{
    public class DbContexto : DataContext
    {
        public DbContexto(string connectionString)
            :base(connectionString)
        {

        }

        public Table<TablaUsuario> Usuarios
        {
            get
            {
                return this.GetTable<TablaUsuario>();
            }
        }

        public Table<TablaProducto> Productos
        {
            get
            {
                return this.GetTable<TablaProducto>();
            }
        }
    }
}
