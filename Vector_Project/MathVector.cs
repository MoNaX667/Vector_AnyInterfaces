namespace Vector_Project
{
    using System;
    using System.Collections.Generic;

    internal sealed class MathVector : IComparable, IComparer<MathVector>
    {
        // Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="startPointName">Start point name</param>
        /// <param name="endPointName">End point name</param>
        /// <param name="startPointX">start point x coordinate</param>
        /// <param name="startPointY">start point y coordinate</param>
        /// <param name="endPointX">end point x coordinate</param>
        /// <param name="endPointY">end point y coordinate</param>
        public MathVector(char startPointName, char endPointName, int startPointX, 
            int startPointY, int endPointX, int endPointY)
        {
            this.StartPosX = startPointX;
            this.StartPosY = startPointY;
            this.EndPosX = endPointX;
            this.EndPosY = endPointY;
            this.VectorX = this.EndPosX - this.StartPosX;
            this.VectorY = this.EndPosY - this.StartPosY;
            this.Name = startPointName.ToString() + endPointName.ToString();
            this.Lenght = Math.Sqrt(Math.Pow(this.VectorX, 2) + Math.Pow(this.VectorY, 2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newVectorX">X coordinate for vector</param>
        /// <param name="newVectorY">Y coordinate for vector</param>
        /// <param name="name">String name for vector two symblos names recomendeted</param>
        public MathVector(int newVectorX, int newVectorY, string name)
        {
            this.VectorX = newVectorX;
            this.VectorY = newVectorY;
            this.Lenght = Math.Sqrt(Math.Pow(newVectorX, 2) + Math.Pow(newVectorY, 2));
            this.Name = name;
        }

        // Members
        public int StartPosX { get; private set; }

        public int StartPosY { get; private set; }

        public int EndPosX { get; private set; }

        public int EndPosY { get; private set; }

        public int VectorX { get; private set; }

        public int VectorY { get; private set; }

        public string Name { get; private set; }

        public double Lenght { get; private set; }

        // Some static operatoion for MathVector

        /// <summary>
        /// Summand vectors
        /// </summary>
        /// <param name="first">first vector</param>
        /// <param name="second">second vector</param>
        /// <returns></returns>
        public static MathVector operator +(MathVector first, MathVector second)
        {
            return new MathVector(
                (second.VectorX - first.VectorX),
                (second.VectorY + first.VectorY), string.Format("{0}{1}",
                first.Name[0], second.Name[0]));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static MathVector operator -(MathVector first, MathVector second)
        {
            return new MathVector(
                (second.VectorX - first.VectorX),
                (second.VectorY - first.VectorY),
                string.Format("{0}{1}",
                first.Name[0],
                second.Name[0]));
        }

        public static bool operator ==(MathVector first, MathVector second)
        {
            if (first.Lenght == second.Lenght)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(MathVector first, MathVector second)
        {
            if (first.Lenght != second.Lenght)
            {
                return true;
            }

            return false;
        }

        // Public methods

        /// <summary>
        /// Compare vaectors by lenght
        /// </summary>
        /// <param name="obj">Some vector</param>
        /// <returns></returns>
        public int CompareTo(object someVector)
        {
            if (someVector is MathVector)
            {
                MathVector temp = someVector as MathVector;

                if (this.Lenght == temp.Lenght)
                {
                    return 0;
                }
                else if (this.Lenght > temp.Lenght)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            return 0;
        }

        /// <summary>
        /// Compare two vectors by Lenght
        /// </summary>
        /// <param name="one">First vector</param>
        /// <param name="two">Second vector</param>
        /// <returns></returns>
        public int Compare(MathVector first, MathVector second)
        {
            if (first.Lenght > second.Lenght)
            {
                return 1;
            }
            else if (first.Lenght < second.Lenght)
            {
                return -1;
            }

            return 0;
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = string.Empty;

            result = string.Format(
                "[VectorName: {2}; Lenght: {3:000.00} ; VectorCoordinate: {0}:{1} ;]",
                this.VectorX,
                this.VectorY,
                this.Name,
                this.Lenght);

            return result;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.Lenght.GetHashCode() + this.ToString().GetHashCode();
        }

        /// <summary>
        /// Check for equils some vector
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Return true of object equils</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is MathVector))
            {
                return false;
            }
            else
            {
                var tempVector = obj as MathVector;
                return this.Lenght == tempVector.Lenght ? true : false;
            }
        }
    }
}