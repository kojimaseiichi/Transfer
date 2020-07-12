using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Transfer.Model
{
    public class MorphDictionaryModel
    {
        public ObservableCollection<MorphModel> Morphs { get; private set; } = new ObservableCollection<MorphModel>();
    }
}
