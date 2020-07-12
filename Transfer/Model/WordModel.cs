using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Transfer.Model
{
    public enum WordTypeEnum
    {
        TEXT,
        INTEGER,
        DECIMAL,
        DATE,
        DATETIME,
        SEQUENCE
    }

    public class WordModel : BindableBase, IEditableObject
    {
        private string _word = "";
        private string _alpha = "";
        private WordTypeEnum _basicType = WordTypeEnum.TEXT;

        public string Word
        {
            get { return _word; }
            set { SetProperty(ref _word, value); }
        }
        public string Alpha
        {
            get { return _alpha; }
            set { SetProperty(ref _alpha, value); }
        }
        public WordTypeEnum BasicType
        {
            get { return _basicType; }
            set { SetProperty(ref _basicType, value); }
        }

        #region IEditableObject

        private WordModel _backupCopy;
        private bool _inEdit;

        public void BeginEdit()
        {
            if (_inEdit) return;
            _inEdit = true;
            _backupCopy = this.MemberwiseClone() as WordModel;
        }

        public void CancelEdit()
        {
            if (!_inEdit) return;
            _inEdit = false;
            Utility.Copy.PublicProp(_backupCopy, this);
        }

        public void EndEdit()
        {
            if (!_inEdit) return;
            _inEdit = false;
            _backupCopy = null;
        }

        #endregion

    }
}
