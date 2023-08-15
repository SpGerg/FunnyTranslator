using FunnyTranslator.API.Enums;
using FunnyTranslator.API.Exceptions;
using FunnyTranslator.API.Languages;
using FunnyTranslator.API.Words;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FunnyTranslator.API
{
    public static class FunnyTranslator
    {
        public static string GetTranslatedText(string text, FunnyTranslatorLanguageType textLanguageType, IFunnyTranslated translator)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Text is null or empty.");
            }

            if (!translator.TranslatedWords.ContainsKey(textLanguageType))
            {
                throw new TranslatorDontContainsLanguageException(); 
            }

            string[] splitted = text.Split(' ');

            string result = text;

            Dictionary<FunnyTranslatorWord, FunnyTranslatorWord> languageWords = translator.TranslatedWords[textLanguageType];

            IFunnyTranslated textTranslator = FunnyTranslated.Translated[textLanguageType];

            foreach (string word in splitted)
            {
                string replaced = word.Replace(",", "").Replace(".", "").Replace(":", "").Replace("!", "").Replace("?", "");

                try
                {
                    result = Regex.Replace(result, replaced, languageWords[textTranslator.LanguageWords.Words[replaced]].Word, RegexOptions.IgnoreCase);
                }
                catch (KeyNotFoundException)
                {
                    continue;
                }
            }

            return result;
        }
    }
}
