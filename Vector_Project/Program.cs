using System.Runtime.CompilerServices;
using System.Threading;

namespace Vector_Project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            
            // Console Cutomizate
            Console.Title = "MathVector by Vitaliy Belyakov";

            // Create generator and vector list with generated new vectors
            var myVectorGenerator = new TVectorGenerator<int>(100);
            VectorCollection<int> myVectorCollection=new VectorCollection<int>(myVectorGenerator.Take(6).ToArray());
          
            // Output start vectors of vector <T> collection
            Console.WriteLine(new string('-',60));
            Console.WriteLine("Base generated vector<T> collection: ");
            Console.WriteLine();

            foreach (var vector in myVectorCollection)
            {
                Console.WriteLine(vector.ToString());
            }

            // Sorted vectors of vector <T> collection
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Sorted generated vector<T> collection: ");
            Console.WriteLine();
            myVectorCollection.Sort();

            foreach (var vector in myVectorCollection)
            {
                Console.WriteLine(vector.ToString());
            }

            // Operation tests
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Operation tests: ");

            // Addition
            Console.WriteLine();
            Console.WriteLine("Addition");
            Console.WriteLine(
                "{0} + {1} = {2}", myVectorCollection[0].Name,
                myVectorCollection[1].Name,
                myVectorCollection[0] + myVectorCollection[1]);

            // Substraction
            Console.WriteLine();
            Console.WriteLine("Substraction");
            Console.WriteLine(
                "{0} - {1} = {2}",myVectorCollection[2].Name,
                myVectorCollection[3].Name,
                myVectorCollection[2] - myVectorCollection[3]);

            // More operation
            Console.WriteLine();
            Console.WriteLine("More operator");
            Console.WriteLine(
                "{0} > {1} = {2}", myVectorCollection[0].Name,
                myVectorCollection[1].Name,
                myVectorCollection[0] > myVectorCollection[1]);

            // Less operation
            Console.WriteLine();
            Console.WriteLine("Less operator");
            Console.WriteLine(
                "{0} < {1} = {2}", myVectorCollection[2].Name,
                myVectorCollection[3].Name,
                myVectorCollection[2] < myVectorCollection[3]);

            Console.ReadKey();
        }

    }
}
