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
    public partial class Transferencias : PhoneApplicationPage
    {
        public Transferencias()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnTransferir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}