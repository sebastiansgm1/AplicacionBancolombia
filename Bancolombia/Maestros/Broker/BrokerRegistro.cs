using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Entidades.Maestros;
using System.IO.IsolatedStorage;
using System.Data.Linq.Mapping;
using Datos;
using System.Linq;
using Maestros.Fachada;
using System.Collections.Generic;
using System.Data.Linq;

namespace Maestros.Broker
{
    public class BrokerRegistro
    {
        public static int EliminarUsr(EntidadLogin ojbusuarios)
        {
            int valor = 0;
            using (DbContexto contexto = new DbContexto("Data Source='isostore:/BancolombiaDb.sdf'"))
            {

                var query = from TablaTmpUsuario in contexto.Usuarios
                            where TablaTmpUsuario.NombreUsuario == ojbusuarios.NombreUsuario
                            select TablaTmpUsuario;
                if (query.ToList().Count > 0)
                {
                    valor = 1;
                }

                foreach (var usr in query)
                    {
                    contexto.Usuarios.DeleteOnSubmit(usr);
                    }
                
                try
                    {
                    contexto.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                    throw ex;
                    }
            }
            return valor;

        }

       public static int CrearCta(EntidadProducto objproducto, EntidadLogin objusuarios, string usuario)
        {
            int valor = 0;
            using (DbContexto contexto = new DbContexto("Data Source = 'isostore:/BancolombiaDb.sdf'"))
            {
                var query = from TablaTmpProducto in contexto.Productos.ToList() // TablaTmpUsuario Es una tabla de tipo contexto.Usuarios 
                            orderby TablaTmpProducto.NumeroCuenta
                            where TablaTmpProducto.NumeroCuenta == objproducto.NumeroCuenta
                            select TablaTmpProducto.NumeroCuenta;

               /* var query2 = from TablaTmpUsuario in contexto.Usuarios.ToList()
                             orderby TablaTmpUsuario.NombreUsuario
                             where TablaTmpUsuario.NombreUsuario == usuario
                             select TablaTmpUsuario.NombreUsuario;*/

                if (query.ToList().Count > 0)
                {
                    valor = 2;
                }
                else
                {
                    List<TablaProducto> TablaTmpUsuario = new List<TablaProducto>()
                    {
                        new TablaProducto()
                        {
                            NumeroCuenta = objproducto.NumeroCuenta,
                            Producto = objproducto.Producto,
                            Saldo = objproducto.Saldo,
                            Usuario = usuario
                        }
                    };
                    valor = 1;
                    contexto.Productos.InsertAllOnSubmit(TablaTmpUsuario);
                    contexto.SubmitChanges();
                }

            }
            return valor;

        }

        public static string ConsultarCta(EntidadProducto objproducto, int n)
        {
            int _NumeroCuenta = 0;
            //string _Usuario = string.Empty;
            string _Producto = string.Empty;
            float _Saldo = 0;


            string valor = string.Empty;

            using (DbContexto contexto = new DbContexto("Data Source='isostore:/BancolombiaDb.sdf'"))
            {

                List<Datos.TablaProducto> query = (from TablaTmpProducto in contexto.Productos.ToList() // TablaTmpUsuario Es una tabla de tipo contexto.Usuarios 
                                                   orderby TablaTmpProducto.NumeroCuenta
                                                   where TablaTmpProducto.NumeroCuenta == objproducto.NumeroCuenta
                                                   select new Datos.TablaProducto
                                                   {
                                                       NumeroCuenta = TablaTmpProducto.NumeroCuenta,
                                                       Usuario = TablaTmpProducto.Usuario,
                                                       Producto = TablaTmpProducto.Producto,
                                                       Saldo = TablaTmpProducto.Saldo

                                                   }).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var item in query)
                    {
                        _NumeroCuenta = item.NumeroCuenta;
                        _Producto = item.Producto;
                        _Saldo = item.Saldo;
                       // _Usuario = item.Usuario;
                    }
                }
                else
                {
                    valor = "N";
                }


            }
            if(n == 1)
            {
                valor = Convert.ToString(_NumeroCuenta);
            }
            if (n == 2)
            {
                valor = _Producto;
            }
            if (n == 3)
            {
                valor = Convert.ToString(_Saldo);
            }
            /*if (n == 4)
            {
                valor = _Usuario; 
            }*/

            return valor;
        }

        public static int EliminarCta(EntidadProducto objproducto)
        {
            int valor = 0;
            using (DbContexto contexto = new DbContexto("Data Source='isostore:/BancolombiaDb.sdf'"))
            {

                var query = from TablaTmpProducto in contexto.Productos
                            where TablaTmpProducto.NumeroCuenta == objproducto.NumeroCuenta
                            select TablaTmpProducto;
                if (query.ToList().Count > 0)
                {
                    valor = 1;
                }

                foreach (var prod in query)
                {
                    contexto.Productos.DeleteOnSubmit(prod);
                }

                try
                {
                    contexto.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return valor;

        }

       public static int ModificarCta(EntidadProducto objproducto)
        {
            int valor = 0;
            using (DbContexto contexto = new DbContexto("Data Source='isostore:/BancolombiaDb.sdf'"))
            {

                var query = (from TablaTmpProducto in contexto.Productos
                            where TablaTmpProducto.NumeroCuenta == objproducto.NumeroCuenta
                            select TablaTmpProducto).First();
                var query2 = (from TablaTmpProducto in contexto.Productos
                             where TablaTmpProducto.NumeroCuenta == objproducto.NumeroCuenta
                             select TablaTmpProducto).ToList();
                if (query2.ToList().Count > 0)
                {
                    valor = 1;
                }

                query.Producto = objproducto.Producto;

                try
                {
                    contexto.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return valor;

        }

    }
}
