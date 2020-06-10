using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Studio
{
    public class TrueFalse : Question
    {
        private readonly bool _answer;

        public TrueFalse(string question, bool answer) : base(question)
        {
            _answer = answer;
        }

        public override bool IsCorrect(string providedAnswer)
        {
            providedAnswer = providedAnswer.ToLower();

            if (_answer && (providedAnswer == "t" || providedAnswer == "true" || providedAnswer == "ture" || providedAnswer == "y" || providedAnswer == "yes"))
                return true;

            if (!_answer && (providedAnswer == "f" || providedAnswer == "false" || providedAnswer == "fasle" || providedAnswer == "n" || providedAnswer == "no"))
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"{QuestionText} (T/F)";
        }
    }
}
