using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display number from 0 to 9
            int[] myArray = { 1, 2, 3, 4, 5, 22, 45, 53 };
            int arrLength = myArray.Length;

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine("array item : " + myArray[i]);
            }
        }
    }
}
