using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class LINQProblems
    {
        public List<string> CheckForContains(List<string> words)
        {
            var newWords = words.Where(x => x.Contains("th"));
            return newWords.ToList();
        }

        public List<string> CopyListWithoutDupes(List<string> words)
        {
            var newWords = words.Distinct();
            return newWords.ToList();
        }

        public double AverageGrade(List<string> grades)
        {
            //First it will look at each string of grades and split when there is a comma
            //Now there will be a list of arrays
            //Then a multi-select is used to convert each string number into a double
            //Then each array in the list is ordered from least to greatest, then the lowest grade is skipped or dropped
            //Then a select many is used to grab every item in the list of arrays and turns it into one big list with every grade
            //Then gives the average
            return  grades.Select(s => s.Split(',')).Select(y => y.Select(z => (Double.Parse(z))).OrderBy(x => x).Skip(1)).SelectMany(x => x).Average();
        }

        public string LetterFrequency(string word)
        {
            word = word.ToLower();
            return String.Join("", word.OrderBy(x => x).Distinct().Select(w => w.ToString() + word.Count(z => z == w)));
        }

    }
}
