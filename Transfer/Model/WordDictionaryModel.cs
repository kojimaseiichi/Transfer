using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Transfer.Model
{
    public class WordDictionaryModel
    {
        public ObservableCollection<WordModel> Words { get; private set; } = new ObservableCollection<WordModel>();
    }
}
