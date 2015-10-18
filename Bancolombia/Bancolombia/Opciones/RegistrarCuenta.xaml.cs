using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Entidades.Maestros;
using Datos;
using Maestros;
using System.IO.IsolatedStorage;
using System.Data.Linq.Mapping;
using Maestros.Fachada;

namespace Bancolombia.Opciones
{
    public partial class RegistrarCuenta : PhoneApplicationPage
    {
        /*List<TablaProducto> TablaTmpProducto = new List<TablaProducto>();
        List<TablaUsuario> TablaTmpUsuario = new List<TablaUsuario>();*/
        public RegistrarCuenta()
        {
            InitializeComponent();
           /* using (DbContexto contexto = new DbContexto("Data Source='isostore:/BancolombiaDb.sdf'")) // Data Source='isostore:/ - Guarde en la zona de almacenamiento ailada del telefono. ()
            {

                if (!contexto.DatabaseExists()) // Verifica si la base de datos existe 
                {

                    contexto.CreateDatabase();

                }

            }*/


                }

        private void BtnAtras_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            RadioButton rb = sender as RadioButton;
            TxtProducto.Text = "Cuenta: " + rb.Name;
            
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            string usr = string.Empty;
            NavigationContext.QueryString.TryGetValue("Usuario", out usr);
            TxtSaldo.Text = "Saldo: $";
            if (TxtCuenta.Text != string.Empty)
            {
                if(TxtProducto.Text != string.Empty)
                {
                    EntidadProducto objproducto = new EntidadProducto();
                    EntidadLogin objusuarios = new EntidadLogin();
                    objproducto.NumeroCuenta= Convert.ToInt16(TxtCuenta.Text);
                    objproducto.Producto = TxtProducto.Text;
                    objproducto.Saldo = 100000;
                    TxtSaldo.Text = TxtSaldo.Text + objproducto.Saldo;
                    int retorno = FachadaRegistro.CrearCta(objproducto, objusuarios, usr);
                    if(retorno==1)
                    {
                        MessageBox.Show("La cuenta ha sido registrada con exito");
                    }
                    else
                    {
                        MessageBox.Show("El Número de cuenta ya existe");
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos Los campos deben ser completados");
            }
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (TxtCuenta.Text != string.Empty)
            {
                EntidadProducto objproducto = new EntidadProducto();
                objproducto.NumeroCuenta = Convert.ToInt32(TxtCuenta.Text);
                objproducto.Producto = TxtProducto.Text;
                int retorno = FachadaRegistro.ModificarCta(objproducto);
                if (retorno == 1)
                {
                    MessageBox.Show("La cuenta ha sido Modificada");
                    TxtCuenta.Text = FachadaRegistro.ConsultarCta(objproducto, 1);
                    TxtProducto.Text = FachadaRegistro.ConsultarCta(objproducto, 2);
                    TxtSaldo.Text = FachadaRegistro.ConsultarCta(objproducto, 3);
                }
                else
                {
                    MessageBox.Show("La cuenta no existe");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de cuenta");
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(TxtCuenta.Text != string.Empty)
            {
                EntidadProducto objproducto = new EntidadProducto();
                objproducto.NumeroCuenta = Convert.ToInt32(TxtCuenta.Text);
                int retorno = FachadaRegistro.EliminarCta(objproducto);
                if (retorno == 1)
                {
                    MessageBox.Show("La cuenta ha sido Eliminada");
                }
                else
                {
                    MessageBox.Show("La cuenta no existe");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de cuenta");
            }
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            if(TxtCuenta.Text != string.Empty)
            {
                EntidadProducto objproducto = new EntidadProducto();
                objproducto.NumeroCuenta = Convert.ToInt32(TxtCuenta.Text);
                string retorno1 = FachadaRegistro.ConsultarCta(objproducto, 1);
                string retorno2 = FachadaRegistro.ConsultarCta(objproducto, 2);
                string retorno3 = FachadaRegistro.ConsultarCta(objproducto, 3);

                if(retorno1 != "N")
                {
                    TxtCuenta.Text = retorno1;
                    TxtProducto.Text = retorno2;
                    TxtSaldo.Text = "Saldo: $" + retorno3;
                }
                else
                {
                    MessageBox.Show("La Cuenta No Existe");
                }
            }
            else
            {
                MessageBox.Show("Ingrese Un Número de Cuenta");
            }
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            TxtCuenta.Text = string.Empty;
            TxtProducto.Text = string.Empty;
            TxtSaldo.Text = "Saldo: $";
        }
    }
}