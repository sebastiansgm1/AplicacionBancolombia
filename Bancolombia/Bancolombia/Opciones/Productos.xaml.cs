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
    public partial class Productos : PhoneApplicationPage
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}