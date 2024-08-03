using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV02
{
    internal class FixedSizeList<T>
    {
        // 
        private readonly T[] items;
        private int count;
        public int Count => count;

        // constructor
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("capacity must be > 0 ");
            }

            items = new T[capacity];
            count = 0;
        }

        // methods
        public void Add(T item)
        {
            if (count >= items.Length)
            {
                throw new InvalidOperationException("List is full.");
                
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            return items[index];
        }


    }
}
