using System.IO;
using System.Text.RegularExpressions;

string[] input = File.ReadAllLines("input.txt");

task1(input);

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
    string[] inputReplaced = input.Select(x => x.Replace("one", "1")).ToArray();
    inputReplaced = input.Select(x => x.Replace("two", "2")).ToArray();
    inputReplaced = input.Select(x => x.Replace("three", "3")).ToArray();
    inputReplaced = input.Select(x => x.Replace("four", "4")).ToArray();
    inputReplaced = input.Select(x => x.Replace("five", "5")).ToArray();
    inputReplaced = input.Select(x => x.Replace("six", "6")).ToArray();
    inputReplaced = input.Select(x => x.Replace("seven", "7")).ToArray();
    inputReplaced = input.Select(x => x.Replace("eight", "8")).ToArray();
    inputReplaced = input.Select(x => x.Replace("nine", "9")).ToArray();

    Console.WriteLine();
}