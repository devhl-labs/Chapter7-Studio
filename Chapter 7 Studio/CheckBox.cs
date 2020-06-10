using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_7_Studio
{
    public class CheckBox : Question
    {
        private readonly List<string> _answers = new List<string>();

        private List<string> _options = new List<string>();

        private readonly List<string> _incorrect = new List<string>();

        public CheckBox(string question) : base(question)
        {

        }

        public void AddAnswer(bool isTrue, string answer)
        {
            if (isTrue)
                _answers.Add(answer);
            else
                _options.Add(answer);
        }

        public override string ToString()
        {
            _options = new List<string>();

            _options.AddRange(_answers);

            _options.AddRange(_incorrect);

            _options = _options.Randomize().ToList();

            string result = $"{QuestionText} (Separate your answers with a space)\n";

            int counter = 1;

            foreach(string s in _options)
            {
                result = $"{result}{counter}: {s}\n";

                counter++;
            }

            return result;
        }

        public override bool IsCorrect(string providedAnswers)
        {
            string[] answers = providedAnswers.Split(" ");

            foreach(string answer in answers)
            {
                if (int.TryParse(answer, out int intAnswer) == false)
                    return false;

                intAnswer--;

                if (intAnswer < 0 || intAnswer >= _options.Count)
                    return false;

                if (_answers.Any(s => s == _options[intAnswer]) == false)
                    return false;
            }

            return true;
        }
    }
}
