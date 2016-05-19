namespace Vector_Project
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Collection Vector based in List
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
            get { return this.myList.Count; }

        }

        /// <summary>
        /// Realizate foreach contruction
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
        /// <param name="newElement"></param>
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

        public override string ToString()
        {
            var format = 
                string.Format("My vector Type: {0} ; Contains: {1} element\n"+
                "Collection was created by V.B.",
                this.myList.GetType().GetElementType(),
                this.myList.Count);

            return format;
        }
    }
}
