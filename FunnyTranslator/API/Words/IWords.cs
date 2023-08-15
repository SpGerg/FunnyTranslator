using FunnyTranslator.API.Enums;
using System.Collections.Generic;

namespace FunnyTranslator.API.Words
{
    public interface IWords
    {
        Dictionary<string, FunnyTranslatorWord> Words { get; }

        FunnyTranslatorLanguageType Type { get; }
    }
}
