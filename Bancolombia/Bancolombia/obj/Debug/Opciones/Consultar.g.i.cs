﻿#pragma checksum "E:\Documents\Bancolombia\Bancolombia\Bancolombia\Opciones\Consultar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D7DD9D8BB645181270E6BB1D01D4CAFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Bancolombia.Opciones {
    
    
    public partial class Consultar : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.ScrollViewer ContendGrid;
        
        internal System.Windows.Controls.StackPanel StackPanel;
        
        internal System.Windows.Controls.Grid Grid1;
        
        internal System.Windows.Controls.Image image;
        
        internal System.Windows.Controls.TextBox TxtCuenta;
        
        internal System.Windows.Controls.Button BtnAtras;
        
        internal System.Windows.Controls.Button BtnConsultar;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Bancolombia;component/Opciones/Consultar.xaml", System.UriKind.Relative));
            this.ContendGrid = ((System.Windows.Controls.ScrollViewer)(this.FindName("ContendGrid")));
            this.StackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("StackPanel")));
            this.Grid1 = ((System.Windows.Controls.Grid)(this.FindName("Grid1")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
            this.TxtCuenta = ((System.Windows.Controls.TextBox)(this.FindName("TxtCuenta")));
            this.BtnAtras = ((System.Windows.Controls.Button)(this.FindName("BtnAtras")));
            this.BtnConsultar = ((System.Windows.Controls.Button)(this.FindName("BtnConsultar")));
        }
    }
}

