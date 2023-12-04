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
                int cardScore = 0;

                string cartRaw = Regex.Replace(card, @"Card {1,}\d{1}:", "");

                string[] cartValues = cartRaw.Split('|');

                //int[] winningValues = Regex.Matches(cartValues[0], @"\d{1,}").Cast<Match>().Select(m => Convert.ToInt32(m.Value)).ToArray();
                List<int> winningValues = new List<int>();
                List<int> scratchedValues = new List<int>();

                winningValues.AddRange(Regex.Matches(cartValues[0], @"\d{1,}").Cast<Match>().Select(m => Convert.ToInt32(m.Value)).ToArray());
                scratchedValues.AddRange(Regex.Matches(cartValues[1], @"\d{1,}").Cast<Match>().Select(m => Convert.ToInt32(m.Value)).ToArray());
                //int[] scratchedValues = Regex.Matches(cartValues[1], @"\d{1,}").Cast<Match>().Select(m => Convert.ToInt32(m.Value)).ToArray();

                foreach(int scratched in scratchedValues)
                {
                    if(winningValues.Find(val => val == scratched) == scratched)
                    {
                        winningValues.Remove(scratched);

                        if(cardScore == 0)
                        {
                            cardScore++;
                        }
                        else
                        {
                            cardScore = cardScore * 2;
                        }
                    }
                }

                totalScore += cardScore;
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