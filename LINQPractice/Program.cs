using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQProblems lq = new LINQProblems();

            var result = lq.CheckForContains(new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" });
            result.ForEach(word => Console.WriteLine(word));
            Console.WriteLine();

            result = lq.CopyListWithoutDupes(new List<string> { "Mike", "Brad", "Nevin", "Ian", "Mike" });
            result.ForEach(word => Console.WriteLine(word));
            Console.WriteLine();

            var averageGrade = lq.AverageGrade(new List<string> { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" });
            Console.WriteLine(averageGrade);
            Console.WriteLine();

            string frequency = lq.LetterFrequency("Terrill");
            Console.WriteLine(frequency);

            Console.ReadLine();
        }
    }
}
