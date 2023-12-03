using System.IO;
using System.Text.RegularExpressions;

string[] input = File.ReadAllLines("input.txt");

task2(input);

static void task1(string[] input)
{
    int total = 0;

    foreach (string i in input)
    {
        string result = "";
        string numbers = Regex.Replace(i, "[^0-9]", "");

        result = numbers[0].ToString() + numbers[numbers.Length - 1].ToString();
        total += Convert.ToInt32(result);
    }
    Console.WriteLine(total);
}

static void task2(string[] input)
{
    int total = 0;

    foreach (string i in input)
    {
        string result = "";
        string[] findings = new string[i.Length];
        MatchCollection matches = Regex.Matches(i, @"(?=(?:1|one)|(?:2|two)|(?:3|three)|(?:4|four)|(?:5|five)|(?:6|six)|(?:7|seven)|(?:8|eight)|(?:9|nine))");
        Regex.

        Console.WriteLine(matches[0].Value);

        string[] findingsArr = matches.Cast<Match>().Select(x => x.Value).ToArray();



        int j = 0;
        foreach (string f in findingsArr)
        {
            findingsArr[j] = findingsArr[j].Replace("one", "1");
            findingsArr[j] = findingsArr[j].Replace("two", "2");
            findingsArr[j] = findingsArr[j].Replace("three", "3");
            findingsArr[j] = findingsArr[j].Replace("four", "4");
            findingsArr[j] = findingsArr[j].Replace("five", "5");
            findingsArr[j] = findingsArr[j].Replace("six", "6");
            findingsArr[j] = findingsArr[j].Replace("seven", "7");
            findingsArr[j] = findingsArr[j].Replace("eight", "8");
            findingsArr[j] = findingsArr[j].Replace("nine", "9");
            j++;
        }

        result = findingsArr[0].ToString() + findingsArr[findingsArr.Length - 1].ToString();
        total += Convert.ToInt32(result);

    }
    Console.WriteLine(total);
}