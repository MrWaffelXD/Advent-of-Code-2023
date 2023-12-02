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
    foreach (string i in input)
    {
        string result = "";
        string[] findings = new string[i.Length];

        MatchCollection matchesOne = Regex.Matches(i,@"(?:1|one)");
        MatchCollection matchesTwo = Regex.Matches(i, @"(?:2|two)");
        MatchCollection matchesThree = Regex.Matches(i, @"(?:3|three)");
        MatchCollection matchesFour = Regex.Matches(i, @"(?:4|four)");
        MatchCollection matchesFive = Regex.Matches(i, @"(?:5|five)");
        MatchCollection matchesSix = Regex.Matches(i, @"(?:6|six)");
        MatchCollection matchesSeven = Regex.Matches(i, @"(?:7|seven)");
        MatchCollection matchesEight = Regex.Matches(i, @"(?:8|eight)");
        MatchCollection matchesNine = Regex.Matches(i, @"(?:9|nine)");

        foreach (Match m in matchesOne)
        {
            findings[m.Index] = "1";
        }
        foreach (Match m in matchesTwo)
        {
            findings[m.Index] = "2";
        }
        foreach (Match m in matchesThree)
        {
            findings[m.Index] = "3";
        }
        foreach (Match m in matchesFour)
        {
            findings[m.Index] = "4";
        }
        foreach (Match m in matchesFive)
        {
            findings[m.Index] = "5";
        }
        foreach (Match m in matchesSix)
        {
            findings[m.Index] = "6";
        }
        foreach (Match m in matchesSeven)
        {
            findings[m.Index] = "7";
        }
        foreach (Match m in matchesEight)
        {
            findings[m.Index] = "8";
        }
        foreach (Match m in matchesNine)
        {
            findings[m.Index] = "9";
        }

        findings = findings.Where(x => x != null).ToArray();

        result = findings[0].ToString() + findings[findings.Length - 1].ToString();

        Console.WriteLine("");
    }


    /*int total = 0;

    foreach (string i in input)
    {
        string inputChanged = i;
        Regex reg1 = new Regex(Regex.Escape("one"));
        Regex reg2 = new Regex(Regex.Escape("two"));
        Regex reg3 = new Regex(Regex.Escape("three"));
        Regex reg4 = new Regex(Regex.Escape("four"));
        Regex reg5 = new Regex(Regex.Escape("five"));
        Regex reg6 = new Regex(Regex.Escape("six"));
        Regex reg7 = new Regex(Regex.Escape("seven"));
        Regex reg8 = new Regex(Regex.Escape("eight"));
        Regex reg9 = new Regex(Regex.Escape("nine"));

        int j = 0;

        while (j <= i.Length)
        {
            string curr = 
            switch (inputChanged)
            {
                case "one":
                    inputChanged = reg1.Replace(inputChanged, "1", 1);
                    break;
                case "two":
                    inputChanged = reg2.Replace(inputChanged, "2", 1); ;
                    break;
                case "three":
                    inputChanged = reg3.Replace(inputChanged, "3", 1);
                    break;
                case "four":
                    inputChanged = reg4.Replace(inputChanged, "4", 1);
                    break;
                case "five":
                    inputChanged = reg5.Replace(inputChanged, "5", 1);
                    break;
                case "six":
                    inputChanged = reg6.Replace(inputChanged, "6", 1);
                    break;
                case "seven":
                    inputChanged = reg7.Replace(inputChanged, "7", 1);
                    break;
                case "eight":
                    inputChanged = reg8.Replace(inputChanged, "8", 1);
                    break;
                case "nine":
                    inputChanged = reg9.Replace(inputChanged, "9", 1);
                    break;
            }
            j++;
        }

        /*string inputChanged = i.Replace("one", "1");
        inputChanged = inputChanged.Replace("two", "2");
        inputChanged = inputChanged.Replace("three", "3");
        inputChanged = inputChanged.Replace("four", "4");
        inputChanged = inputChanged.Replace("five", "5");
        inputChanged = inputChanged.Replace("six", "6");
        inputChanged = inputChanged.Replace("seven", "7");
        inputChanged = inputChanged.Replace("eight", "8");
        inputChanged = inputChanged.Replace("nine", "9");

        string result = "";
        string numbers = Regex.Replace(inputChanged, "[^0-9]", "");

        result = numbers[0].ToString() + numbers[numbers.Length - 1].ToString();
        total += Convert.ToInt32(result);
}

    Console.WriteLine(total);*/
}