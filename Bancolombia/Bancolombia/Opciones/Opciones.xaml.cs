using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Bancolombia.Opciones
{
    public partial class Opciones : PhoneApplicationPage
    {
        public Opciones()
        {
            InitializeComponent();
            
        }

        
        private void BtnRegistarCtas_Click(object sender, RoutedEventArgs e)
        {
            string usr = string.Empty;
            NavigationContext.QueryString.TryGetValue("Usuario", out usr);
            NavigationService.Navigate(new Uri("/Opciones/RegistrarCuenta.xaml?Usuario=" + usr, UriKind.RelativeOrAbsolute));
        }

        private void BtnProductos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Opciones/Productos.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Opciones/Consultar.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnAtras_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}