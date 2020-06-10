using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Studio
{
    public class Quiz
    {
        public List<Question> Questions { get; } = new List<Question>();

        private int _questionsAnswer = 0;

        private int _correctAnswer = 0;

        public void Start()
        {
            _questionsAnswer = 0;

            _correctAnswer = 0;

            foreach(Question question in Questions.Randomize())
            {
                Console.WriteLine(question);

                string input = Console.ReadLine();

                _questionsAnswer++;

                if (question.IsCorrect(input))
                    _correctAnswer++;
            }

            Console.WriteLine($"You scored {_correctAnswer} out of {_questionsAnswer}");
        }
    }
}
