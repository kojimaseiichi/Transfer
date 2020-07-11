using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Transfer.Model
{
    class DictItemModel : BindableBase, IEditableObject
    {
        private string _word = "";
        private string _alpha = "";

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


        #region IEditableObject

        private DictItemModel _backupCopy;
        private bool _inEdit;

        public void BeginEdit()
        {
            if (_inEdit) return;
            _inEdit = true;
            _backupCopy = this.MemberwiseClone() as DictItemModel;
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
