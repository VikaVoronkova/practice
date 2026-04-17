using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sum, min/max, count
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(arr.Sum());

            string[] words = { "hello", "my", "friend" };
            int result = words.Min(x => x.Length);
            int res2 = words.Count(x => x.Length % 2 == 0);
            Console.WriteLine(words.Sum(x => x.Length));

            //Any, All
            bool f1 = words.Any(x => x.Length % 3 == 0);
            bool f2 = words.All(x => x.Length > 1);
            Console.WriteLine(f1);

            //Select, Where
            int[] lengths = words.Select(x => x.Length).ToArray();
            string[] longW = words.Where(x => x.Length > 2).ToArray();

            int[] wordsRes = words.Select(x => x.Length)
                                  .Where(x => x > 2)
                                  .ToArray();

            string word = "hello123";
            bool f = word.Any(x => char.IsDigit(x));
        }
    }
}
