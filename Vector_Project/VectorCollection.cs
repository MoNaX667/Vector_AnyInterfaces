// <copyright file="VectorCollection.cs" company="Some Company">
// Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Vitalit Belyakov</author>

namespace Vector_Project
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Class for collection of Vector data types 
    /// </summary>
    /// <typeparam name="T">Some type of vector</typeparam>
    internal class VectorCollection<T> : IEnumerable<Vector<T>> where T : struct 
    {
        /// <summary>
        /// My list collection for input saving data
        /// </summary>
        private List<Vector<T>> myList;

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorCollection {T}" /> class
        /// </summary>
        /// <param name="myVectors">Collection of elem</param>
        public VectorCollection(params Vector<T>[] myVectors)
        {
            this.myList = new List<Vector<T>>();

            foreach (var vector in myVectors)
            {
                this.myList.Add(vector);
            }
        }

        /// <summary>
        /// Gets len of collection
        /// </summary>
        public int Count
        {
            get
            {
                return this.myList.Count;
            }
        }

        /// <summary>
        /// Gets some elem by index
        /// </summary>
        /// <param name="index">index of some elem</param>
        /// <returns>return some elem by index</returns>
        public Vector<T> this[int index]
        {
            get
            {
                return this.myList[index];
            }
        }

        /// <summary>
        /// Method for foreach construction
        /// </summary>
        /// <returns>return some enumeration</returns>
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            return this.myList.GetEnumerator();
        }

        /// <summary>
        /// Some enum
        /// </summary>
        /// <returns>return collection</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Vector<int>>)this.myList).GetEnumerator();
        }

        /// <summary>
        /// Add some vector to collection
        /// </summary>
        /// <param name="newVector">some vector for collection</param>
        public void Add(Vector<T> newVector)
        {
            this.myList.Add(newVector);
        }

        /// <summary>
        /// Try remove vector from collection by index 
        /// </summary>
        /// <param name="indexOfElement">index of target element</param>
        /// <returns>true if list contains this index, or false of error</returns>
        public bool TryRemoveAt(int indexOfElement)
        {
            if (indexOfElement > 0 && indexOfElement < this.myList.Count)
            {
                this.myList.RemoveAt(indexOfElement);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Some elem
        /// </summary>
        /// <returns>some elem</returns>
        IEnumerator<Vector<T>> IEnumerable<Vector<T>>.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Sort by compare vector method
        /// </summary>
        public void Sort()
        {
            this.myList.Sort();
        }
    }
}
