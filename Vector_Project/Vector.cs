namespace Vector_Project
{
    using System;

    internal sealed class Vector<T>: IComparable<Vector<T>> where T: struct
    {
        // Ctor

        /// <summary>
        /// Create some vector by Start and End points coordinates
        /// </summary>
        /// <param name="startPointName">Start point name</param>
        /// <param name="endPointName">End point name</param>
        /// <param name="startPointX">start point x coordinate</param>
        /// <param name="startPointY">start point y coordinate</param>
        /// <param name="endPointX">end point x coordinate</param>
        /// <param name="endPointY">end point y coordinate</param>
        public Vector(char startPointName, char endPointName, T startPointX, 
            T startPointY, T endPointX, T endPointY)
        {
            this.StartPosX = startPointX;
            this.StartPosY = startPointY;
            this.EndPosX = endPointX;
            this.EndPosY = endPointY;
            this.VectorX = (((dynamic)(this.EndPosX.ToString())) - 
                (dynamic)(this.StartPosX.ToString()));
            this.VectorY = (dynamic)this.EndPosY - (dynamic)this.StartPosY;
            this.Name = startPointName.ToString() + endPointName.ToString();
            this.Lenght = Math.Sqrt(Math.Pow((dynamic)this.VectorX, 2) +
                Math.Pow((dynamic)this.VectorY, 2));
        }

        /// <summary>
        /// Create new vector with use x and y coordinate of vector
        /// </summary>
        /// <param name="name">name of vector</param>
        /// <param name="xVector">x vector coordinate</param>
        /// <param name="yVector">y vector coordinate</param>
        public Vector(string name,T xVector,T yVector)
        {
            this.Name = name;
            this.VectorX = xVector;
            this.VectorY = yVector;
            this.Lenght = Math.Sqrt(Math.Pow((dynamic)this.VectorX, 2) +
                Math.Pow((dynamic)this.VectorY, 2));
        }

        // Members
        public T StartPosX { get; private set; }

        public T StartPosY { get; private set; }

        public T EndPosX { get; private set; }

        public T EndPosY { get; private set; }
        
        public T VectorX { get; private set; }

        public T VectorY { get; private set; }

        public string Name { get; private set; }

        public double Lenght { get; private set; }

        /// <summary>
        /// Sum vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>New vector</returns>
        public static Vector<T> operator +(Vector<T> firstVector, Vector<T> secondVector)
        {
            return new Vector<T>(
                string.Format("{0}{1}", firstVector.Name[0], secondVector.Name[1]),
                (dynamic)firstVector.VectorX + (dynamic)secondVector.StartPosX,
                (dynamic)firstVector.VectorY + (dynamic)secondVector.VectorY);
        }

        /// <summary>
        /// - operator of vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>New vector</returns>
        public static Vector<T> operator -(Vector<T> firstVector, Vector<T> secondVector)
        {
            return new Vector<T>(
                string.Format("{0}{1}", firstVector.Name[0], secondVector.Name[1]),
                (dynamic)firstVector.VectorX - (dynamic)secondVector.StartPosX,
                (dynamic)firstVector.VectorY - (dynamic)secondVector.VectorY);
        }

        /// <summary>
        /// More operator
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>True if first more than second</returns>
        public static bool operator >(Vector<T> firstVector, Vector<T> secondVector)
        {
            return ((dynamic)firstVector.CompareTo(secondVector) < 0);
        }

        /// <summary>
        /// Less operator
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>True if first less than second</returns>
        public static bool operator <(Vector<T> firstVector, Vector<T> secondVector)
        {
            return ((dynamic)firstVector.CompareTo(secondVector) > 0);
        }

        /// <summary>
        /// Equally operator
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>True if first less than second</returns>
        public static bool operator ==(Vector<T> firstVector, Vector<T> secondVector)
        {
            return ((dynamic)firstVector.CompareTo(secondVector) == 0);
        }

        /// <summary>
        /// Unequally operator
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>True if first less than second</returns>
        public static bool operator !=(Vector<T> firstVector, Vector<T> secondVector)
        {
            return ((dynamic)firstVector.CompareTo(secondVector) != 0);
        }

        // Public methods

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>text representation of vector</returns>
        public override string ToString()
        {
            string result = string.Empty;

            result = string.Format(
                "[VectorName: {2}; Lenght: {3:000.00} ; VectorCoordinate: {0:00}:{1:00} ;]",
                this.VectorX,
                this.VectorY,
                this.Name,
                this.Lenght);

            return result;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        /// <returns>return number</returns>
        public override int GetHashCode()
        {
            return this.Lenght.GetHashCode() + this.ToString().GetHashCode();
        }

        /// <summary>
        /// Compare some other Vector
        /// </summary>
        /// <param name="other">Some other vector</param>
        /// <returns>return number to compare</returns>
        public int CompareTo(Vector<T> other)
        {
            if (this.Lenght > other.Lenght)
            {
                return -1;
            }

            if (this.Lenght < other.Lenght)
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Do compare operation
        /// </summary>
        /// <param name="obj">Some vector</param>
        /// <returns>true if  == </returns>
        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }
    }
}