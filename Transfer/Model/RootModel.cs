using System;
using System.Collections.Generic;
using System.Text;

namespace Transfer.Model
{
    public class RootModel : ValidatableBase
    {
        public MorphDictionaryModel MorphDictionary { get; private set; } = new MorphDictionaryModel();
        public WordDictionaryModel WordDictionary { get; private set; } = new WordDictionaryModel();
    }
}
