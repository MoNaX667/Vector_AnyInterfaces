// <copyright file="TVectorGenerator.cs" company="Some Company">
// Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Vitalit Belyakov</author>

namespace Vector_Project
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Some vector generator
    /// </summary>
    /// <typeparam name="T">Enum of vector</typeparam>
    internal class TVectorGenerator<T> : IEnumerable<Vector<T>> where T : struct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TVectorGenerator {T}" /> class
        /// </summary>
        /// <param name="count">Count of element</param>
        /// <param name="start">Start index</param>
        public TVectorGenerator(int count, int start = 0)
        {
            this.Count = count;
            this.Start = start;
        }

        /// <summary>
        /// Gets start index
        /// </summary>
        public int Start { get; private set; }

        /// <summary>
        /// Gets count
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Return some elem
        /// </summary>
        /// <returns>some enum</returns>
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            Random ran = new Random();

            for (int i = this.Start; i < this.Start + this.Count; i++)
            {
                yield return new Vector<T>(
                    string.Format("{0}{0}", (char)ran.Next(65, 90)),
                    (dynamic)ran.Next(1, 99),
                    (dynamic)ran.Next(1, 99));
            }
        }

        /// <summary>
        /// Return some enum
        /// </summary>
        /// <returns>Some enum</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
