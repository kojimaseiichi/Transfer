﻿using System;
using System.Collections.Generic;
using System.Text;
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

namespace Transfer.Control
{
    /// <summary>
    /// ItemDictionaryControl.xaml の相互作用ロジック
    /// </summary>
    public partial class ItemDictionaryControl : UserControl
    {
        private RootModel _rootModel;

        public RootModel RootModel
        {
            get { return _rootModel; }
            set
            {
                _rootModel = value;
                _wordCtrl.RootModel = _rootModel;
                _morphCtrl.RootModel = _rootModel;
            }
        }

        public ItemDictionaryControl()
        {
            InitializeComponent();

            _wordCtrl.RootModel = RootModel;
            _morphCtrl.RootModel = RootModel;
        }
    }
}
