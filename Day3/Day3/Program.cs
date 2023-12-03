using System.IO;
using System.Text.RegularExpressions;

namespace Day3
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
            List<List<char>> inputMap = new List<List<char>>();

            int totalSum = 0;

            int i = 0;

            foreach (string line in input)
            {
                MatchCollection matches = Regex.Matches(line, @"\d{1,}");

                foreach (Match match in matches)
                {
                    Dictionary<string, int> location = new Dictionary<string, int>();
                    location.Add("Line", i);
                    location.Add("Start", match.Index);
                    location.Add("End", match.Index + match.Length - 1);

                    bool isValid = false;

                    if (location["Start"] != 0)                 //Check before string
                    {
                        if (line[location["Start"]-1] != '.' && !Char.IsDigit(line[location["Start"] - 1]))
                        {
                            isValid = true;
                        }
                    }
                    if (location["End"] + 1 != line.Length)
                    {
                        if (line[location["End"] + 1] != '.' && !Char.IsDigit(line[location["End"] + 1]))       //Check after string
                        {
                            isValid = true;
                        }
                    }

                    if (location["Line"] != 0)                  //Check above string
                    {
                        int j = 0;
                        if (location["Start"] != 0)
                        {
                            j = location["Start"] - 1;
                        }

                        while (j <= location["End"] + 1 )
                        {
                            if (j != line.Length && input[location["Line"] - 1][j] != '.' && !Char.IsDigit(input[location["Line"] - 1][j]))
                            {
                                isValid = true;
                            }
                            j++;
                        }
                    }
                    if (location["Line"] + 1 != input.Length)       //Check below string
                    {
                        int j = 0;
                        if (location["Start"] != 0)
                        {
                            j = location["Start"] - 1;
                        }

                        while (j <= location["End"] + 1)
                        {
                            if (j != line.Length && input[location["Line"] + 1][j] != '.' && !Char.IsDigit(input[location["Line"] + 1][j]))
                            {
                                isValid = true;
                            }
                            j++;
                        }
                    }

                    if (isValid)
                    {
                        totalSum += Convert.ToInt32(match.Value);
                    }
                }
                i++;
            }

            Console.WriteLine(totalSum);
        }
    }
}