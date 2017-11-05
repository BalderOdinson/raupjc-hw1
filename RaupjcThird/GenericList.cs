using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaupjcThird
{
    public class GenericList <T> : IGenericList<T>
    {
        private T[] _internalStorage;

        public GenericList()
        {
            _internalStorage = new T[4];
        }

        public GenericList(int sizeCount)
        {
            _internalStorage = new T[sizeCount];
        }

        public void Add(T item)
        {
            if (Count == _internalStorage.Length)
            {
                var newInternalStorage = new T[_internalStorage.Length*2];
                for (var position = 0; position < Count; position++)
                {
                    newInternalStorage[position] = _internalStorage[position];
                }
                newInternalStorage[Count] = item;
                _internalStorage = newInternalStorage;
            }
            else
            {
                _internalStorage[Count] = item;
            }
            Count++;
        }

        public bool Remove(T item)
        {
            for (var index = 0; index < Count; index++)
            {
                if (_internalStorage[index].Equals(item))
                    return RemoveAt(index);
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index >= Count || index < 0)
                throw new IndexOutOfRangeException();
            if (_internalStorage.Length - Count == 5)
            {
                var newInternalStorage = new T[_internalStorage.Length - 1];
                for (var position = 0; position < Count; position++)
                {
                    if (position == index)
                        continue;
                    newInternalStorage[position > index ? position - 1 : position] = _internalStorage[position];
                }
                _internalStorage = newInternalStorage;
            }
            else
            {
                for (var position = index; position < Count - 1; position++)
                {
                    _internalStorage[position] = _internalStorage[position + 1];
                }
            }
            Count--;
            return true;
        }

        public T GetElement(int index)
        {
            if (index >= Count || index < 0)
                throw new IndexOutOfRangeException(Count.ToString() + ":" + index.ToString());
            return _internalStorage[index];
        }

        public int IndexOf(T item)
        {
            for (var index = 0; index < Count; index++)
            {
                if (_internalStorage[index].Equals(item))
                    return index;
            }
            return -1;
        }

        public int Count { get; private set; } = 0;

        public void Clear()
        {
            _internalStorage = new T[Count];
            Count = 0;
        }

        public bool Contains(T item)
        {
            for (var index = 0; index < Count; index++)
            {
                if (_internalStorage[index].Equals(item))
                    return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new GenericListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
