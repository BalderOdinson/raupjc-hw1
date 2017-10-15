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
        public int position = 0;

        public GenericListEnumerator(IGenericList<T> genericList)
        {
            _genericList = genericList;
        }

        public void Dispose()
        {
            _genericList = null;
            position = 0;
        }

        public bool MoveNext()
        {
            if (position == _genericList.Count - 1)
                return false;
            position++;
            return true;
        }

        public void Reset()
        {
            position = 0;
        }

        public T Current => _genericList.GetElement(position);

        object IEnumerator.Current => Current;
    }
}
