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
            // Declare myArray
            int[] myArray = { 1, 2, 3, 4, 5, 22, 45, 53 };
            // Declare arrLength to be length of myArray
            int arrLength = myArray.Length;

            // For loop (initialization; condition; update)
            for (int i = 0; i < arrLength; i++)
            {
                // For loop body
                Console.WriteLine("array item : " + myArray[i]);
            } // End of FOR loop
        }
    }
}
