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
    }
}
