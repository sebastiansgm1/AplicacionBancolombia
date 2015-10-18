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



namespace Bancolombia
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();

            using (DbContexto contexto = new DbContexto("Data Source='isostore:/BancolombiaDb.sdf'"))
            {
                if(!contexto.DatabaseExists())
                {
                    contexto.CreateDatabase();

                    List<TablaUsuario> TablaTmpUsuario = new List<TablaUsuario>(){ // Clase Tabla usuario - un solo registro.... Construimos una lista con una posiciones 1,2,3 - Y la tablausuario la agrego en una posición ---- 
                        new TablaUsuario()
                        {
                            NombreUsuario= "adm", //Saldo= 100000
                        }
                    };
                    contexto.Usuarios.InsertAllOnSubmit(TablaTmpUsuario);
                    contexto.SubmitChanges();


                }
            }

        }
     

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/InformacionLegal/InformacionLegal.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Registro/Registro.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnContinuar_Click(object sender, RoutedEventArgs e)
        {
            if(TxtUsuario.Text != string.Empty)
            {
                EntidadLogin objusuarios = new EntidadLogin();
                objusuarios.NombreUsuario = TxtUsuario.Text;
                int retorno = FachadaLogin.Consultar(objusuarios);
                if (retorno == 1 )
                {
                    string usr = TxtUsuario.Text;
                    NavigationService.Navigate(new Uri("/Opciones/Opciones.xaml?Usuario=" + usr, UriKind.RelativeOrAbsolute));
                }
                else
                {
                    MessageBox.Show("El Usuario no existe el sistema lo llevara al registro");
                    NavigationService.Navigate(new Uri("/Registro/Registro.xaml", UriKind.RelativeOrAbsolute));
                }
            }
        }

        

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}