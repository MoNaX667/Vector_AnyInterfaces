using System.Runtime.CompilerServices;

namespace Vector_Project
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            
            // Console Cutomizate
            Console.Title = "MathVector by Vitaliy Belyakov";

            Vector<MathVector> myVector=new Vector<MathVector>();

            // Add some eleent in random list
            for (int i = 0; i < 10; i++)
            {
                myVector.Add(CreateRandomVector());
                Thread.Sleep(20);
            }

            // Output random list
            Console.WriteLine("Random list");

            foreach (var value in myVector)
            {
                Console.WriteLine(value.ToString());
            }

            Console.WriteLine(new string('-',30));

            // Sort and output random list
            myVector.TrySort();

            Console.WriteLine("Sorted Random List");

            foreach (var value in myVector)
            {
                Console.WriteLine(value.ToString());
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Create some vector
        /// </summary>
        /// <returns></returns>
        private static MathVector CreateVector()
        {
            // Members
            MathVector vectorA;
            int startX = 0, startY = 0, endX = 0, endY = 0;
            string name;

            InputCoordinate(out startX);
            InputCoordinate(out startY);
            InputCoordinate(out endX);
            InputCoordinate(out endY);
            name = InputName();

            vectorA=new MathVector(name[0], name[1], startX, startY, endX, endY);
            return vectorA;
        }

        /// <summary>
        /// Do true while loop for check user input coordinate
        /// </summary>
        /// <param name="coordinate"></param>
        private static void InputCoordinate(out int coordinate)
        {
            string tempString;

            // Input startX
            while (true)
            {
                tempString = Console.ReadLine();

                if (int.TryParse(tempString, out coordinate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input ... try again");
                }
            }
        }

        /// <summary>
        /// Input vector name
        /// </summary>
        private static string InputName()
        {
            char tempChar;
            string name = " ";


            // Input startX
            while (true)
            {
                tempChar = Console.ReadKey().KeyChar;

                if (name.Length < 2 && char.IsLetter(tempChar))
                {
                    name += tempChar;
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input ... try again");
                }
            }

            return name;
        }

        /// <summary>
        /// Create random vector
        /// </summary>
        /// <returns>Return new vector</returns>
        private static MathVector CreateRandomVector()
        {
            Random ran =new Random();
            int startEnglishUpLetter = 65;
            int endEnglishUpLetter = 90;

            return new MathVector
                (ran.Next(10,100),
                ran.Next(10,100),
                string.Format("{0}{1}",(char)ran.Next(startEnglishUpLetter, endEnglishUpLetter),
                (char)ran.Next(startEnglishUpLetter, endEnglishUpLetter))
                );
        }
    }
}
