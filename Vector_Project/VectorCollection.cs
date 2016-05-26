namespace Vector_Project
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Class for collection of Vector Int data types 
    /// </summary>
    internal class VectorCollection<T>: IEnumerable<Vector<T>> where T: struct 
    {
        private List<Vector<T>> myList;

        /// <summary>
        /// Lenght of collection
        /// </summary>
        public int Count
        {
            get
            {
                return myList.Count;
            }

        }

        public Vector<T> this[int index]      
        {
            get
            {
                return myList[index];
            }
        }

        /// <summary>
        /// Base c-tor for initilizate new collection with some new vectors
        /// </summary>
        /// <param name="myVectors"></param>
        public VectorCollection(params Vector<T>[] myVectors )
        {
            myList=new List<Vector<T>>();

            foreach (var vector in myVectors)
            {
                myList.Add(vector);
            }
        }

        /// <summary>
        /// Method for foreach construction
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            return myList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Vector<int>>) myList).GetEnumerator();
        }

        /// <summary>
        /// Add some vector to collection
        /// </summary>
        /// <param name="newVector">some vector for collection</param>
        public void Add(Vector<T> newVector)
        {
            myList.Add(newVector);
        }

        /// <summary>
        /// Try remove vector from collection by index 
        /// </summary>
        /// <param name="indexOfElement">index of target element</param>
        /// <returns>true if list contains this index, or false of error</returns>
        public bool TryRemoveAt(int indexOfElement)
        {
            if (indexOfElement > 0 && indexOfElement < myList.Count)
            {
                myList.RemoveAt(indexOfElement);
                return true;
            }
            return false;
        }

        IEnumerator<Vector<T>> IEnumerable<Vector<T>>.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Sort by compare vector method
        /// </summary>
        public void Sort()
        {
            myList.Sort();
        }
    }
}
