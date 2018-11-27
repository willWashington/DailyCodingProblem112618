using System;
using System.Diagnostics;
using System.Linq;

namespace DailyCodingProblem112618
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                This problem was asked by Uber.
                Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers 
                in the original array except the one at i. For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. 
                If our input was [3, 2, 1], the expected output would be [2, 3, 6].
                Follow-up: what if you can't use division?
            */

            int[] values1 = new int[] { 1, 2, 3, 4, 5 };
            int[] i = new int[] { 1 };

            var result = values1.Except(i);
            
            var multiplied = result.Aggregate(values1[1], (a, b) => a * b);
            Debug.WriteLine(multiplied); //Output 1200000 ((((5*10)*20)*30)*40)

            //this needs a foreach statement that runs multiplied against every character in the array, I believe
            //https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=netframework-4.7.2
            //https://www.dotnetperls.com/except
            //https://stackoverflow.com/questions/7105505/linq-aggregate-algorithm-explained



        }
    }
}
