using System;
using System.Text.RegularExpressions;

namespace Stringalyzer
{
    public class Analyzer
    {
        private readonly string _input;
        private readonly string[] _input_tokens;
        private readonly char[] _delimiters = new char[] { ' ', ',', '.', '!', '?', '\n', '(', ')', ':', ';', }; 

        public Analyzer(string toAnalyze)
        {
            _input = toAnalyze;
            _input_tokens = _input.Split(_delimiters, StringSplitOptions.RemoveEmptyEntries);
        }

        private int? _totalWords;
        public int TotalWords
        {
            get => CountAllWords();
            private set => _totalWords = value;
        }

        private int CountAllWords()
        {
            if (_totalWords == null)
            {
                _totalWords = _input_tokens.GetLength(0);
            }
            return (int)_totalWords;
        }
    }
}
