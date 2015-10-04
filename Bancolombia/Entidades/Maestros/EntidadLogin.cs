using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Maestros
{
    public class EntidadLogin
    {
        #region Atributos

        /// <summary>
        /// Corresponde a la cuenta de usuario
        /// </summary>  
        /// 

        private Int16 _CuentaUsuario;

        /// <summary>
        /// Corresponde al nombre con el que se identifica el usuario
        /// </summary>
        private string _NombreUsuario;


        #endregion

        #region Propiedades

        public Int16 CuentaUsuario
        {
            get
            {
                return _CuentaUsuario;
            }
            set
            {
                _CuentaUsuario = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return _NombreUsuario;
            }
            set
            {
                _NombreUsuario = value;
            }
        }

        #endregion
    }
}
