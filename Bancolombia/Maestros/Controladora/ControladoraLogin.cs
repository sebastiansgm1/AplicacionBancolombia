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
using Maestros.Broker;


namespace Maestros.Controladora
{
    class ControladoraLogin
    {
        #region Métodos

        /// <summary>
        /// Consulta un usuario.
        /// </summary>
        /// <param name="objusuarios">Información del usuario.</param>
        /// <returns>resultado de la operacion.</returns>
        public static int Consultar(EntidadLogin objusuarios)
        {
            int retorno = 0;
            try
            {

                if (objusuarios.CuentaUsuario.ToString().Length <= 4)
                {
                    retorno = BrokerLogin.Consultar(objusuarios);
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return retorno;
        }

        #endregion

    }
}
