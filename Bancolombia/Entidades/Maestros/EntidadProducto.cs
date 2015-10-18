using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Maestros
{
    public class EntidadProducto
    {
        private int _NumeroCuenta;
        private string _Usuario;
        private string _Producto;
        private float _Saldo;


        public string Producto
        {
            get
            {
                return _Producto;
            }

            set
            {
                _Producto = value;
            }
        }

        public float Saldo
        {
            get
            {
                return _Saldo;
            }

            set
            {
                _Saldo = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public int NumeroCuenta
        {
            get
            {
                return _NumeroCuenta;
            }

            set
            {
                _NumeroCuenta = value;
            }
        }
    }
}
