using FunnyTranslator.API.Enums;
using System.Collections.Generic;

namespace FunnyTranslator.API.Features
{
    public interface IFunnyWord
    {
        string Word { get; }
        List<FunnyTranslatorWordType> Types { get; }
    }
}
