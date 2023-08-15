using FunnyTranslator.API.Enums;
using FunnyTranslator.API.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTranslator.API.Words
{
    public class RussianWords : IWords
    {
        private static RussianWords instance;

        public Dictionary<string, FunnyTranslatorWord> Words { get; } = new Dictionary<string, FunnyTranslatorWord>();

        public FunnyTranslatorLanguageType Type {
            get 
            {
                return FunnyTranslatorLanguageType.Russian;
            } 
        }

        public static FunnyTranslatorWord Привет = new FunnyTranslatorWord("Привет", new List<Enums.FunnyTranslatorWordType> { FunnyTranslatorWordType.None }, GetInstance().Words);

        public static RussianWords GetInstance()
        {
            if (instance == null)
            {
                instance = new RussianWords();
            }

            return instance;
        }
    }
}
