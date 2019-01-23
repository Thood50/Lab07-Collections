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

        /// <summary>
        /// Adds a card to the deck
        /// </summary>
        /// <param name="item"></param>
        public void AddCard(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length + 1);
            }
            items[count++] = item;
            
        }

        /// <summary>
        /// Takes in a intger for a index spot, then removes a card at that location in the Deck
        /// </summary>
        /// <param name="num"></param>
        /// <returns>true or false depending on successful card removal</returns>
        public bool RemoveCard(int num)
        {
            try
            {
                if (num <= 0)
                {
                    return false;
                }
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
            catch(IndexOutOfRangeException)
            {
                return false;
            }
        }

        /// <summary>
        /// Contract with the Interface being allowing us to use foreach over our deck
        /// </summary>
        /// <returns>a card</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        /// <summary>
        /// GetEnumerator unwanted little brother
        /// </summary>
        /// <returns>calls big brother</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
