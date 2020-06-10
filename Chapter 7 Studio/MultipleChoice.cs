using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Chapter_7_Studio
{
    public class MultipleChoice : Question
    {

#nullable enable

        private readonly string _answer;

        private List<string> _options = new List<string>();

        public MultipleChoice(string question, string answer, params string[] incorrect) : base(question)
        {
            _answer = answer;

            _options.Add(_answer);

            foreach (string s in incorrect)
                _options.Add(s);
        }

        public override string ToString()
        {
            _options = _options.Randomize().ToList();

            string result = $"{QuestionText} (Select One)\n";

            int count = 1;

            foreach(string s in _options)
            {
                result = $"{result}{count}: {s}\n";

                count++;
            }

            return result;
        }

        public override bool IsCorrect(string answerProvided)
        {
            if (answerProvided.ToLower() == _answer.ToLower())
                return true;

            if (int.TryParse(answerProvided, out int intProvided) == false)
                return false;

            intProvided--;

            if (intProvided >= _options.Count)
                return false;

            if (intProvided < 0)
                return false;

            if (_options[intProvided] == _answer)
                return true;

            return false;
        }
    }
}
