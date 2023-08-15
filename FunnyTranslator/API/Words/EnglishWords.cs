using FunnyTranslator.API.Enums;
using FunnyTranslator.API.Languages;
using System;
using System.Collections.Generic;

namespace FunnyTranslator.API.Words
{
    public class EnglishWords : IWords
    {
        private static EnglishWords instance;

        public Dictionary<string, FunnyTranslatorWord> Words { get; } = new Dictionary<string, FunnyTranslatorWord>();

        public FunnyTranslatorLanguageType Type
        {
            get
            {
                return FunnyTranslatorLanguageType.English;
            }
        }

        public static FunnyTranslatorWord Hello = new FunnyTranslatorWord("Hello", new List<Enums.FunnyTranslatorWordType> { FunnyTranslatorWordType.None }, GetInstance().Words);

        public static EnglishWords GetInstance()
        {
            if (instance == null)
            {
                instance = new EnglishWords();
            }

            return instance;
        }
    }
}
