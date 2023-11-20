using System;
using System.Collections.Generic;

namespace ConAppAS14
{
    public class LargeDataCollection : IDisposable
    {
        private List<object> dataCollection;

        public LargeDataCollection(IEnumerable<object> initialData)
        {
            dataCollection = new List<object>(initialData);
        }

        public void AddElement(object element)
        {
            dataCollection.Add(element);
        }

        public void RemoveElement(object element)
        {
            dataCollection.Remove(element);
        }

        public object AccessElement(int index)
        {
            if (index >= 0 && index < dataCollection.Count)
            {
                return dataCollection[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        public void Dispose()
        {
            // Release any unmanaged resources here

            // Set the internal data structure to null to free up memory
            dataCollection = null;
        }
    }
}
