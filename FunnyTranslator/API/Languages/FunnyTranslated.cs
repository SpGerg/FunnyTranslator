using FunnyTranslator.API.Enums;
using System.Collections.Generic;

namespace FunnyTranslator.API.Languages
{
    public class FunnyTranslated
    {
        public static IReadOnlyDictionary<FunnyTranslatorLanguageType, IFunnyTranslated> Translated { get; } = new Dictionary<FunnyTranslatorLanguageType, IFunnyTranslated>
        {
            { FunnyTranslatorLanguageType.Russian, RussianFunnyTranslated.GetInstance() },
            { FunnyTranslatorLanguageType.English, EnglishFunnyTranslated.GetInstance() }
        };
    }
}
