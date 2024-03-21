/*Modulus
We need to pack 142 toys in boxes. Each box holds 15 toys.

Task
Write a program to calculate and output how many toys will be left after packing.

Hint
Find the remainder from dividing 142 by 15.

Use the modulo operator (%) to get the remainder.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(142%15);
            
        }
    }
}