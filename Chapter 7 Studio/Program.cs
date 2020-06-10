using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_7_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() > 0)
                Console.WriteLine(args);

            Quiz quiz = new Quiz();

            quiz.Questions.Add(new MultipleChoice("How much wood does a wood chuck chuch?", "this is the answer", "over 9000", "42", "all of it"));
            quiz.Questions.Add(new MultipleChoice("How many planets are there?", "8", "6", "7", "10"));
            quiz.Questions.Add(new TrueFalse("Programming is fun! (hint the answer is true)", true));

            CheckBox checkBox = new CheckBox("Which of these are programming languages?");
            checkBox.AddAnswer(true, "JavaScript");
            checkBox.AddAnswer(true, "C#");
            checkBox.AddAnswer(false, "the internet");
            checkBox.AddAnswer(false, "sending an email");
            quiz.Questions.Add(checkBox);

            ShortAnswer shortAnswer = new ShortAnswer(80, "Why do you like writing code?");
            quiz.Questions.Add(shortAnswer);

            quiz.Questions.Add(new LinearScale(1, 10, "On a scale of 1 to 10, how well do you understand inheritance?"));

            string input = string.Empty;

            while(input != "n")
            {
                Console.WriteLine("Enter 'y' to take the quiz or 'n' to exit");

                input = Console.ReadLine();

                if (input == "y")
                    quiz.Start();
            }
        }        
    }
}
