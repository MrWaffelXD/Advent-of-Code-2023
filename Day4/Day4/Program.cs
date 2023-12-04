using System.IO;
using System.Text.RegularExpressions;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            Task1(input);
        }
        static void Task1(string[] input)
        {
            int totalScore = 0;
            foreach (string card in input)
            {
                int cardNum = Convert.ToInt32(Regex.Match(card.Split(':')[0], @"\d{1,}").Value);
                string[] numberGroups = card.Split("|");

                numberGroups[0] = Regex.Replace(numberGroups[0], @"Card \d{1,}: ", "");

                MatchCollection wm = Regex.Matches(numberGroups[0], @"\d{1,}");

                string[] winningArr = wm.Cast<Match>().Select(m => m.Value).ToArray();
                string[] scratchedArr = Regex.Matches(numberGroups[1], @"\d{1,}").Cast<Match>().Select(m => m.Value).ToArray();

                List<int> winningNums = StringArrayToIntList(winningArr);
                List<int> scratchedNums = StringArrayToIntList(scratchedArr);

                int score = 0;

                foreach (int scratch in scratchedNums)
                {
                    var x = winningNums.Find(i => i == scratch);
                    if(x == scratch)
                    {
                        if (score == 0)
                        {
                            score++;
                        }
                        else
                        {
                            score *= 2;
                        }
                    }
                }

                totalScore += score;
            }
            Console.WriteLine(totalScore);
        }
        static List<int> StringArrayToIntList(string[] array)
        {
            List<int> list = new List<int>();
            foreach (string a in array)
            {
                if (a != "")
                {
                    list.Add(Convert.ToInt32(a));
                }
            }
            return list;
        }
    }
}