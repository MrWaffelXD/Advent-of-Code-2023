using System.IO;

namespace Day2
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
            int maxRed = 12;
            int maxGreen = 13;
            int maxBlue = 14;

            int totalScore = 0;

            foreach (string game in input)
            {
                bool isValid = true;

                int gameNum = Convert.ToInt32(game.Split(':')[0].Split(' ')[1]);
                string[] rounds = game.Split(';');
                rounds[0] = rounds[0].Split(':')[1];
                foreach (string round in rounds)
                {
                    string[] colours = round.Split(',');

                    foreach (string colour in colours)
                    {
                        string[] c = colour.Split(" ");
                        string color = c[2];
                        int amount = Convert.ToInt32(c[1]);                        

                        switch (color)
                        {
                            case "red":
                                if(amount > maxRed)
                                {
                                    isValid = false;
                                }
                                break;
                            case "green":
                                if(amount > maxGreen)
                                {
                                    isValid = false;
                                }
                                break;
                            case "blue":
                                if (amount > maxBlue)
                                {
                                    isValid = false;
                                }
                                break;
                        }
                    }
                }

                if (isValid)
                {
                    totalScore += gameNum;
                }
            }
            Console.WriteLine(totalScore);
        }
        static void Task2(string[] input)
        {

        }
    }
}