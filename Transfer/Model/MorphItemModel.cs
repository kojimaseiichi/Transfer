using System;
using System.Collections.Generic;
using System.Text;

namespace Transfer.Model
{
    class MorphItemModel : BindableBase
    {
        private string _morph = "";
        private string _alpha = "";
        
        public string Morph
        {
            get { return _morph; }
            set { SetProperty(ref _morph, value); }
        }
        public string Alpha
        {
            get { return _alpha; }
            set { SetProperty(ref _alpha, value); }
        }
    }
}
