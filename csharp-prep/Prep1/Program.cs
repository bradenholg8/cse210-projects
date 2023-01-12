using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 93)
        {
            letter = "A";
        }
        else if (percent <= 92 && percent >=90)
        {
            letter = "A-";
        }
        else if (percent <= 89 && percent >= 87)
        {
            letter = "B+";
        }
        else if (percent <= 86 && percent >= 83)
        {
            letter = "B";
        }
        else if (percent <= 82 && percent >= 80)
        {
            letter = "B-";
        }
        else if (percent <= 79 && percent >= 77)
        {
            letter = "C+";
        }
        else if (percent <= 76 && percent >= 73)
        {
            letter = "C";
        }
        else if (percent <= 72 && percent >= 70)
        {
            letter = "C-";
        }
        else if (percent <= 69 && percent >= 67)
        {
            letter = "D+";
        }
        else if (percent <= 66 && percent >= 63)
        {
            letter = "D";
        }
        else if (percent <= 62 && percent >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}