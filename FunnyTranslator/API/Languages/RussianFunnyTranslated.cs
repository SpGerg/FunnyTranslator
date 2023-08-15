using FunnyTranslator.API.Enums;
using FunnyTranslator.API.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTranslator.API.Languages
{
    public class RussianFunnyTranslated : IFunnyTranslated
    {
        private static RussianFunnyTranslated instance;

        public Dictionary<FunnyTranslatorLanguageType, Dictionary<FunnyTranslatorWord, FunnyTranslatorWord>> TranslatedWords => new Dictionary<FunnyTranslatorLanguageType, Dictionary<FunnyTranslatorWord, FunnyTranslatorWord>>
        {
            { FunnyTranslatorLanguageType.English, new Dictionary<FunnyTranslatorWord, FunnyTranslatorWord>
            {
                { RussianWords.Привет, EnglishWords.Hello }
            }
            }
        };
        public IWords LanguageWords => RussianWords.GetInstance();

        public FunnyTranslatorLanguageType LanguageType => FunnyTranslatorLanguageType.Russian;

        public static RussianFunnyTranslated GetInstance()
        {
            if (instance == null)
            {
                instance = new RussianFunnyTranslated();
            }

            return instance;
        }
    }
}
