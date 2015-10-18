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

namespace Maestros.Broker
{
    public class BrokerLogin
    {
        #region metodos
        /// <summary>
        /// Buscar un usuario.
        /// </summary>
        /// <param name="objusuarios">Información de la cuenca.</param>   
        //static List<TablaUsuario> TablaTmpUsuario { get; set; }
        public static int Consultar(EntidadLogin objusuarios)
        {
            int valor = 0;

            using (DbContexto contexto = new DbContexto("Data Source='isostore:/BancolombiaDb.sdf'"))
            {
                
                var query = from TablaTmpUsuario in contexto.Usuarios.ToList()
                            orderby TablaTmpUsuario.NombreUsuario
                            where TablaTmpUsuario.NombreUsuario == objusuarios.NombreUsuario
                            select TablaTmpUsuario.NombreUsuario;
                //select new
                //{
                //    Nuser = TablaTmpUsuario.NombreUsuario,
                //    coduser = TablaTmpUsuario.CodigoUsuario,
                //    keyusuario = TablaTmpUsuario.ClaveUsuario,

                //};

                if (query.ToList().Count > 0)
                {
                    valor = 1;
                }

            }
            return valor;
        }

        public static int Grabar(EntidadLogin objusuarios)
        {
            int valor = 0;

            using (DbContexto contexto = new DbContexto("Data Source = 'isostore:/BancolombiaDb.sdf'"))
            {
                var query = from TablaTmpUsuario in contexto.Usuarios.ToList() // TablaTmpUsuario Es una tabla de tipo contexto.Usuarios 
                            orderby TablaTmpUsuario.Cuenta
                            where TablaTmpUsuario.NombreUsuario == objusuarios.NombreUsuario
                            select TablaTmpUsuario.NombreUsuario;
                if (query.ToList().Count > 0)
                {
                    valor = 2;
                }
                else
                {
                    List<TablaUsuario> TablaTmpUsuario = new List<TablaUsuario>()
                    {
                        new TablaUsuario()
                        {
                            NombreUsuario=objusuarios.NombreUsuario//, Saldo=objusuarios.Saldo
                        }
                    };
                    valor = 1;
                    contexto.Usuarios.InsertAllOnSubmit(TablaTmpUsuario);
                    contexto.SubmitChanges();
                }

            }
            return valor;
        }


        #endregion


    }
}
