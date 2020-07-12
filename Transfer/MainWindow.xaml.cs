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
using Transfer.Model;

namespace Transfer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Control.ItemDictionaryControl _itemDictCtrl = new Control.ItemDictionaryControl();

        public MainWindow()
        {
            InitializeComponent();
            _itemDictCtrl.RootModel = new RootModel();
        }

        private void _tviDict_Selected(object sender, RoutedEventArgs e)
        {
            _grid.Children.Clear();
            _grid.Children.Add(_itemDictCtrl);
        }
    }
}
