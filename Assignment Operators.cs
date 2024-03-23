/*Assignment Operators
Write a program to take monthly salary as input, and calculate and output the annual income.

Sample Input
800

Sample Output
9600

Use the *= shorthand for easier calculus.
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
          int salary = Convert.ToInt32(Console.ReadLine());  
          Console.WriteLine(salary * 12);

        }
    }
}