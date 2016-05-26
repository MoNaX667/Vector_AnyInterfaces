namespace Vector_Project
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class TVectorGenerator<T>: IEnumerable<Vector<T>> where T:struct
    {
        public TVectorGenerator(int count, int start = 0)
        {
            this.Count = count;
            this.Start = start;
        }

        public int Start { get; private set; }

        public int Count { get; private set; }

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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
