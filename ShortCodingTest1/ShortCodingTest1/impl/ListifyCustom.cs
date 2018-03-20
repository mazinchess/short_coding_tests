using System.Collections.Generic;
using System.Linq;

namespace ShortCodingTest1.impl
{
    public class ListifyCustom : IList1
    {
        public ListifyCustom(int min, int max)
        {
            Min = min;
            Max = max;
            Elements = MyIterator();
        }

        public int Min { get; set; }
        public int Max { get; set; }
        public IEnumerable<int> Elements { get; }

        public int this[int index]
        {
            get { return Elements.ElementAt(index); }
        }

        public int GetElementAtPosition(int position)
        {
            return Elements.ElementAt(position);
        }

        private IEnumerable<int> MyIterator()
        {
            for (int i = Min; i <= Max; i++)
            {
                yield return i;
            }
        }
    }
}