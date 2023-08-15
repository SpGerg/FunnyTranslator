using FunnyTranslator.API.Enums;
using FunnyTranslator.API.Words;
using System.Collections.Generic;

namespace FunnyTranslator.API
{
    public interface IFunnyTranslated
    {
        Dictionary<FunnyTranslatorLanguageType, Dictionary<FunnyTranslatorWord, FunnyTranslatorWord>> TranslatedWords { get; }

        IWords LanguageWords { get; }

        FunnyTranslatorLanguageType LanguageType { get; }
    } 
}
