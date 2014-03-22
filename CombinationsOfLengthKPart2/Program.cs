using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Alternate version of the problem
// Given a string of length n, print all permutation of the given string.
// Repetition of characters is allowed. Print these permutations in lexicographically sorted order 
namespace CombinationsOfLengthKPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            string s = "abc";
            Console.WriteLine("{0} combinations with string {1}", k, s);
            PrintCombinations(s, k);
        }

        static void PrintCombinations(string s, int k)
        {
            string prefix = null;
            PrintCombinations(s, k, prefix);
        }

        static void PrintCombinations(string s, int k, string prefix)
        {
            if (k == 0)
            {
                Console.WriteLine(prefix);
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    PrintCombinations(s, k - 1, prefix + s[i]);
                }
            }
        }

    }
}
