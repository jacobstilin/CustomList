using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] items;

        public CustomList()
        {
            items = new T[4];
            capacity = 4;
            count = 0;
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

        public void Remove(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(itemToRemove))
                {
                    DecrementCount();
                    for (int y = i; y < (count + 1); y++)
                    {
                        if (y == count)
                        {
                            break;
                        }
                        items[y] = items[y + 1];
                    }
                    break;
                }
            }
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

        public void DecrementCount()
        {
            count -=1 ;
        }

        public override string ToString()
        {
            string concatenatedString = "";
            for (int i = 0; i < count; i++)
            {
                concatenatedString += items[i].ToString();
            }
            return concatenatedString;
        }

       public static CustomList<T> operator + (CustomList<T> listOne, CustomList<T> listTwo)
        {
            foreach (T item in listTwo)
            {
                listOne.Add(item);
            }
            return listOne;
        }

        public static CustomList<T> operator - (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> result = new CustomList<T>();
            CustomList<T> temp = new CustomList<T>();
            temp = listTwo;

            foreach (T item in listOne)
            {
                if (temp.Contains(item))
                {
                    temp.Remove(item);
                }  
                else
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public CustomList<T> Zip (CustomList<T> listTwo)
        {
            CustomList<T> result = new CustomList<T>();
            
            if (count > listTwo.count)
            {
                for (int i = 0; i < listTwo.count; i++)
                {
                    result.Add(items[i]);
                    result.Add(listTwo[i]);
                }
                for (int i = (count - listTwo.count + 1); i < count; i++)
                {
                    result.Add(items[i]);
                }
            }

            if(count < listTwo.count)
            {
                for (int i = 0; i < count; i++)
                {
                    result.Add(items[i]);
                    result.Add(listTwo[i]);
                }
                for (int i = (listTwo.count - count + 1); i < listTwo.count; i++)
                {
                    result.Add(listTwo[i]);
                }
            }

            if (count == listTwo.count)
            {
                for (int i = 0; i < count; i++)
                {
                    result.Add(items[i]);
                    result.Add(listTwo[i]);
                }
            }

            if (count == 0)
            {
                for (int i = 0; i < listTwo.count; i++)
                {
                    result.Add(listTwo[i]);
                }
            }

            if (listTwo.count == 0)
            {
                for (int i = 0; i < count; i++)
                {
                    result.Add(items[i]);
                }
            }
            return result;
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
