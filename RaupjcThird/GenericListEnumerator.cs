using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaupjcThird
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        private IGenericList<T> _genericList;
        private int _position = -1;

        public GenericListEnumerator(IGenericList<T> genericList)
        {
            _genericList = genericList;
        }

        public void Dispose()
        {
            _genericList = null;
            _position = 0;
        }

        public bool MoveNext()
        {
            if (_position >= _genericList.Count - 1)
                return false;
            _position++;
            return true;
        }

        public void Reset()
        {
            _position = 0;
        }

        public T Current => _genericList.GetElement(_position);

        object IEnumerator.Current => Current;
    }
}
