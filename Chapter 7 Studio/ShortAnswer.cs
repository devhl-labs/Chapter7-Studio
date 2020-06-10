using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Studio
{
    public class ShortAnswer : Question
    {
        private readonly int _maxLength;

        public ShortAnswer(int maxLength, string question) : base(question)
        {
            _maxLength = maxLength;
        }

        public override bool IsCorrect(string providedAnswer)
        {
            if (providedAnswer.Length > 0 && providedAnswer.Length <= _maxLength)
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"{QuestionText} (Enter {_maxLength} or fewer characters)";
        }
    }
}
