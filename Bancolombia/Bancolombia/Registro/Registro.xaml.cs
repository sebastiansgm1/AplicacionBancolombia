using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Bancolombia.Resources;
using Datos;
using Entidades.Maestros;
using System.IO.IsolatedStorage;
using Maestros.Fachada;


namespace Bancolombia.Registro
{
    public partial class Registro : PhoneApplicationPage
    {
        public Registro()
        {
            InitializeComponent();
        }

      

        private void BtnAtras_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (TxtUsuario.Text != string.Empty)
            {
                EntidadLogin objusuarios = new EntidadLogin();
                objusuarios.NombreUsuario = TxtUsuario.Text;
                //objusuarios.Saldo = 0;
                int retorno = FachadaLogin.Grabar(objusuarios);
                if(retorno == 1)
                {
                    MessageBox.Show("Registro Guardado");
                }
                else
                {
                    MessageBox.Show("El usuario ya existe");
                }
            }
            }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            if (TxtUsuario.Text != string.Empty)
            {
                EntidadLogin objusuarios = new EntidadLogin();
                objusuarios.NombreUsuario = TxtUsuario.Text;
                int retorno = FachadaLogin.Consultar(objusuarios);
                if (retorno == 1)
                {
                    MessageBox.Show("El Usuario se encuentra registrado en la base de datos");
                }
                else
                {
                    MessageBox.Show("El Usuario aun no existe");
                }
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (TxtUsuario.Text != string.Empty)
            {
                EntidadLogin objusuarios = new EntidadLogin();
                objusuarios.NombreUsuario = TxtUsuario.Text;
                int retorno = FachadaRegistro.Eliminar(objusuarios);
                if (retorno == 1)
                {
                    MessageBox.Show("El Usuario a sido eliminado");
                }
                else
                {
                    MessageBox.Show("El Usuario aun no existe");
                }
            }
            else
            {
                MessageBox.Show("Ingrese almenos un usuario");
            }
            
        }
    }
}