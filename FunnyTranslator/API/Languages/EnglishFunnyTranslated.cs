using FunnyTranslator.API.Enums;
using FunnyTranslator.API.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTranslator.API.Languages
{
    public class EnglishFunnyTranslated : IFunnyTranslated
    {
        private static EnglishFunnyTranslated instance;

        public Dictionary<FunnyTranslatorLanguageType, Dictionary<FunnyTranslatorWord, FunnyTranslatorWord>> TranslatedWords => new Dictionary<FunnyTranslatorLanguageType, Dictionary<FunnyTranslatorWord, FunnyTranslatorWord>>
        {
            { FunnyTranslatorLanguageType.Russian, new Dictionary<FunnyTranslatorWord, FunnyTranslatorWord>
            {
                { RussianWords.Привет, EnglishWords.Hello }
            }
            }
        };

        public IWords LanguageWords => EnglishWords.GetInstance();

        public FunnyTranslatorLanguageType LanguageType => FunnyTranslatorLanguageType.English;

        public static EnglishFunnyTranslated GetInstance()
        {
            if (instance == null)
            {
                instance = new EnglishFunnyTranslated();
            }

            return instance;
        }
    }
}
