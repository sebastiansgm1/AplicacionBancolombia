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
    public class FachadaRegistro
    {
        public static int Eliminar(EntidadLogin objusuarios)
        {
            int retorno = 0;
            try
            {
                retorno = ControladoraRegistro.Eliminar(objusuarios);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return retorno;
        }

        public static int CrearCta(EntidadProducto objproducto, EntidadLogin objusuarios, string usuario)
        {
            int retorno = 0;
            try
            {
                retorno = ControladoraRegistro.CrearCta(objproducto, objusuarios, usuario);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return retorno;
        }
        public static String ConsultarCta(EntidadProducto objproductos, int n)
        {
            String retorno = string.Empty;
            try
            {

                if (objproductos.NumeroCuenta.ToString().Length <= 4)
                {
                    retorno = ControladoraRegistro.ConsultarCta(objproductos, n);
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return retorno;
        }

        public static int EliminarCta(EntidadProducto objproducto)
        {
            int retorno = 0;
            try
            {
                retorno = ControladoraRegistro.EliminarCta(objproducto);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return retorno;
        }

        public static int ModificarCta(EntidadProducto objproducto)
        {
            int retorno = 0;
            try
            {
                retorno = ControladoraRegistro.ModificarCta(objproducto);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return retorno;
        }
    }
}
