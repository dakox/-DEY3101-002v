﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoBeLife
{
    /// <summary>
    /// Lógica de interacción para ViewCliente.xaml
    /// </summary>
    public partial class ViewCliente : Page
    {
        public ViewCliente()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // this.NavigationService.GoBack();         
            NavigationService.Navigate(new CoverPage());
        }
    }
}
