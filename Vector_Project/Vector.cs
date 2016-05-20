namespace Vector_Project
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Collection MathVector based in List
    /// </summary>
    /// <typeparam name="T">Any type</typeparam>
    internal class Vector<T> : IEnumerable<T>
    {
        private readonly List<T> myList;
        
        /// <summary>
        /// Create vector by new object
        /// </summary>
        public Vector()
        {
            this.myList = new List<T>();
        }

        /// <summary>
        /// Return count of collection
        /// </summary>
        public int Lenght
        {
            get
            {
                return this.myList.Count;
            }
        }

        /// <summary>
        /// Do foreach work
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.myList.Count; i++)
            {
                yield return this.myList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove some element by index if collection contains this index
        /// </summary>
        /// <param name="index">Index of target element</param>
        /// <returns>Return true if removing was ok</returns>
        public bool RemoveAt(int index)
        {
            if (this.myList.Count > index)
            {
                this.myList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Clear collection
        /// </summary>
        public void Clear()
        {
            this.myList.Clear();
        }

        /// <summary>
        /// Add some element
        /// </summary>
        /// <param name="newElement">New element for adding</param>
        public void Add(T newElement)
        {
            this.myList.Add(newElement);
        }

        /// <summary>
        /// Check current collection to contain target element
        /// </summary>
        /// <param name="targetElement">Target element</param>
        /// <returns>Return true if collection contains target element</returns>
        public bool Contains(T targetElement)
        {
            if (this.myList.Contains(targetElement))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Output some info about this instance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "";

            if (this.myList != null && this.myList.Count > 0)
            {
                result += string.Format(" [MathVector collection type: {0}] ", this.myList[0].GetType());

                for (int i = 0; i < this.myList.Count; i++)
                {
                    result += string.Format(" [{0}: {1}] ", i, this.myList[i]);
                }
            }

            return result;
        }

        /// <summary>
        /// Do base operation vector collection
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj is Vector<T> && obj != null)
            {
                Vector<T> temp = (Vector<T>)obj;

                if (temp == this)
                {
                    return true;
                }
            }
            
            return false;
        }

        /// <summary>
        /// Get hash code by ToString HashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        /// <summary>
        /// If type of vector data realizated IComparable interface than 
        /// method can use sort function for all element
        /// </summary>
        /// <returns>return true if operatin was done</returns>
        public bool TrySort()
        {
            try
            {
                this.myList.Sort();
                return true;
            }
            catch (InvalidOperationException excep)
            {
                return false;
            }
        }

        /// <summary>
        /// Sort data with using some comparer instance
        /// </summary>
        /// <param name="someComparer"></param>
        public void SortByComperer(IComparer<T> someComparer)
        {
            this.myList.Sort(someComparer);
        }
    }
}
