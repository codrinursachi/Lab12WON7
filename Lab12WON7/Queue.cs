using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12WON7
{
    public class Queue<T>
    {
        T[] array;
        int capacity;
        public int Count { get; private set; }
        public Queue(int capacity)
        {
            this.capacity = capacity;
            array = new T[capacity];
        }

        public void Enqueue(T element)
        {
            if (Count > capacity)
            {
                Console.WriteLine("Coada este plina");
                return;
            }

            array[Count++] = element;
        }

        public T Dequeue()
        {
            T result = array[0];
            Count--;
            Array.ConstrainedCopy(array,1,array, 0, Count);
            return result;
        }
    }
}
