using FunnyTranslator.API.Enums;
using System.Collections.Generic;

namespace FunnyTranslator.API.Words
{
    public static class Words
    {
        public static IReadOnlyDictionary<FunnyTranslatorLanguageType, IWords> LanguageWords = new Dictionary<FunnyTranslatorLanguageType, IWords>
        {
            { FunnyTranslatorLanguageType.Russian, RussianWords.GetInstance() },
            { FunnyTranslatorLanguageType.English, EnglishWords.GetInstance() },
        };
    }
}
