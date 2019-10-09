using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T>
    {
        private T[] items;

        public CustomList()
        {
            items = new T[4];
        }

        public T this[int index]
        {
            get
            {
                // return the value specified by index
                T temp;
                if (index >= 0 && index <= count - 1)
                {
                    temp = items[index];
                }
                else
                {
                    throw new System.ArgumentException("Index out of range");
                }
                return (temp);
            }
            set
            {
                // set the value specified by index
                if (index >= 0 && index <= capacity - 1)
                {
                    items[index] = value;
                }
            }
        }
        
        public void Add(T itemToAdd)
        {
            if(count == capacity)
            {
                GrowArray();
            }
            items[count] = itemToAdd;
            IncrementCount();
        }

        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        private int capacity;

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public void GrowArray()
        {
            // make new array with double capacity
            // capacity *= 2
            // store new array as array (reference)
            int newSize = capacity * 2;
            T[] larger = new T[newSize];
            //iterate through old array and copy to new
            for (int i = 0; i < items.Length; i++)
            {
                larger[i] = items[i];
            }
            items = larger;
            Capacity = capacity * 2;
        }

        public void IncrementCount()
        {
            count += 1;
        }

        public void Clear()
        {

        }

       



    }
}
