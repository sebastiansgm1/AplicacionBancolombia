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
using Maestros.Controladora;

namespace Maestros.Fachada
{
    public class FachadaLogin
    {
        #region Metodos

        public static int Consultar(EntidadLogin objusuarios)
        {
            int retorno = 0;
            try
            {
                retorno = ControladoraLogin.Consultar(objusuarios);
            }
            catch(Exception ex)
            {
                throw (ex);
            }

            return retorno;
        }



        #endregion

    }
}
