using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7_Studio
{
    public class LinearScale : Question
    {
        private readonly int _min;

        private readonly int _max;

        public LinearScale(int min, int max, string question) : base(question)
        {
            _min = min;

            _max = max;
        }

        public override string ToString()
        {
            return $"{QuestionText} (Enter a number from {_min} to {_max})";
        }

        public override bool IsCorrect(string providedAnswer)
        {
            if (int.TryParse(providedAnswer, out int intAnswer) == false)
                return false;

            if (intAnswer >= _min && intAnswer <= _max)
                return true;

            return false;
        }
    }
}
