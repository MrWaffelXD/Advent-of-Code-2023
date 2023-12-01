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

        List<char> numbersList = numbers.ToCharArray().ToList();

        while (numbersList.Count > 2)
        {
            numbersList.RemoveAt(1);
        }

        if (numbersList.Count == 1)
        {
            result = numbersList[0].ToString() + numbersList[0].ToString();
        }
        else
        {
            result = numbersList[0].ToString() + numbersList[1].ToString();
        }
        total += Convert.ToInt32(result);
    }

    Console.WriteLine(total);
}