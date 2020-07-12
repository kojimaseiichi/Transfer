using System;
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
    /// MorphControl.xaml の相互作用ロジック
    /// </summary>
    public partial class MorphDictionaryControl : UserControl
    {
        private RootModel _rootModel;
        
        public RootModel RootModel
        {
            get { return _rootModel; }
            set
            {
                _rootModel = value;
                if (_rootModel == null)
                    this.DataContext = null;
                else
                    this.DataContext = _rootModel.MorphDictionary;
            }
        }

        public MorphDictionaryControl()
        {
            InitializeComponent();
        }
    }
}
