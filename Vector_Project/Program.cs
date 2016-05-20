namespace Vector_Project
{
    using System;

    class Program
    {
        static void Main()
        {
            // Console Cutomizate
            Console.Title = "Vector by Vitaliy Belyakov";
            Random ran=new Random();

            // Members
            Vector<int> myVector=new Vector<int>();

            // Add some element
            for (int i = 0; i < 10; i++)
            {
                myVector.Add((ran.Next(10,100)));
            }

            // Check foreach construction
            foreach (var value in myVector)
            {
                Console.WriteLine(value.ToString());
            }

            // Get hash code
            Console.WriteLine();
            Console.WriteLine(myVector.GetHashCode());

            
            Console.WriteLine();

            // TrySort by date type sort if they realizate ICompareble<T> interface
            if (myVector.TrySort())
            {

                // Show sorted list
                foreach (var value in myVector)
                {
                    Console.WriteLine(value.ToString());
                }
            }
            
            // Get hash code
            Console.WriteLine();
            Console.WriteLine(myVector.GetHashCode());

            // Equils tests
            var temp = myVector;

            Console.WriteLine(myVector.Equals(myVector));
            Console.WriteLine();

            var mySecTemp=new Vector<int>();
            Console.WriteLine(myVector.Equals(mySecTemp));

            Console.ReadKey();
        }
    }
}
