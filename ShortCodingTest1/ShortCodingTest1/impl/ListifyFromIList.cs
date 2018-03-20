using System;
using System.Collections;

namespace ShortCodingTest1.impl
{
    public class ListifyFromIList : IList
    {
        private int[] _contents;

        public ListifyFromIList(int min, int max)
        {
            Min = min;
            Max = max;
            _contents = FillArray();
        }

        public int Min { get; set; }
        public int Max { get; set; }

        public bool IsFixedSize =>
            throw new NotImplementedException();

        public bool IsReadOnly =>
            throw new NotImplementedException();

        public int Count =>
            throw new NotImplementedException();

        public bool IsSynchronized =>
            throw new NotImplementedException();

        public object SyncRoot =>
            throw new NotImplementedException();

        public object this[int index]
        {
            get
            {
                return _contents[index];
            }
            set
            {
                _contents[index] = (int)value;
            }
        }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return _contents.GetEnumerator();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        private int[] FillArray()
        {
            var arr = new int[Max - Min + 1];
            var pos = 0;
            for (int i = Min; i <= Max; i++)
            {
                arr[pos] = i;
                pos++;
            }
            return arr;
        }
    }
}