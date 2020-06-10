using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Studio
{
    public abstract class Question
    {
        public string QuestionText { get; }

        public Question(string questionText)
        {
            QuestionText = questionText;
        }

        public abstract bool IsCorrect(string providedAnswer);
    }
}
