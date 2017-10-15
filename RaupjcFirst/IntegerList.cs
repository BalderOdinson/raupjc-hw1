using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaupjcFirst
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage = new int[0];
        public void Add(int item)
        {
            var newInternalStorage = new int[_internalStorage.Length + 1];
            for (var position = 0; position < _internalStorage.Length; position++)
            {
                newInternalStorage[position] = _internalStorage[position];
            }
            newInternalStorage[_internalStorage.Length] = item;
            _internalStorage = newInternalStorage;
        }
        public bool Remove(int item)
        {
            for (var index = 0; index < _internalStorage.Length; index++)
            {
                if (_internalStorage[index] == item)
                    return RemoveAt(index);
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if(index >= _internalStorage.Length || index < 0)
                throw new IndexOutOfRangeException();
            var newInternalStorage = new int[_internalStorage.Length - 1];
            for (var position = 0; position < _internalStorage.Length; position++)
            {
                if(position == index)
                    continue;
                newInternalStorage[position > index ? position - 1 : position] = _internalStorage[position];
            }
            _internalStorage = newInternalStorage;
            return true;
        }

        public int GetElement(int index)
        {
            if (index >= _internalStorage.Length || index < 0)
                throw new IndexOutOfRangeException();
            return _internalStorage[index];
        }

        public int IndexOf(int item)
        {
            for (var index = 0; index < _internalStorage.Length; index++)
            {
                if (_internalStorage[index] == item)
                    return index;
            }
            throw new ArgumentException();
        }

        public int Count => _internalStorage.Length;

        public void Clear()
        {
            _internalStorage = new int[0];
        }

        public bool Contains(int item)
        {
            foreach (var element in _internalStorage)
            {
                if (element == item)
                    return true;
            }
            return false;
        }

    }
}
