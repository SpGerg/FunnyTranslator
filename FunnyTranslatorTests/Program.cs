using FunnyTranslator.API.Enums;
using FunnyTranslator.API.Languages;
using System;

namespace FunnyTranslatorTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FunnyTranslator.API.FunnyTranslator.GetTranslatedText("Привет мир и привет и привет", FunnyTranslatorLanguageType.Russian, EnglishFunnyTranslated.GetInstance()));

            Console.ReadKey();
        }
    }
}
