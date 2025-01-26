using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    internal class FixedSizeList<T>
    {
        T[] items;
        int counter;
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                Console.WriteLine("Capasaty Must Be Greater than 0");
                return;
            }
            items = new T[capacity];
            counter = 0;
        }
        public void Add(T item)
        {
            if (counter >= items.Length)
            {
                Console.WriteLine("List Is Already Full");
                return;
            }

            items[counter++] = item;

        }

        public T Get(int index)
        {
            if (index < 0 || index >= counter)
            {
                //Console.WriteLine("List Is Empty");
                //return default;
                throw new ArgumentOutOfRangeException("index");
            }
            counter--;
            return items[index];
        }
        public void Display()
        {
            foreach (var item in items)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

    }
}
