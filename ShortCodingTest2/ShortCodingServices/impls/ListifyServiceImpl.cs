using ShortCodingServices.utils;

namespace ShortCodingServices.impls
{
    public class ListifyServiceImpl : IListifyService
    {
        public int GetElement(int begin, int end, int index)
        {
            var list = new Listify(begin, end);

            return list[index];
        }
    }
}