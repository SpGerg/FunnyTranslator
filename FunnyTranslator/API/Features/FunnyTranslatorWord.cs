using FunnyTranslator.API.Enums;
using FunnyTranslator.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTranslator.API
{
    public class FunnyTranslatorWord : IFunnyWord
    {
        public string Word { get; }

        public List<FunnyTranslatorWordType> Types { get; }

        public FunnyTranslatorWord(string word)
        {
            Word = word;
            Types = new List<FunnyTranslatorWordType>();
        }

        public FunnyTranslatorWord(string word, List<FunnyTranslatorWordType> types)
        {
            Word = word;
            Types = types;
        }

        public FunnyTranslatorWord(string word, List<FunnyTranslatorWordType> types, Dictionary<string, FunnyTranslatorWord> words)
        {
            Word = word;
            Types = types;

            words.Add(word, this);
        }
    }
}
