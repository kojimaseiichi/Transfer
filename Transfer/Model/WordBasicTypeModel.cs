using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Transfer.Model
{
    public class WordBasicTypeModel : BindableBase, IEditableObject
    {
        private uint _length;

        private uint _scale;
        private uint _precision;

        private decimal _numericMin;
        private decimal _numericMax;

        public uint Length
        {
            get { return _length; }
            set { SetProperty(ref _length, value); }
        }

        #region IEditableObject

        private WordBasicTypeModel _backupCopy;
        private bool _inEdit;

        public void BeginEdit()
        {
            if (_inEdit) return;
            _inEdit = true;
            _backupCopy = this.MemberwiseClone() as WordBasicTypeModel;
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
