using System.Runtime.InteropServices;

namespace Vector_Project
{
    using System;

    class Program
    {
        static void Main()
        {
            // Console Cutomizate
            Console.Title = "Vector by Vitaliy Belyakov";

            // Members
            Vector<int> myVector=new Vector<int>();


            // Some test
            for (int i = 0; i < 10; i++)
            {
                myVector.Add((i + 15));
            }

            Console.WriteLine(myVector.ToString());

            //int indexer = 0;

            //foreach (var value in myVector)
            //{
            //    Console.WriteLine("{0} {1}",indexer, value);
            //    indexer++;
            //}

            Console.ReadKey();
        }
    }
}
