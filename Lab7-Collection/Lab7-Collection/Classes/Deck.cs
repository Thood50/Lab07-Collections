using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Collection.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] items = new T[5];
        int count;

        public int GetCount()
        {
            return count;
        }

        public void AddCard(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length + 1);
            }
            items[count++] = item;
        }

        public bool RemoveCard(int num)
        {
            int i;
            for (i = 0; i < count; i++)
            {
                if (i >= num)
                {
                    items[i] = items[i + 1];
                }
            }
            if (num > i)
            {
                return false;
            }
            Array.Resize(ref items, items.Length - 1);
            count--;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            retrun GetEnumerator();
        }
    }
}
