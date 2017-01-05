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
using LEASPAS.Model;

namespace LEASPAS.GUI.View.Élève {
    /// <summary>
    /// Logique d'interaction pour VueEleves.xaml
    /// </summary>
    public partial class VueEleves : UserControl
    {
        private MainWindow _mainWindow;
        public VueEleves(MainWindow mainWindow) {
            InitializeComponent();
            _mainWindow = mainWindow;
            DataGridEleves.ItemsSource = _mainWindow.Collection.Eleves;
        }

        private void ButtonAjout_OnClick(object sender, RoutedEventArgs e)
        {
            _mainWindow.ContentControl.Content = new VueEleve(new Eleve(), _mainWindow);
        }

        private void ButtonVueDetail_OnClick(object sender, RoutedEventArgs e)
        {
            if (DataGridEleves.SelectedItem == null)
            {
                return;
            }
            _mainWindow.ContentControl.Content = new VueDetailsEleve(DataGridEleves.SelectedItem as Eleve, _mainWindow);
        }
    }
}
