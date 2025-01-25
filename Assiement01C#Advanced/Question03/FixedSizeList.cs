using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiement01C_Advanced.Question03
{
    class FixedSizeList<T>
    {
        public int Capacity { get; set; }
        public List<T> list { get; set; }


        public FixedSizeList(int capacity)
        {
            list = new List<T>(capacity);
            Capacity = capacity;
        }

        public void Add(T item)
        {
            if (list.Count == list.Capacity)
                Console.WriteLine("List Already Full");
            else
                list.Add(item);
        }

        public T Get(int index)
        {
            if (index >= list.Count)
                throw new IndexOutOfRangeException("Out Of Range");
            else
                return list[index];
        }
    }
}


